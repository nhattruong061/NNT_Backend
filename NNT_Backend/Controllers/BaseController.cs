using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NNT_Backend.Helpers;
using NNT_Backend.Helpers.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using log4net.Core;

namespace NNT_Backend.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        public static IMapper _mapper;
        public readonly AppSettings _appSettings;
        public ILoggerManager _logger;

        public BaseController(IMapper mapper, ILoggerManager logger, IOptions<AppSettings> appSettings)
        {
            _mapper = mapper;
            _appSettings = appSettings.Value;
            _logger = logger;
        }
    }
}
