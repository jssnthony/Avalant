using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var services = new ServiceCollection();

services.AddDbContext<GameDbContext>(options =>
    options.UseMySql(
        configuration.GetConnectionString("avalantdb"),
        ServerVersion.AutoDetect(configuration.GetConnectionString("avalantdb"))
    ));

var provider = services.BuildServiceProvider();