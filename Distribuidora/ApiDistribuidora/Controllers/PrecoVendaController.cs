using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using ApiDistribuidora.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDistribuidora.Controllers
{
    [Route("api/precovenda")]
    [ApiController]
    public class PrecoVendaController : ControllerBase
    {
        private readonly ILogger<PrecoVendaController> _logger;
        private readonly IPrecoVendaService _precoVendaService;

        public PrecoVendaController(ILogger<PrecoVendaController> logger, IPrecoVendaService precoVendaService)
        {
            _logger = logger;
            _precoVendaService = precoVendaService;
        }

        #region Gets
        [HttpGet("todos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult>GetTodosPrecos()
        {
            try
            {
                var precos = await _precoVendaService.ObterTodosPrecosAsync();
                if (precos == null)
                {
                    _logger.LogInformation("Nenhum preço encontrado");
                    return NotFound("Nenhum preço cadastrado");
                }
                _logger.LogInformation("Sucesso ao obter todos os preços");
                return Ok(precos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todos os preços");
                throw;
            }
        }

        [HttpGet("atual/{produtoId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PrecoVendaDTO>> ProdutoPrecoAtual(int produtoId)
        {
            try
            {
                var precoAtual = await _precoVendaService.ObterPrecoAtualAsync(produtoId);
                if (precoAtual == null)
                {
                    _logger.LogInformation($"Não há preço para o produto com o id {produtoId}");
                    return NotFound("preço inexistente");
                }
                _logger.LogInformation("Sucesso ao obter o preço atual");
                return Ok(precoAtual);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter o preço atual do produto");
                throw;
            }
        }


        [HttpGet("historicoproduto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<PrecoVendaDTO>>> GetHistoricoProduto(int produtoId)
        {
            try
            {
                var historico = await _precoVendaService.ObterHistoricoPrecosAsync(produtoId);
                if (historico == null)
                {
                    _logger.LogInformation("Produto não vai tem historico de preços");
                    return NotFound("Historico vazio");
                }
                return Ok(historico);
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro ao obter o historico do produto");
                throw;
            }
        }
        #endregion

        #region Posts e Delete
        [HttpPost("adcionar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PrecoVendaDTO>> AdcionarPrecoVendaAsync([FromBody] PrecoVendaInputDTO precoVendaDTO)
        {
            _logger.LogInformation($"Começandando a criação do preço para o produto {precoVendaDTO}");
            try
            {
                var preco = await _precoVendaService.AdicionarPrecoVendaAsync(precoVendaDTO.ProdutoId, precoVendaDTO.ValorVenda);
                if (preco == null)
                {
                    _logger.LogInformation("Erro ao criar o preço de venda");
                    return BadRequest("ERRo");
                }
                return Ok(preco);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar o preço de venda");
                throw;
            }
        }

        [HttpPost("margemgeral")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<PrecoVendaInputDTO>>> AdcionarMargemGeralAsync(decimal margemLucro)
        {
            _logger.LogInformation("Começando a adcionar a margem geral");
            try
            {
                var precoMargem = await _precoVendaService.AdcionarMargemGeralAsync(margemLucro);
                if (precoMargem == null)
                {
                    _logger.LogInformation("Erro ao adicionar os preços para os produtos");
                }
                _logger.LogInformation("Sucesso ao aplicar a margem geral");
                return Ok(precoMargem);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao adicionar a margem geral");
                throw;
            }
        }

        [HttpPost("margemcat")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<PrecoVendaDTO>>> AdicionarMargemCategoriaAsync(int categoriaId, decimal margem)
        {
            _logger.LogInformation("Começando a aplicar a margem de preço por categoria");
            try
            {
                var precoCat = await _precoVendaService.AdcionarMargemCategoriaAsync(categoriaId, margem);
                if (precoCat == null)
                {
                    _logger.LogInformation("Não foi possivel aplicar a margem pela categoria");
                    return BadRequest();
                }
                _logger.LogInformation("Sucesso ao aplicar a margem por categoria");
                return Ok(precoCat);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao aplicar a margem para a categoria");
                throw;
            }
        }

        [HttpPost("margemunico")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PrecoVendaDTO>>AdicionarPrecoUnicoMargem(int produtoId, decimal margemLucro)
        {
            _logger.LogInformation("Começando a aplicar preço unico por margem");
            try
            {
                var preco = await _precoVendaService.AdcionarPrecoUnicoPorMargemAsync(produtoId, margemLucro);
                if (preco == null)
                {
                    _logger.LogError("Erro ao aplicar a margem no preço");
                    return BadRequest();
                }
                _logger.LogInformation("Sucesso ao aplicar o preço por margem");
                return Ok(preco);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao aplicar o preço por margem");
                throw;
            }
        }

        [HttpPost("margemarca")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<PrecoVendaDTO>>> AdcionarPrecoMarcaAsync(int marcaId, decimal margem)
        {
            _logger.LogInformation("Começando a aplicar a margem por marca");
            try
            {
                var marcaP = await _precoVendaService.AdicionarMargemMarcaAsync(marcaId, margem);
                if (marcaP == null)
                {
                    _logger.LogInformation("Erro ao aplicar a margem por marca");
                    return BadRequest();
                }
                _logger.LogInformation("Sucesso ao aplicar a margem por marca");
                return Ok(marcaP);
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro inesperado ao aplicar a margem por marca");
                throw;
            }
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PrecoVendaDTO>> EncerrarPrecoAsync([FromBody] PrecoVendaDTO precoVendaDTO)
        {
            _logger.LogInformation("Começando o encerramento de preço");
            try
            {
                var encerrado = _precoVendaService.EncerrarPrecoAtualAsync(precoVendaDTO.Id);
                if (encerrado == null)
                {
                    _logger.LogInformation("Erro ao encerrar o preço");
                    return BadRequest();
                }
                return Ok(encerrado);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao encerrar o preço");
                throw;
            }
        }
        #endregion

    }
}
