using FinalBankExampleCore.DataContext;
using FinalBankExampleCore.Repositories.BankAccountRepository;
using FinalBankExampleCore.Repositories.UserRepository;
using FinalBankExampleCore.UnitOfWork;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<SQLDataContext>(op =>
{
    op.UseSqlServer(builder.Configuration.GetConnectionString("SQLConnectionString"));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISqlUnitOfWork, SqlUnitOfWork>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IBankAccountRepository, BankAccountRepository>();
builder.Services.AddMediatR(typeof(SampleCQRSwithMediatREntrypoint).Assembly);


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
