using Users.Application;
using Users.Domain.Repositories;
using Users.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// My services
builder.Services.AddTransient<UserCreator>();
builder.Services.AddTransient<UsersSearcher>();
builder.Services.AddTransient<IUsersRepository, InMemoryUsersRepository>();

// TODO: add global error handler.
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
