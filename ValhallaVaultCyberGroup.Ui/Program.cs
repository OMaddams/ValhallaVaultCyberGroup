using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberGroup.App.Managers;
using ValhallaVaultCyberGroup.Data.Data;
using ValhallaVaultCyberGroup.Data.Repositories;
using ValhallaVaultCyberGroup.Ui.Components;
using ValhallaVaultCyberGroup.Ui.Components.Account;
using ValhallaVaultCyberGroup.Ui.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", options =>
    {
        options.AllowAnyHeader();
        options.AllowAnyMethod();
        options.AllowAnyOrigin();
    });
});

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
builder.Services.AddScoped<IQuestionsRepo, QuestionsRepo>();
builder.Services.AddScoped<IResultRepo, ResultRepo>();
builder.Services.AddScoped<QuestionManager>();
builder.Services.AddScoped<ResultManager>();



builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

var quizConnectionString = builder.Configuration.GetConnectionString("QuizConnection");
builder.Services.AddDbContext<QuizDbContext>(options =>
    options.UseSqlServer(quizConnectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllers();
builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();



using (ServiceProvider serviceprovider = builder.Services.BuildServiceProvider())
{
    var context = serviceprovider.GetRequiredService<ApplicationDbContext>();
    var signInManager = serviceprovider.GetRequiredService<SignInManager<ApplicationUser>>();
    var roleManager = serviceprovider.GetRequiredService<RoleManager<IdentityRole>>();
    var resultManager = serviceprovider.GetRequiredService<ResultManager>();

    context.Database.Migrate();

    ApplicationUser newUser = new()
    {
        UserName = "user",

        EmailConfirmed = true,
    };
    ApplicationUser newAdmin = new()
    {
        UserName = "admin",

        EmailConfirmed = true,
    };


    var user = signInManager.UserManager.FindByNameAsync(newUser.UserName).GetAwaiter().GetResult();
    var admin = signInManager.UserManager.FindByNameAsync(newAdmin.UserName).GetAwaiter().GetResult();

    if (user == null)
    {
        signInManager.UserManager.CreateAsync(newUser, "Password1234!").GetAwaiter().GetResult();
        var userId = signInManager.UserManager.GetUserIdAsync(newUser).GetAwaiter().GetResult();
        resultManager.CreateUserResults(userId, newUser.UserName).GetAwaiter().GetResult();


    }
    if (admin == null)
    {
        signInManager.UserManager.CreateAsync(newAdmin, "Password1234!").GetAwaiter().GetResult();

        bool adminRoleExists = roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult();

        if (!adminRoleExists)
        {
            IdentityRole adminRole = new()
            {
                Name = "Admin"
            };
            roleManager.CreateAsync(adminRole).GetAwaiter().GetResult();
        }

        signInManager.UserManager.AddToRoleAsync(newAdmin, "Admin").GetAwaiter().GetResult();
        var userId = signInManager.UserManager.GetUserIdAsync(newAdmin).GetAwaiter().GetResult();
        resultManager.CreateUserResults(userId, newAdmin.UserName).GetAwaiter().GetResult();
    }
}




var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.MapControllers();
app.UseCors("AllowAll");

app.Run();
