﻿using SiliconeTrader.Machine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiliconeTrader.Machine.Models
{
    public class LogViewModel : BaseViewModel
    {
        public IEnumerable<string> LogEntries { get; set; }
    }
}
