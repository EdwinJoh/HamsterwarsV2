using AutoMapper;
using Contacts;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IHamsterService> _hamsterService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
        logger,IMapper mapper)
        {
            _hamsterService = new Lazy<IHamsterService>(() =>
               new HamsterService(repositoryManager, logger,mapper));

        }
        public IHamsterService Hamster => _hamsterService.Value;
    }
}
