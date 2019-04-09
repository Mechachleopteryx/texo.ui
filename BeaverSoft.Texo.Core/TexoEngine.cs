﻿using System;
using BeaverSoft.Texo.Core.Configuration;
using BeaverSoft.Texo.Core.Runtime;

namespace BeaverSoft.Texo.Core
{
    public class TexoEngine : IDisposable
    {
        private readonly IRuntimeCoordinatorService runtime;
        private readonly ISettingService setting;

        internal TexoEngine(
            IRuntimeCoordinatorService runtime,
            ISettingService setting)
        {
            this.runtime = runtime ?? throw new ArgumentNullException(nameof(runtime));
            this.setting = setting ?? throw new ArgumentNullException(nameof(setting));
        }

        public void Configure(TextumConfiguration configuration)
        {
            setting.Configure(configuration);
        }

        public void Initialise()
        {
            runtime.Initialise();
        }

        public void Start()
        {
            runtime.Start();
        }

        public void Process(string input)
        {
            runtime.Process(input);
        }

        public void Dispose()
        {
            runtime.Dispose();
        }
    }
}