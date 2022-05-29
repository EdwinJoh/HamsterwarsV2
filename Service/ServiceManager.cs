using AutoMapper;
using Contacts;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
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
        private readonly Lazy<IMatchService> _matchService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
        logger, IMapper mapper, UserManager<User> userManager, IConfiguration configuration)
        {
            _hamsterService = new Lazy<IHamsterService>(() =>
               new HamsterService(repositoryManager, logger, mapper));
            _matchService = new Lazy<IMatchService>(() =>
               new MatchSevice(repositoryManager, logger, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() =>
                new AuthenticationService(logger, mapper, userManager, configuration));

        }
        public IHamsterService Hamster => _hamsterService.Value;
        public IMatchService Matches => _matchService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;



    }
}
