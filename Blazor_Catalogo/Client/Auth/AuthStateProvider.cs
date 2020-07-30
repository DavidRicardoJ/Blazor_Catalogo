using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace Blazor_Catalogo.Client.Auth
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //await Task.Delay(4000);
            //indicamos se o usuário está autenticado e os seus claims
            var usuario = new ClaimsIdentity(new List<Claim>() {
                new Claim("Chave", "Valor"), 
                new Claim(ClaimTypes.Name,"Ricardo"),
                new Claim(ClaimTypes.Role,"Admin")
            }, "demo");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(usuario)));
        }
    }
}
