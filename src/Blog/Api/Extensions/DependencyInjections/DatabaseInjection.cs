﻿using Blog.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Blog.Api.Extensions.DependencyInjections;

public static class DatabaseInjection
{
    public static IServiceCollection AddConfiguredDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DbConnection")));

        return services;
    }
}