// Imports
using Optimizely.Opal.Tools;
using OpalDemoTool.Tools.Greetings;

//#region Builder
var builder = WebApplication.CreateBuilder(args);

// Add the Opal Tools service
builder.Services.AddOpalToolService();

// Register each Tool class within the container
builder.Services.AddOpalTool<GreetingsTool>();
//#endregion

//#region App
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();

    // Enable HTTPS - Disabled because Render.com does this at infra level
    //app.UseHttpsRedirection();
} else
{
    app.UseDeveloperExceptionPage();
}

// Enable Opal Tool SDK
app.MapOpalTools();

// Redirect homepage to Discovery endpoint
app.MapGet("/", (HttpContext context) =>
{
    context.Response.Redirect("/discovery", false);
});

app.Run();
//#endregion