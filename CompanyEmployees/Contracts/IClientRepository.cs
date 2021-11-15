using Entities.Models;
using System.Collections.Generic;

namespace Contracts
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAllClients(bool trackChanges);
    }
}
