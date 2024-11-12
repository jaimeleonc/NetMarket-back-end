using Core.Entities;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Extensions
{
    public static class UserManagerExtensions
    {
        public static async Task<Usuario> BuscarUsuarioCondireccionAsync(this UserManager<Usuario> input, ClaimsPrincipal usr)
        {
            var email = usr?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;

            var usuario =  await input.Users.Include(x => x.Direccion).SingleOrDefaultAsync(x => x.Email == email);
            return usuario;
        }

        public static async Task<Usuario> BuscarUsuarioAsync(this UserManager<Usuario> input, ClaimsPrincipal usr)
        {
            var email = usr?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;

            var usuario = await input.Users.SingleOrDefaultAsync(x => x.Email == email);
            return usuario;
        }

    }
}
