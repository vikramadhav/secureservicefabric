﻿using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBackEnd.Domain
{
    public interface IMyBackend : IService
    {
        Task<IEnumerable<string>> GetData(string correlationId);
    }
}
