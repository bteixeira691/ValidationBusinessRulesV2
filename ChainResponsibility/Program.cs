using ChainResponsibility.Chain;
using ChainResponsibility.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var requestNull = new RequestNullHandler();
var validationName = new ValidationNameHandler();
var validationIdHandler = new ValidationIdHandler();
var validationLastnameHandler = new ValidationLastnameHandler();

requestNull
    .SetNext(validationName)
    .SetNext(validationIdHandler)
    .SetNext(validationLastnameHandler);

builder.Services.AddSingleton<IHandler>(requestNull);





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
