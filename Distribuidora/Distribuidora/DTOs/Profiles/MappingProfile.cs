using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using AutoMapper;
using BackDistribuidora.Entidades;

namespace ApiDistribuidora.DTOs.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Categoria
            CreateMap<Categoria, CategoriaDTO>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<CategoriaInputDTO, Categoria>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            #endregion

            #region ItemVenda

            CreateMap<ItemVenda, ItemVendaDTO>()
                .ForMember(dest => dest.ProdutoId, opt => opt.MapFrom(src => src.ProdutoId))
                .ForMember(dest => dest.ProdutoNome, opt => opt.Ignore())
                .ForMember(dest => dest.Quantidade, opt => opt.MapFrom(src => src.Quantidade))
                .ForMember(dest => dest.PrecoCusto, opt => opt.MapFrom(src => src.PrecoCusto))
                .ForMember(dest => dest.PrecoVenda, opt => opt.MapFrom(src => src.PrecoVenda))
                .ForMember(dest => dest.SubTotal, opt => opt.MapFrom(src => src.SubTotal));

            CreateMap<ItemVendaDTO, ItemVenda>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.ProdutoId, opt => opt.MapFrom(src => src.ProdutoId))
                .ForMember(dest => dest.Quantidade, opt => opt.MapFrom(src => src.Quantidade))
                .ForMember(dest => dest.PrecoVenda, opt => opt.MapFrom(src => src.PrecoVenda))
                .ForMember(dest => dest.PrecoCusto, opt => opt.MapFrom(src => src.PrecoCusto))
                .ForMember(dest => dest.VendaId, opt => opt.Ignore())
                .ForMember(dest => dest.Venda, opt => opt.Ignore());

            #endregion

            #region PrecoVenda
            CreateMap<PrecoVenda, PrecoVendaDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ProdutoId, opt => opt.MapFrom(src => src.ProdutoId))
                .ForMember(dest => dest.PrecoUnitario, opt => opt.MapFrom(src => src.PrecoUnitario))
                .ForMember(dest => dest.DataInicio, opt => opt.MapFrom(src => src.DataInicio))
                .ForMember(dest => dest.DataFim, opt => opt.MapFrom(src => src.DataFim));

            #endregion

            #region Marca

            CreateMap<Marca, MarcaDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<MarcaInputDTO, Marca>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            #endregion

            #region Produto

            CreateMap<Produto, ProdutoDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.NomeProduto.Valor))
                .ForMember(dest => dest.MarcaId, opt => opt.MapFrom(src => src.MarcaId))
                .ForMember(dest => dest.CategoriaId, opt => opt.MapFrom(src => src.CategoriaId))
                .ForMember(dest => dest.Preco, opt => opt.MapFrom(src => src.PrecoCusto.Valor))
                .ForMember(dest => dest.QuantidadeFardo, opt => opt.MapFrom(src => src.QuantidadeFardo.Valor));
            #endregion

            #region Venda

            CreateMap<Venda, VendaDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DataVenda, opt => opt.MapFrom(src => src.DataVenda))
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
                .ForMember(dest => dest.Itens, opt => opt.MapFrom(src => src.Itens));

            CreateMap<VendaInputDTO, Venda>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.DataVenda, opt => opt.MapFrom(src => src.DataVenda))
                .ForMember(dest => dest.Total, opt => opt.Ignore())
                .ForMember(dest => dest.Itens, opt => opt.MapFrom(src => src.Itens));

            #endregion
        }
    }
}
