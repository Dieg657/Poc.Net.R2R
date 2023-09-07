using Microsoft.AspNetCore.Mvc;
using Poc.Net.R2R.Application.Interfaces.Services;
using Poc.Net.R2R.Domain.Models;
using Poc.Net.R2R.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer()
                .RegisterContainer(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => 
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.MapGet("/api/employee", async ([FromServices] IEmployeeService service) =>
{
    return await service.GetAll();
})
.WithName("Get Employees")
.WithOpenApi();

app.MapPost("/api/employee", async ([FromBody] EmployeeDto model, [FromServices] IEmployeeService services) =>
{
    await services.Insert(model);
})
.WithName("Save Employee")
.WithOpenApi();

app.Run();
