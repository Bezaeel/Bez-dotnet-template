using System;
using System.IO;
using BezTemp.Data;
using BezTemp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BezTemp.Test
{
    public class Setup
    {
        public readonly AppDbContext dbContext;
        private readonly IConfiguration _configuration;
        public Setup()
        {
            _configuration = InitConfiguration();
            var str = _configuration.GetConnectionString("Default");
            DbContextOptionsBuilder dbOptions = new DbContextOptionsBuilder()
            .UseNpgsql(str);

            dbContext = new AppDbContext(dbOptions.Options);
            SeedDB();
        }

        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@"Config/test.json", false, false)
                .Build();
                return config;
        }

        public void SeedDB(){
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            dbContext.Samples.AddRange(
                new Sample{
                    ConsumerAddress= "Lagos",
                    ConsumerFullname = "Talabi",
                    CreatedAt = DateTime.UtcNow,
                },
                new Sample{
                    ConsumerAddress= "London",
                    ConsumerFullname = "Tye",
                    CreatedAt = DateTime.UtcNow,
                }
            );
            dbContext.SaveChanges();
        }
    
    }
}