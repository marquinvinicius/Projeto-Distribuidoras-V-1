using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using ApiDistribuidora.Repositories.Interfaces;
using ApiDistribuidora.Services.Interfaces;
using AutoMapper;
using BackDistribuidora.Builder;
using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Services.Implementacoes
{
    public class VendaService : IVendaService
    {
        private readonly ILogger<VendaService> _logger;
        private readonly IMapper _mapper;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IVendaRepository _vendaRepository;
        private readonly IUnitOfWork _uof;
        private readonly IPrecoVendaRepository _precoVendaRepository;
        private readonly IItemVendaRepository _itemVendaRepository;
        private readonly IMovimentacaoEstoqueRepository _movEstoque;

        public VendaService(ILogger<VendaService> logger, IProdutoRepository produtoRepository, 
            IVendaRepository vendaRepository, IUnitOfWork uof, 
            IPrecoVendaRepository precoVendaRepository, IMovimentacaoEstoqueRepository movEstoque)
        {
            _logger = logger;
            _produtoRepository = produtoRepository;
            _vendaRepository = vendaRepository;
            _uof = uof;
            _precoVendaRepository = precoVendaRepository;
            _movEstoque = movEstoque;
        }

        public async Task<IEnumerable<VendaDTO>> ObterTodasVendasAsync()
        {
            _logger.LogInformation("Obtendo todas as vendas.");

            try
            {
                var vendas = await _vendaRepository.GetAllAsync();
                _logger.LogInformation("Total de vendas obtidas: {Count}", vendas.Count());
                return _mapper.Map<IEnumerable<VendaDTO>>(vendas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todas as vendas");
                throw;
            }
        }

        public async Task<VendaDTO?> ObterVendaPorIdAsync(int id)
        {
            _logger.LogInformation("Obtendo venda com ID: {Id}", id);
            try
            {
                var venda = await _vendaRepository.GetByIdAsync(v => v.Id == id);
                if (venda == null)
                {
                    _logger.LogWarning("Venda com ID: {Id} não encontrada", id);
                    return null;
                }
                return _mapper.Map<VendaDTO>(venda);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter a venda por id");
                throw;
            }
        }
        public Task<VendaDTO> CriarVendaAsync(VendaInputDTO vendaInputDTO)
        {
            _logger.LogInformation("Criando uma nova venda.");
            try
            {
                if (vendaInputDTO == null || vendaInputDTO.Itens == null || !vendaInputDTO.Itens.Any())
                {
                    _logger.LogWarning("Dados inválidos para criação de venda.");
                    throw new ArgumentException("Dados inválidos para criação de venda.");
                }

                var movimentacao = new List<MovimentacaoEstoque>();
                var venda = new VendaBuilder().ComDataVenda(DateTime.Now);

                return null;


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar a venda");
                throw;
            }

        }
        public Task<VendaDTO?> AtualizarVendaAsync(int id, VendaInputDTO vendaInputDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CancelarVendaAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeletarVendaAsync(int id)
        {
            throw new NotImplementedException();
        }


    }
}
