﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiliconeTrader.Core
{
    public interface IConfigurableService : INamedService
    {
        IConfigurationSection RawConfig { get; }
    }
}