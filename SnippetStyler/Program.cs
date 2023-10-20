using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

var contentTypeProvider = new FileExtensionContentTypeProvider();
var mappings = contentTypeProvider.Mappings;
// Modify mappings:
mappings[".htm"] += "; charset=utf-8";
mappings[".html"] += "; charset=utf-8";
mappings[".js"] += "; charset=utf-8";
mappings[".svg"] += "; charset=utf-8";

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();

