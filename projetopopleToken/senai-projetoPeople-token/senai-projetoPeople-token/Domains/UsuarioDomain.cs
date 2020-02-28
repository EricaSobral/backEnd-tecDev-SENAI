using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.projetoPeople.token.Domains
{
    public class UsuarioDomain
{
        public int id_usuario { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public int fk_tipo_Usuario { get; set; }

        public TipoUsuarioDomain TipoUsuario { get; set; }

    }
}
