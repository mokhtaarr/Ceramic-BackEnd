using AutoMapper;
using DAL.Identity;
using DAL.interfaces;
using infrastrucure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using StoreApi.Dtos;
using StoreApi.Errors;
using StoreApi.Extensions;
using System.Security.Claims;
using System.Text;
using System.Web;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseApiController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        private readonly IEmailSender _emailSender;



        public AccountController
             (UserManager<AppUser> userManager,
              SignInManager<AppUser> signInManager, 
              ITokenService tokenService,
               IMapper mapper,
               IConfiguration config,
               IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _mapper = mapper;
            _config = config;
            _emailSender = emailSender;
        }

        [HttpGet("secret")]
        [Authorize]
        public string getSecret()
        {
            return "secret sting";
        }


        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);

            if (user == null)
            {
                var response = new UserDto
                {
                    statu = false,
                    Message = "يرجي تسجيل بريدك الإلكتروني حتي تتمكن من تسجيل الدخول",
                    MessageEn = "Please register your email to start logging in"

                };

                return response;
            }

            if(user.EmailConfirmed == false)
            {
                var response = new UserDto
                {
                    statu = false,
                    Message = "يرجى تأكيد البريد الإلكترونى",
                    MessageEn = "Please Confirm Your Email",

                };

                return response;
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);


            if (!result.Succeeded)
            {
                {
                    var response = new UserDto
                    {
                        statu = false,
                        Message = "يوجد خطا فى كلمه السر",
                        MessageEn = "Your password is invalid",

                    };

                    return response;
                }
            }

            return new UserDto
            {
                Email = user.Email,
                Token = _tokenService.CreateToken(user),
                DisplayName = user.DisplayName,
                PhoneNumber = user.PhoneNumber,
                City = user.City,
                Street = user.Street,
                statu = true,
                Message = "تمت عميله الدخول بنجاح ",
                MessageEn = "You have been logged in successfully"
            };
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Regitser(RegisterDto registerDto)
        {

            var exitingUserName = _userManager.Users.FirstOrDefault(u => u.UserName == registerDto.DisplayName);

            if (exitingUserName != null)
            {
                var response = new UserDto
                {
                    statu = false,
                    Message = "الاسم مستخدم من قبل",
                    MessageEn = "The name is already in use",

                };

                return response;
            };

            var exitingEmail = _userManager.Users.FirstOrDefault(u => u.Email == registerDto.Email);

            if (exitingEmail != null)
            {
                var response = new UserDto
                {
                    statu = false,
                    Message = ". البريد الإلكتروني مستخدم من قبل",
                    MessageEn = "Email is already in use",
                };

                return response;
            }


            var user = new AppUser
            {
                DisplayName = registerDto.DisplayName,
                Email = registerDto.Email,
                UserName = registerDto.DisplayName,
                PhoneNumber = registerDto.PhoneNumber,
                City = registerDto.City,
                Street = registerDto.Street
            };
            
            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
            {
                var response = new UserDto
                {
                    statu = false,
                    Message = "فشل في التسجيل",
                    MessageEn = "Failed to register",
                };

                return response;
            }



            var userFromDb = await _userManager.FindByEmailAsync(registerDto.Email);
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(userFromDb);

            var uriBuilder = new UriBuilder(_config["ReturnPaths:ConfirmEmail"]);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["token"] = token;

            query["userid"] = userFromDb.Id;
            uriBuilder.Query = query.ToString();


            var url = uriBuilder.ToString();

            var urlString = $"Hello : {user.DisplayName}  " +
                "please Confirm your Email address by clicking on the following link  :  " +

                $"{url}"
                ;


            var senderEmail = _config["ReturnPaths:SenderEmail"];

            await _emailSender.SendEmailAsync(senderEmail, userFromDb.Email, "Confirm your email address", urlString);

            return new UserDto
            {
                DisplayName = user.DisplayName,
                Token = _tokenService.CreateToken(user),
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                City = user.City,
                Street = user.Street,
                statu = true,
                Message = "تم تسجيل جديد بنجاح. يرجى تأكيد عنوان بريدك الإلكتروني عن طريق النقر على رابط التأكيد المرسل إليك",
                MessageEn = "Please confirm your email address by clicking on the confirmation link sent to you",
            };
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {

            var user = await _userManager.FindByEmailFromClaimsPrincipal(User);

            return new UserDto
            {
                Email = user.Email,
                Token = _tokenService.CreateToken(user),
                DisplayName = user.DisplayName
            };
        }

        [HttpGet("emailexists")]
        public async Task<ActionResult<bool>> CheckEmailExistsAsync([FromQuery] string email)
        {
            return await _userManager.FindByEmailAsync(email) != null;
        }


        [Authorize]
        [HttpGet("address")]
        public async Task<ActionResult<AddressDto>> GetUserAddress()
        {

            var user = await _userManager.FindUserByClaimsPrincipleWithAddress(User);

            return _mapper.Map<Address,AddressDto>(user.Address);
        }

        [Authorize]
        [HttpPut("address")]
        public async Task<ActionResult<AddressDto>> UpdateUserAddress(AddressDto address)
        {
            var user = await _userManager.FindUserByClaimsPrincipleWithAddress(User);

            user.Address = _mapper.Map<AddressDto, Address>(address);

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded) return Ok(_mapper.Map<AddressDto>(user.Address));
            return BadRequest("Problem updating the user");
        }

        [HttpPost("confirmemail")]
        public async Task<IActionResult> ConfirmEmail(ConfirmEmailDto model)
        {
            var userIdWithoutHash = model.UserId.TrimEnd('#');
            var user = await _userManager.FindByIdAsync(userIdWithoutHash);

            var result = await _userManager.ConfirmEmailAsync(user, model.Token);

            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest();
        }


        [HttpPost("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            if (string.IsNullOrEmpty(email)) return BadRequest("Invalid Email");

            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                var response = new
                {
                    statu = false,
                    message = "لم يتم تسجيل هذا البريد الإلكتروني من قبل",
                    messageEn = "this email address has not been registerd yet",
                };

                return Ok(response);

            }

            if (user.EmailConfirmed == false)
            {
                var response = new
                {
                    statu = false,
                    message = "يرجي تأكيد الايميل لإكمال عمليه  تغيير الباسورد",
                    messageEn = "Please confirm your email first to reset your password",
                };

                return Ok(response);
            }

            try
            {
                if(await SendForgetPasswordEmail(user))
                {
                    var Successresponse = new
                    {
                        statu = true,
                        message = "يرجي تاكيد الطلب عبر بريدك الإلكترونى",
                        messageEn = "Please Check Your Email",
                    };

                    return Ok(Successresponse);
                }

                var response = new
                {
                    statu = false,
                    message = "حدث خطأ ما اثناء ارسال البريد الالكتروني",
                    messageEn = "Something went wrong",
                };

                return Ok(response);
            }
            catch
            {
                var response = new
                {
                    statu = false,
                    message = "حدث خطأ ما اثناء ارسال البريد الالكتروني",
                    messageEn = "Something went wrong",
                };
                return Ok(response);

            }
        }

        [HttpPut("reset-password")]
        public async Task<IActionResult> ResetPassword(ResestPasswordDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null) return Unauthorized("this email address has not been register yet");
            if (user.EmailConfirmed == false) return BadRequest("please confirm your email address first");

            try
            {
                var decodedTokenBytes = WebEncoders.Base64UrlDecode(dto.token);
                var decodedToken = Encoding.UTF8.GetString(decodedTokenBytes);

                var result = await _userManager.ResetPasswordAsync(user, decodedToken, dto.NewPassword);
                if (result.Succeeded)
                {
                    var response = new
                    {
                        statu = true,
                        message = "تم تغير الباسورد بنجاح",
                        messageEn = "The password was changed successfully",
                    };

                    return Ok(response);
                }

                var badRequest = new
                {
                    statu = false,
                    message = "حدث خطأ اثناء تغيير الباسورد",
                    messageEn = "Something Went Wrong",
                };

                return Ok(badRequest);

            }
            catch
            {
                var badRequest = new
                {
                    statu = false,
                    message = "حدث خطأ اثناء تغيير الباسورد",
                    messageEn = "Something Went Wrong",
                };

                return Ok(badRequest);
            }

        }


        private async Task<bool> SendForgetPasswordEmail(AppUser user)
        {
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

            var urlBuilder = new UriBuilder(_config["ReturnPaths:ResetPassword"]);

            var query = HttpUtility.ParseQueryString(urlBuilder.Query);

            query["token"] = token;

            urlBuilder.Query = query.ToString();


            var url = urlBuilder.ToString();
            var UserEmail = user.Email;

            var urlString = $"Hello : {user.DisplayName}  " +
                "please click on the following link to reset your Password :  " +

                $"{url}&email={UserEmail}"
                ;


            var senderEmail = _config["ReturnPaths:SenderEmail"];


              await _emailSender.SendEmailAsync(senderEmail, user.Email, "Reset Your Password", urlString);

            return true;

        }
    }
}
