using senai.projetoPeople.token.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.projetoPeople.token.Interfaces
{
    interface IFuncionarioRepository
    {
        List<FuncionarioDomain> Listar();

        void CadastrarFuncionario(FuncionarioDomain funcionario);

        void AtualizarFuncionarioCad(FuncionarioDomain funcionario);

        void DeletarFuncionario(int id);

        void AtualizarIdUrl(int id, FuncionarioDomain funcionario);

        FuncionarioDomain BuscarId(int id);
    }
}
