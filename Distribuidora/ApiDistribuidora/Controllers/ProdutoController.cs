using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using ApiDistribuidora.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDistribuidora.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly IProdutoService _produtoService;
        public ProdutoController(ILogger<ProdutoController> logger, IProdutoService produtoService)
        {
            _logger = logger;
            _produtoService = produtoService;
        }
        #region Gets
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> GetAllProdutos()
        {
            try
            {
                var produtos = await _produtoService.ObterTodosProdutosAsync();
                if (produtos == null || !produtos.Any())
                {
                    _logger.LogInformation("Nenhum produto encontrado.");
                    return NotFound("Nenhum produto encontrado.");
                }
                _logger.LogInformation("Produtos obtidos com sucesso.");
                return Ok(produtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todos os produtos");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        [HttpGet("{id:int}", Name = "BuscarProduto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ProdutoDTO>> GetProdutoById(int id)
        {
            try
            {
                var produto = await _produtoService.ObterProdutoPorIdAsync(id);
                if (produto == null)
                {
                    _logger.LogInformation($"Produto com ID {id} não encontrado.");
                    return NotFound($"Produto com ID {id} não encontrado.");
                }
                _logger.LogInformation($"Produto com ID {id} obtido com sucesso.");
                return Ok(produto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter o produto por ID");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        [HttpGet("BuscarNome/{nome}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> GetProdutoByName(string nome)
        {
            try
            {
                var produtos = await _produtoService.BuscarProdutoPorNomeAsync(nome);
                if (produtos == null || !produtos.Any())
                {
                    _logger.LogInformation($"Nenhum produto encontrado com o nome {nome}.");
                    return NotFound($"Nenhum produto encontrado com o nome {nome}.");
                }
                _logger.LogInformation($"Produtos com o nome {nome} obtidos com sucesso.");
                return Ok(produtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar o produto por nome");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        [HttpGet("BuscarMarca/{marcaId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> GetMarcaAsync(int marcaId)
        {
            _logger.LogInformation("Iniciando a busca por marca");
            try
            {
                var produtos = await _produtoService.BuscarProdutoPorMarcaAsync(marcaId);
                if (produtos == null || !produtos.Any())
                {
                    _logger.LogInformation("Lista de produtos vazia");
                    return NotFound();
                }
                return Ok(produtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar por marca");
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro no servidor");
            }
        }

        [HttpGet("BuscarCategoria/{categoriaId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> GetCategoria(int categoriaId)
        {
            _logger.LogInformation("Iniciando a busca por categoria");
            {
                try
                {
                    var produtos = await _produtoService.BuscarProdutoPorCategoriaAsync(categoriaId);

                    if (produtos == null || !produtos.Any())
                    {
                        _logger.LogInformation("Lista de produtos vazia");
                        return NotFound();
                    }
                    return Ok(produtos);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Erro ao obter os produtos por categoria");
                    throw;
                }
            }
        }


        #endregion

        #region Posts

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ProdutoDTO>> CreateProduto([FromBody] ProdutoInputDTO produtoInputDTO)
        {
            try
            {
                var produtoDTO = await _produtoService.CriarProdutoAsync(produtoInputDTO);
                _logger.LogInformation("Produto criado com sucesso.");
                return CreatedAtRoute("BuscarProduto", new { id = produtoDTO.Id }, produtoDTO);
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Erro de validação ao criar o produto");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar o produto");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }


        [HttpPost("addLista")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateProdutosList([FromBody] List<ProdutoInputDTO> produtosInputDTO)
        {
            try
            {
                var produtosDTO = await _produtoService.CriarListaProdutosAsync(produtosInputDTO);
                _logger.LogInformation("Lista de produtos criada com sucesso.");
                return CreatedAtAction(nameof(GetAllProdutos), produtosDTO);
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Erro de validação ao criar a lista de produtos");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar a lista de produtos");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }
        #endregion

        #region Put

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateProduto(int id, [FromBody] ProdutoInputDTO produtoInputDTO)
        {
            try
            {
                await _produtoService.AtualizarProdutoAsync(id, produtoInputDTO);
                _logger.LogInformation($"Produto com ID {id} atualizado com sucesso.");
                return NoContent();
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Erro de validação ao atualizar o produto");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao atualizar o produto");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }
        #endregion

        #region Delete

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            try
            {
                await _produtoService.DeletarProdutoAsync(id);
                _logger.LogInformation($"Produto com ID {id} deletado com sucesso.");
                return NoContent();
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Erro de validação ao deletar o produto");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao deletar o produto");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }


        #endregion
    }
}
