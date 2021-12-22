using BachEnd.Services;
using BachEnd.Services.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Services
{
    public class CadastroService : ICadastroProduto
    {       

        public Task<long> CadastroProduto(CadastroProdutoViewModel vielModel)
        {

            if (!string.IsNullOrEmpty(vielModel.Nome) || !string.IsNullOrEmpty(vielModel.Descricao) || !double.IsNaN(vielModel.Valor))
            {
                throw new Exception("error");
            }
         

            throw new NotImplementedException();
        }
    }
}
