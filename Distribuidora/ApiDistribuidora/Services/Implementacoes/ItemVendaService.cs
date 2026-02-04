using ApiDistribuidora.DTOs.Response;
using ApiDistribuidora.Repositories.Interfaces;
using ApiDistribuidora.Services.Interfaces;
using AutoMapper;
using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Services.Implementacoes
{
    public class ItemVendaService : IItemVendaService
    {
        private readonly ILogger<ItemVendaService> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uof;
        private readonly IItemVendaRepository _itemVendaRepository;
        private readonly IProdutoService _produtoService;
        private readonly IPrecoVendaService _precoVendaService;

        public async Task<IEnumerable<ItemVendaDTO>> ObterTodosItensVendaAsync()
        {
            _logger.LogInformation("Obtendo todos os itens de venda.");
            try
            {
                var itensVenda = await _itemVendaRepository.GetAllAsync();
                if (itensVenda == null || !itensVenda.Any())
                {
                    _logger.LogWarning("Nenhum item de venda encontrado.");
                    return Enumerable.Empty<ItemVendaDTO>();
                }
                var itensVendaDto = _mapper.Map<IEnumerable<ItemVendaDTO>>(itensVenda);

                _logger.LogInformation("Itens de venda obtidos com sucesso.");
                return itensVendaDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todos os itens de venda");
                throw;
            }
        }

        public async Task<ItemVendaDTO?> ObterItemVendaPorIdAsync(int id)
        {
            _logger.LogInformation("Obtendo item de venda com ID: {Id}", id);
            try
            {
                var item = await _itemVendaRepository.GetByIdAsync(iv => iv.Id == id);
                if (item == null)
                {
                    _logger.LogWarning("Item de venda com ID: {Id} não encontrado.", id);
                    return null;
                }
                var itemDto = _mapper.Map<ItemVendaDTO>(item);
                _logger.LogInformation("Item de venda com ID: {Id} obtido com sucesso.", id);
                return itemDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter  o item por id");
                throw;
            }
        }


        public async Task<ItemVendaDTO> CriarItemVendaAsync(ItemVendaDTO itemVenda)
        {
            _logger.LogInformation("Criando um novo item de venda.");
            try
            {
                var produto = await _produtoService.ObterProdutoPorIdAsync(itemVenda.ProdutoId);
                if (produto == null)
                {
                    _logger.LogWarning("Produto com ID: {ProdutoId} não encontrado.", itemVenda.ProdutoId);
                    throw new Exception("Produto não encontrado");
                }

                var precoVenda = await _precoVendaService.ObterPrecoAtualAsync(itemVenda.ProdutoId);

                if (precoVenda == null)
                {
                    _logger.LogWarning("Preço de venda para o Produto ID: {ProdutoId} não encontrado.", itemVenda.ProdutoId);
                    throw new Exception("Preço de venda não encontrado");
                }
                var novoItemVenda = new ItemVendaDTO();
                novoItemVenda.ProdutoId = itemVenda.ProdutoId;
                novoItemVenda.Quantidade = itemVenda.Quantidade;
                novoItemVenda.PrecoCusto = produto.Preco;
                novoItemVenda.PrecoVenda = precoVenda.PrecoUnitario;

                var itemVendaEntity = _mapper.Map<ItemVenda>(novoItemVenda);

                await _itemVendaRepository.AddAsync(itemVendaEntity);
                await _uof.CommitAsync();
                _logger.LogInformation("Item de venda criado com sucesso.");

                return _mapper.Map<ItemVendaDTO>(itemVendaEntity);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar o item venda");
                throw;
            }
        }

        public async Task<ItemVendaDTO?> AtualizarItemVendaAsync(int id, ItemVenda itemVenda)
        {
            _logger.LogInformation($"Começando a atualziar o item com o id {id}");

            try
            {
                var itemExiste = await _itemVendaRepository.GetByIdAsync(it => it.Id == id);
                if (itemExiste == null)
                {
                    _logger.LogWarning($"ItemVenda com ID {id} não encontrado.");
                    throw new ArgumentException($"ItemVenda com id {id} não encontrado.");
                }
                itemExiste.AtualizarQuantidade(itemVenda.Quantidade);

                await _itemVendaRepository.UpdateAsync(itemVenda);
                await _uof.CommitAsync();

                _logger.LogInformation($"ItemVenda atualizado com sucesso: {itemExiste.Id}");

                return _mapper.Map<ItemVendaDTO>(itemExiste);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao atualizar o item venda");
                throw;
            }
        }

        public async Task<bool> DeletarItemVendaAsync(int id)
        {
            _logger.LogInformation($"DeletarItemVenda com id = {id}");
            try
            {
                var itemExiste = await _itemVendaRepository.GetByIdAsync(it => it.Id == id);
                if (itemExiste == null)
                {
                    _logger.LogWarning($"ItemVenda com ID {id} não encontrado.");
                    throw new ArgumentException($"ItemVenda com id {id} não encontrado.");
                }

                await _itemVendaRepository.DeleteAsync(itemExiste);
                await _uof.CommitAsync();

                _logger.LogInformation($"Item {id} foi excluido");

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao deletar o item venda");
                throw;
            }
        }

    }
}
