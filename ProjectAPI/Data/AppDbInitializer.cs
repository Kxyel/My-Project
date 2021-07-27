using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ProjectAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var servicesScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicesScope.ServiceProvider.GetService<AppDbContext>();

                if(!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "Grandes Contos",
                        Description = "Compilado de contos de terror",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 10,
                        Genre = "Terror",
                        DateAdded = DateTime.Now
                    },
                    new Book()
                    {
                        Title = "Grandes Contos Vol.2",
                        Description = "Compilado de contos de terror",
                        IsRead = false,
                        Genre = "Terror",
                        DateAdded = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
