using HA.UsuarioApi.Domain.Models;
using System.Threading.Tasks;

namespace HA.UsuarioApi.Domain.Interfaces
{
    public interface IInfraDataDapper
    {
        Task<AuthenticationGetResult> GetDadosUsuarioAsync(AuthenticationGet authenticationGet);
    }
}
