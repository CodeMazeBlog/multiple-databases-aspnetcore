using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class EmployeeRepository : RepositoryBase<RepositoryContext, Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
    }
}
