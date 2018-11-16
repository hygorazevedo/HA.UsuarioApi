using System;
using System.Threading.Tasks;
using HA.UsuarioApi.Domain.Interfaces;
using HA.UsuarioApi.Domain.Models;

namespace HA.UsuarioApi.Infra.Data.Dapper
{
    public class InfraDataDapper : IInfraDataDapper
    {
        public async Task<AuthenticationGetResult> GetDadosUsuarioAsync(AuthenticationGet authenticationGet)
        {
            var response = null as AuthenticationGetResult;

            if (authenticationGet.Login.Equals("hygor.azevedo") && authenticationGet.Password.Equals("testeapi"))
            {
                response = new AuthenticationGetResult()
                {
                    Authenticated = true,
                    Usuario = new AuthenticationGetResult.AuthenticationGetResultInnerUsuario
                    {
                        Id = Guid.NewGuid(),
                        Nome = "hygor de lima azevedo"
                    }
                };
            }
                
            else
                response = new AuthenticationGetResult();

            await Task.Delay(1000);

            return response;
        }
    }
}
