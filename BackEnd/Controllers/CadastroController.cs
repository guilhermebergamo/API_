using BachEnd.Services;
using BachEnd.Services.Cadastros;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BackEnd.API.Controllers
{
    [ApiController, Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private readonly ILogger<CadastroController> _logger;
        private readonly ICadastroProduto _cadastroProduto;
   
        public CadastroController(ILogger<CadastroController> logger, ICadastroProduto cadastroProduto)
        {
            _logger = logger;
            _cadastroProduto = cadastroProduto;
        }

        [HttpPost, Produces("application/json")]
        public async Task<ActionResult> Inserir([FromBody] CadastroProdutoViewModel viewModel)
        {
            try
            {
                var _result = await _cadastroProduto.CadastroProduto(viewModel);
                return _result > 0 ? Created("", _result) : UnprocessableEntity();               
            }
            catch (Exception e)
            {
                _logger.LogError(e, "POST - api/Cadastro erro.");
                return Problem(statusCode: 500, detail: e.Message);
                
            }
           
        }

    }
}
