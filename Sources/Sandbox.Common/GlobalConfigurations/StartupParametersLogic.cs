using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.Common.GlobalConfigurations
{
    public static class StartupParametersLogic
    {
        public static void Configure(string[] args)
        {
            if (args.Contains("-loadlastsave"))
            {
                StartupParameters.LoadLastSave = true;
            }
        }
    }
}
