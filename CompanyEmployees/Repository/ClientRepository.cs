using Contracts;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class ClientRepository : RepositoryBase<ExternalClientContext, Client>, IClientRepository
    {
        public ClientRepository(ExternalClientContext clientContext)
            :base(clientContext)
        {
        }

        public IEnumerable<Client> GetAllClients(bool trackChanges) => 
            FindAll(trackChanges)
            .ToList();
    }
}
