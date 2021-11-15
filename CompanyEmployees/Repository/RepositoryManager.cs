using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private ExternalClientContext _externalClientContext;

        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;

        private IClientRepository _clientRepository;

        public RepositoryManager(RepositoryContext repositoryContext, ExternalClientContext externalClientContext)
        {
            _repositoryContext = repositoryContext;
            _externalClientContext = externalClientContext;
        }

        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository is null)
                    _companyRepository = new CompanyRepository(_repositoryContext);

                return _companyRepository;
            }
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository is null)
                    _employeeRepository = new EmployeeRepository(_repositoryContext);

                return _employeeRepository;
            }
        }

        public IClientRepository Client
        {
            get
            {
                if (_clientRepository is null)
                    _clientRepository = new ClientRepository(_externalClientContext);

                return _clientRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}