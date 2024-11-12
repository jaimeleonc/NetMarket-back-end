using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Data
{
    public class SeguridadDbContextData
    {
        public static async Task SeedUserAsync(UserManager<Usuario> userManager)
        {
            if (!userManager.Users.Any())
            {
                var usuario = new Usuario
                {
                    Nombre = "Jaime",
                    Apellido = "Leon",
                    UserName = "jaime",
                    Email = "jaime.leon@google.com",
                    Direccion = new Direccion
                    {
                        Calle = "Cuarta calle pte",
                        Ciudad = "Tonacatepeque",
                        CodigoPostal = "123",
                        Departamento = "San Salvador"
                    }
                };

                await userManager.CreateAsync(usuario, "JleonC2024$");

            }
        }
    }
}
