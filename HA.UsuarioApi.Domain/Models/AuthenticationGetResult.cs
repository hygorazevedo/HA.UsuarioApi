using System;

namespace HA.UsuarioApi.Domain.Models
{
    public class AuthenticationGetResult
    {
        public bool Authenticated { get; set; }
        public AuthenticationGetResultInnerUsuario Usuario { get; set; }
        
        public class AuthenticationGetResultInnerUsuario
        {
            public Guid? Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
