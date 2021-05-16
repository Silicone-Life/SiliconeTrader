﻿namespace SiliconeTrader.Machine.Client.Models
{
    public class DefaultViewModel : IInstanceVersion
    {
        public static DefaultViewModel Default => new DefaultViewModel
        {
            InstanceName = "",
            ReadOnlyMode = true,
            Version = ""
        };

        public string Error { get; set; }

        public string InstanceName { get; set; }

        public bool ReadOnlyMode { get; set; }

        public string Version { get; set; }
    }
}