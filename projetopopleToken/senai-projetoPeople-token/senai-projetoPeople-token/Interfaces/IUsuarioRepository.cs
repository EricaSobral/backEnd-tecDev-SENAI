using senai.projetoPeople.token.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.projetoPeople.token.Interfaces
{
    interface IUsuarioRepository
    {
        List<UsuarioDomain> Listar();

        void CadastrarUsuario(UsuarioDomain Usuario);

        void AtualizarUsuarioCad(UsuarioDomain Usuario);

        void DeletarUsuario(int id);

        void AtualizarIdUrl(int id, UsuarioDomain Usuario);

        UsuarioDomain BuscarId(int id);
    }
}
