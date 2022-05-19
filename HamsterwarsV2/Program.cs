using HamsterwarsV2.Extensions;
using NLog;
using Microsoft.AspNetCore.HttpOverrides;
using Contacts;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),
"/nlog.config"));

// Add services to the container.
builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});


builder.Services.AddControllers(config =>
{
    config.RespectBrowserAcceptHeader = true;
    config.ReturnHttpNotAcceptable = true;
})
    .AddApplicationPart(typeof(HamsterwarsV2.Presentation.AssemblyReference).Assembly);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var logger = app.Services.GetRequiredService<ILoggerManager>();

app.ConfigureExceptionHandler(logger);
if (app.Environment.IsProduction())
{
    app.UseHsts();

}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseDeveloperExceptionPage(); // visar inte rätt error kod om denna är aktiverad ? middleware aktiveras aldrig
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});
app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
