﻿using AutoMapper;
using DAL.Identity;
using DAL.interfaces;
using infrastrucure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Dtos;
using StoreApi.Errors;
using StoreApi.Extensions;
using System.Security.Claims;
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
                    Message = ". يوجد خطا فى البريد الإلكترونى",

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
                        Message = ". يوجد خطا فى كلمه السر",

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
                Message = "تمت عميله الدخول بنجاح "
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
                    Message = ". الاسم مستخدم من قبل",

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
                Message = "تم تسجيل جديد بنجاح. يرجى تأكيد عنوان بريدك الإلكتروني عن طريق النقر على رابط التأكيد المرسل إليك"
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
    }
}
