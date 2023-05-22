using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}