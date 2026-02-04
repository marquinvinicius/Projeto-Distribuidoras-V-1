using ApiDistribuidora.DTOs.Filters;
using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.Services.Interfaces;
using BackDistribuidora.Entidades;
using BackDistribuidora.Entidades.Enums;
using Distribuidora.Back.Entidades.Object_Values;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDistribuidora.Controllers
{
    [Route("api/movimentacaoestoque")]
    [ApiController]
    public class MovimentacaoEstoqueController : ControllerBase
    {
        private readonly IMovimentacaoEstoqueService _movEstoque;
        private readonly ILogger<MovimentacaoEstoqueController> _logger;
        public MovimentacaoEstoqueController(IMovimentacaoEstoqueService movEstoque,
            ILogger<MovimentacaoEstoqueController> logger)
        {
            _movEstoque = movEstoque;
            _logger = logger;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> ProcessarMovimentacao([FromBody] MovimentacaoEstoqueInputDTO movimentacao)
        {
            try
            {
                await _movEstoque.ProcessarMovimentacao(movimentacao.ProdutoId,
                    new EstoqueProdutoValue(movimentacao.Quantidade),
                    new CustoProdutoValue(movimentacao.PrecoUnitario),
                    movimentacao.TipoTransacao,
                    movimentacao.TipoUnidade);

                _logger.LogInformation("Movimentação de estoque processada com sucesso para o produto ID: {ProdutoId}", movimentacao.ProdutoId);
                return Ok("Movimentação de estoque processada com sucesso.");
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Erro de validação ao processar a movimentação de estoque");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao processar a movimentação de estoque");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAllMovimentacoes()
        {
            try
            {
                var movimentacoes = await _movEstoque.ObterTodasMovimentacoesAsync();
                if (movimentacoes == null || !movimentacoes.Any())
                {
                    _logger.LogInformation("Nenhuma movimentação de estoque encontrada.");
                    return NotFound("Nenhuma movimentação de estoque encontrada.");
                }
                _logger.LogInformation("Movimentações de estoque obtidas com sucesso.");
                return Ok(movimentacoes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todas as movimentações de estoque");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        [HttpGet("{id:int}", Name = "BuscarMovimento")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetMovimentacaoById(int id)
        {
            try
            {
                var movimentacao = await _movEstoque.ObterMovimentacaoPorIdAsync(id);
                if (movimentacao == null)
                {
                    _logger.LogInformation($"Movimentação de estoque com ID {id} não encontrada.");
                    return NotFound($"Movimentação de estoque com ID {id} não encontrada.");
                }
                _logger.LogInformation($"Movimentação de estoque com ID {id} obtida com sucesso.");
                return Ok(movimentacao);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter a movimentação de estoque por ID");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }



        [HttpGet("produto/{produtoId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetMovimentacoesByProdutoId(int produtoId)
        {
            try
            {
                var produtoIdExists = await _movEstoque.ObterMovimentacoesPorProdutoAsync(produtoId);
                if (produtoIdExists == null)
                {
                    _logger.LogInformation($"Produto com ID {produtoId} não encontrado.");
                    return NotFound($"Produto com ID {produtoId} não encontrado.");
                }
                var movimentacoes = await _movEstoque.ObterMovimentacoesPorProdutoAsync(produtoId);
                if (movimentacoes == null || !movimentacoes.Any())
                {
                    _logger.LogInformation($"Nenhuma movimentação de estoque encontrada para o produto ID {produtoId}.");
                    return NotFound($"Nenhuma movimentação de estoque encontrada para o produto ID {produtoId}.");
                }
                _logger.LogInformation($"Movimentações de estoque para o produto ID {produtoId} obtidas com sucesso.");
                return Ok(movimentacoes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter as movimentações de estoque por ID do produto");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }

        [HttpPost("filtrar")] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> FiltrarMovimentacoes([FromBody] DTOs.Filters.MovimentacaoFilterInput filtro)
        {
            try
            {
                var movimentacoes = await _movEstoque.ObterMovimentacoesPorFiltroAsync(filtro);

                if (movimentacoes == null || !movimentacoes.Any())
                {
                    return NotFound("Nenhuma movimentação encontrada com os filtros fornecidos.");
                }

                _logger.LogInformation("Movimentações de estoque obtidas com sucesso pelo filtro.");
                return Ok(movimentacoes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter as movimentações de estoque pelo filtro");
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao processar a solicitação.");
            }
        }
    }
}
