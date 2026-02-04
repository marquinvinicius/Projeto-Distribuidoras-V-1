using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using ApiDistribuidora.Services.Interfaces;
using BackDistribuidora.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDistribuidora.Controllers
{
    [Route("api/marcas")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly ILogger<MarcaController> _logger;
        private readonly IMarcaService _marcaService;
        public MarcaController(ILogger<MarcaController> logger, IMarcaService marcaService)
        {
            _logger = logger;
            _marcaService = marcaService;
        }

        #region Gets

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<MarcaDTO>>> GetAllMarcas()
        {
            try
            {
                var marcas = await _marcaService.ObterTodasMarcasAsync();
                if (marcas == null || !marcas.Any())
                {
                    _logger.LogInformation("Nenhuma marca encontrada.");
                    return NotFound("Nenhuma marca encontrada.");
                }
                _logger.LogInformation("Marcas obtidas com sucesso.");
                return Ok(marcas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todas as marcas");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }
        [HttpGet("{id:int}", Name = "ObterMarca")]
        [ProducesResponseType(typeof(Marca), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MarcaDTO>> GetMarcaById(int id)
        {
            try
            {
                var marca = await _marcaService.ObterMarcaPorIdAsync(id);
                if (marca == null)
                {
                    _logger.LogInformation($"Marca com ID {id} não encontrada.");
                    return NotFound($"Marca com ID {id} não encontrada.");
                }
                _logger.LogInformation($"Marca com ID {id} obtida com sucesso.");
                return Ok(marca);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter a marca por ID");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        [HttpGet("buscarNome")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<MarcaDTO>>> GetMarcasByName([FromQuery] string nome)
        {
            try
            {
                var marcas = await _marcaService.ObterMarcasPorNomeAsync(nome);
                if (marcas == null || !marcas.Any())
                {
                    _logger.LogInformation($"Nenhuma marca encontrada com o nome: {nome}.");
                    return NotFound($"Nenhuma marca encontrada com o nome: {nome}.");
                }
                _logger.LogInformation($"Marcas com o nome: {nome} obtidas com sucesso.");
                return Ok(marcas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar marcas por nome");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }
        #endregion

        #region Posts
        [HttpPost]
        [ProducesResponseType(typeof(Marca), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Marca>> CreateMarca([FromBody] MarcaInputDTO marca)
        {
            try
            {
                if (marca == null)
                {
                    _logger.LogInformation("Dados da marca inválidos.");
                    return BadRequest("Dados da marca inválidos.");
                }
                var novaMarca = await _marcaService.CriarMarcaAsync(marca);

                
                _logger.LogInformation("Marca criada com sucesso.");
                return CreatedAtRoute("ObterMarca", new { id = novaMarca.Id }, novaMarca);
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Erro de validação ao criar a marca");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar a marca");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }
        #endregion

        #region Puts
        [HttpPut("{id:int}")]
        [ProducesResponseType(typeof(Marca), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Marca>> UpdateMarca(int id, [FromBody] MarcaInputDTO marca)
        {
            try
            {
                if (marca == null)
                {
                    _logger.LogInformation("Dados da marca inválidos.");
                    return BadRequest("Dados da marca inválidos.");
                }
                var marcaAtualizada = await _marcaService.AtualizarMarcaAsync(id ,marca);
                if (marcaAtualizada == null)
                {
                    _logger.LogInformation($"Marca com ID {id} não encontrada para atualização.");
                    return NotFound($"Marca com ID {id} não encontrada para atualização.");
                }
                _logger.LogInformation($"Marca com ID {id} atualizada com sucesso.");
                return Ok(marcaAtualizada);
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Erro de validação ao atualizar a marca");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao atualizar a marca");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }
        #endregion

        #region Deletes

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteMarca(int id)
        {
            try
            {
                var sucesso =  await _marcaService.DeletarMarcaAsync(id);
                if (!sucesso)
                {
                    _logger.LogInformation($"Marca com ID {id} não encontrada para exclusão.");
                    return NotFound($"Marca com ID {id} não encontrada para exclusão.");
                }
                _logger.LogInformation($"Marca com ID {id} excluída com sucesso.");
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao excluir a marca");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        #endregion
    }

}
