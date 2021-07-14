using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Razor.Models;

namespace Razor.Data
{
    public class Semilla
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorContext>>()))
            {
                // Look for any Pelis.
                if (context.Peli.Any())
                {
                    return;   // DB has been seeded
                }

                context.Peli.AddRange(
                    new Peli
                    {
                        Titulo = "When Harry Met Sally",
                        FechaEstreno = DateTime.Parse("1989-2-12"),
                        Genero = "Romantic Comedy",
                        Precio = 7.99M
                    },

                    new Peli
                    {
                        Titulo = "Ghostbusters ",
                        FechaEstreno = DateTime.Parse("1984-3-13"),
                        Genero = "Comedy",
                        Precio = 8.99M
                    },

                    new Peli
                    {
                        Titulo = "Ghostbusters 2",
                        FechaEstreno = DateTime.Parse("1986-2-23"),
                        Genero = "Comedy",
                        Precio = 9.99M
                    },

                    new Peli
                    {
                        Titulo = "Rio Bravo",
                        FechaEstreno = DateTime.Parse("1959-4-15"),
                        Genero = "Western",
                        Precio = 3.99M
                    }
                );
                context.SaveChanges();

            }
        }
    }
}
