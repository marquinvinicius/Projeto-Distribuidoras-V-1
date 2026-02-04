using ApiDistribuidora.Services.Interfaces;
using BackDistribuidora.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDistribuidora.Controllers
{
    [Route("api/marcacategoria")]
    [ApiController]
    public class MarcaCategoriaController : ControllerBase
    {
        private readonly ILogger<MarcaCategoriaController> _logger;
        private readonly IMarcaCategoriaService _marcaCategoriaService;
        public MarcaCategoriaController(ILogger<MarcaCategoriaController> logger,
            IMarcaCategoriaService marcaCategoriaService)
        {
            _logger = logger;
            _marcaCategoriaService = marcaCategoriaService;
        }

        [HttpGet("categoriaPorMarca/{marcaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetCategoriasPorMarca(int marcaId)
        {
            try
            {
                var categorias = await _marcaCategoriaService.ObterCategoriaPorMarcaAsync(marcaId);
                if (categorias == null || !categorias.Any())
                {
                    _logger.LogInformation("Nenhuma categoria encontrada para a marca ID: {MarcaId}", marcaId);
                    return NotFound("Nenhuma categoria encontrada para a marca especificada.");
                }
                _logger.LogInformation("Categorias obtidas com sucesso para a marca ID: {MarcaId}", marcaId);
                return Ok(categorias);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter categorias para a marca ID: {MarcaId}", marcaId);
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }

        }
        [HttpPost("vincular/{marcaId:int}/{categoriaId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> VincularMarcaCategoria(int marcaId, int categoriaId)
        {
            try
            {
                await _marcaCategoriaService.VincularMarcaCategoriaAsync(marcaId, categoriaId);
                _logger.LogInformation("Marca e categoria vinculadas com sucesso.");
                return Ok("Marca e categoria vinculadas com sucesso.");
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Erro de validação ao vincular marca e categoria.");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao vincular marca e categoria.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }
        [HttpDelete("desvincular/{marcaId:int}/{categogiaId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DesvincularMarcaCategoria(int marcaId, int categoriaId)
        {
            try
            {
                await _marcaCategoriaService.DesvincularMarcaCategoriaAsync(marcaId, categoriaId);
                _logger.LogInformation("Marca e categoria desvinculadas com sucesso.");
                return Ok("Marca e categoria desvinculadas com sucesso.");
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Erro de validação ao desvincular marca e categoria.");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao desvincular marca e categoria.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }
    }
}
