using API.Application.BookApplication.GetBook;
using API.Application.BookApplication.MakeBook;
using API.Application.Common;
using API.Data.Repositories.BookRepository;
using MediatR;
using MediatR.Pipeline;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IBookRepository, BookMockRepository>();
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
builder.Services.AddTransient(typeof(IRequestPreProcessor<>), typeof(RequestPreProcessor<>));

builder.Services.AddScoped<IGetBookQueryHandler, GetBookQueryHandler>();
builder.Services.AddScoped<IMakeBookCommandHandler, MakeBookCommandHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
