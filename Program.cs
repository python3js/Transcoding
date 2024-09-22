using Transcoding.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc().AddJsonTranscoding();
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();

app.MapGrpcService<GreeterService>();

app.Run();

// using Microsoft.OpenApi.Models;
// using Transcoding.Services;
//
// var builder = WebApplication.CreateBuilder(args);
//
// // Add services to the container.
// builder.Services.AddGrpc().AddJsonTranscoding();
// builder.Services.AddGrpcSwagger();
// builder.Services.AddSwaggerGen(c =>
// {
//     c.SwaggerDoc("v1",
//         new OpenApiInfo { Title = "gRPC transcoding", Version = "v1" });
// });
//
// var app = builder.Build();
//
// app.UseSwagger();
//
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); });
// }
//
// // Configure the HTTP request pipeline.
// app.MapGrpcService<GreeterService>();
// app.MapGet("/",
//     () =>
//         "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
//
// app.Run();
