using ExemploDDD.Domain.Core.Interfaces.Repositorys;
using ExemploDDD.Domain.Core.Interfaces.Services;
using ExemploDDD.Domain.Entitys;

namespace ExemploDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente)
            : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}