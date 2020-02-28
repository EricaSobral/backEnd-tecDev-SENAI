using senai.projetoPeople.token.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.projetoPeople.token.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuarioDomain> Listar();

        void CadastrarTipoUsuario(TipoUsuarioDomain TipoUsuario);

        void AtualizarTipoUsuarioCad(TipoUsuarioDomain TipoUsuario);

        void DeletarTipoUsuario(int id);

        void AtualizarIdTipoUrl(int id, TipoUsuarioDomain TipoUsuario);

        TipoUsuarioDomain BuscarIdTipoU(int id);
    }
}
