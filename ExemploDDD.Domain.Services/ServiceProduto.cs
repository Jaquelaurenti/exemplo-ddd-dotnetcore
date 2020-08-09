using ExemploDDD.Domain.Core.Interfaces.Repositorys;
using ExemploDDD.Domain.Core.Interfaces.Services;
using ExemploDDD.Domain.Entitys;

namespace ExemploDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
            : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}