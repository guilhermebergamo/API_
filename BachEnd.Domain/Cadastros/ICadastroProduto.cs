using BachEnd.Services.Cadastros;
using BackEnd.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BachEnd.Services;

namespace BachEnd.Services
{
    public interface ICadastroProduto
    {
        Task<long> CadastroProduto (CadastroProdutoViewModel vielModel);
    }
}
