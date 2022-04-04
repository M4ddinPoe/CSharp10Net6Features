var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

var configuration = new ConfigurationManager();
var options = new MyOptions();

// This will throw if the section isn't configured
configuration.GetRequiredSection("MyForgottenOptions").Bind(options);

app.Run();

class MyOptions
{
    public string? SettingValue { get; set; }
}
