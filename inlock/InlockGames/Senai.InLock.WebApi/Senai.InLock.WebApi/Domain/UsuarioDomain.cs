using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domain
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Informe o e-mail do usuário")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do Usuario")]
        [DataType(DataType.Password)]
        [StringLength(25, MinimumLength = 6, ErrorMessage = "A senha deve conter no minimo 6 e no maximo 25")]
        public string Senha { get; set; }

        public int IdTipoUsuario { get; set; }

        public TipoUsuarioDomain TipoUsuario { get; set; }
        

    }
}
