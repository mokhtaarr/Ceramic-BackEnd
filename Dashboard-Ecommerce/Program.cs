using DAL.Identity;
using DAL.Models;
using DAL.Smtp;
using infrastrucure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MoDbContext>(options => options.UseSqlServer(SmtpConfig.GetConnectionString()));

builder.Services.AddDbContext<AppIdentityDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection"));
});
builder.Services.AddIdentityCore<AppUser>(opt =>
{
   
})
    .AddEntityFrameworkStores<AppIdentityDbContext>().AddDefaultTokenProviders()
    .AddSignInManager<SignInManager<AppUser>>();


builder.Services.AddMvc().AddNToastNotifyToastr(new ToastrOptions()
{
    ProgressBar = true,
    PositionClass = ToastPositions.TopRight,
    PreventDuplicates = true,
    CloseButton = true
});
builder.Services.AddIdentity<DashBoardUser,IdentityRole>().AddEntityFrameworkStores<MoDbContext>();
builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.LoginPath = "/User/SignIn";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
