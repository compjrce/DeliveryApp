using DeliveryApp.Domain.Repositories;
using DeliveryApp.Infrastructure.Persistence;
using DeliveryApp.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DeliveryApp.Infrastructure;

public static class InfrastructureModule
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services
            .AddMongo()
            .AddRepositories();

        return services;
    }

    public static IServiceCollection AddMongo(this IServiceCollection services)
    {
        services.AddSingleton<MongoDbOptions>(x =>
        {
            var configuration = x.GetService<IConfiguration>();
            var options = new MongoDbOptions();

            configuration.GetSection("Mongo").Bind(options);

            return options;
        });

        services.AddSingleton<IMongoClient>(x =>
        {
            var options = x.GetService<MongoDbOptions>();

            return new MongoClient(options.ConnectionString);
        });

        services.AddTransient(x =>
        {
            BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;

            var options = x.GetService<MongoDbOptions>();
            var mongoClient = x.GetService<IMongoClient>();

            var db = mongoClient.GetDatabase(options.DataBase);

            return db;
        });

        return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IMotoServiceRepository, MotoServiceRepository>();
        services.AddScoped<IDeliveryDriverServiceRepository, DeliveryDriverServiceRepository>();

        return services;
    }
}