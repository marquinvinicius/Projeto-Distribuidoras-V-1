using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using ApiDistribuidora.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDistribuidora.Controllers
{
    [Route("api/categorias")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ILogger<CategoriaController> _logger;
        private readonly ICategoriaService _categoriaService;
        public CategoriaController(ILogger<CategoriaController> logger, ICategoriaService categoriaService)
        {
            _logger = logger;
            _categoriaService = categoriaService;
        }
        #region Gets
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<CategoriaDTO>>> GetAllCategorias()
        {
            try
            {
                var categorias = await _categoriaService.ObterTodasCategoriasAsync();
                if (categorias == null || !categorias.Any())
                {
                    _logger.LogInformation("Nenhuma categoria encontrada.");
                    return NotFound("Nenhuma categoria encontrada.");
                }
                _logger.LogInformation("Categorias obtidas com sucesso.");
                return Ok(categorias);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todas as categorias");
                return StatusCode(500, "Ocorreu um erro ao processar a solicitação.");
            }
        }
        [HttpGet("{id:int}", Name = "ObterCategoria")]
        [ProducesResponseType(typeof(CategoriaDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CategoriaDTO>> GetCategoriaById(int id)
        {
            try
            {
                var categoria = await _categoriaService.ObterCategoriaPorIdAsync(id);
                if (categoria == null)
                {
                    _logger.LogInformation($"Categoria com ID {id} não encontrada.");
                    return NotFound($"Categoria com ID {id} não encontrada.");
                }
                _logger.LogInformation($"Categoria com ID {id} obtida com sucesso.");
                return Ok(categoria);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter a categoria por ID");
                return StatusCode(500, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        [HttpGet("buscar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<CategoriaDTO>>> GetCategoriasByName([FromQuery] string nome)
        {
            try
            {
                var categorias = await _categoriaService.ObterCategoriasPorNomeAsync(nome);
                if (categorias == null || !categorias.Any())
                {
                    _logger.LogInformation($"Nenhuma categoria encontrada com o nome: {nome}.");
                    return NotFound($"Nenhuma categoria encontrada com o nome: {nome}.");
                }
                _logger.LogInformation($"Categorias com o nome: {nome} obtidas com sucesso.");
                return Ok(categorias);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar categorias por nome");
                return StatusCode(500, "Ocorreu um erro ao processar a solicitação.");
            }
        }
        #endregion

        #region Posts

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CategoriaDTO>> CreateCategoria([FromBody] CategoriaInputDTO categoriaDTO)
        {
            try
            {
                var novaCategoria = await _categoriaService.CriarCategoriaAsync(categoriaDTO);
                _logger.LogInformation("Categoria criada com sucesso.");
                return CreatedAtRoute("ObterCategoria", new { id = novaCategoria.Id }, novaCategoria);
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Dados inválidos para criação de categoria");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar a categoria");
                return StatusCode(500, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        #endregion


        #region Puts

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CategoriaDTO>> UpdateCategoria(int id, [FromBody] CategoriaInputDTO categoriaDTO)
        {
            try
            {
                var categoriaAtualizada = await _categoriaService.AtualizarCategoriaAsync(id, categoriaDTO);
                if (categoriaAtualizada == null)
                {
                    _logger.LogInformation($"Categoria com ID {id} não encontrada para atualização.");
                    return NotFound($"Categoria com ID {id} não encontrada para atualização.");
                }
                _logger.LogInformation($"Categoria com ID {id} atualizada com sucesso.");
                return Ok(categoriaAtualizada);
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Dados inválidos para atualização de categoria");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao atualizar a categoria");
                return StatusCode(500, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        #endregion

        #region Deletes
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteCategoria(int id)
        {
            try
            {
                var categoriaExcluida = await _categoriaService.DeletarCategoriaAsync(id);
                if (!categoriaExcluida)
                {
                    _logger.LogInformation($"Categoria com ID {id} não encontrada para exclusão.");
                    return NotFound($"Categoria com ID {id} não encontrada para exclusão.");
                }
                _logger.LogInformation($"Categoria com ID {id} excluída com sucesso.");
                return Ok($"Categoria com ID {id} excluída com sucesso.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao excluir a categoria");
                return StatusCode(500, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        #endregion
    }
}