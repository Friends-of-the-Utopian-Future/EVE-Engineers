using System.Linq;
using Sandbox.Common.GlobalConfigurations;
using Sandbox.Engine.Networking;
using Sandbox.Game.Gui;

namespace Sandbox.Game.Debugging
{
    internal class MainMenuSkipHelper
    {
        private static bool _isMenuToBeSkipped = true;

        private static bool ShouldReloadLastSave => StartupParameters.LoadLastSave && _isMenuToBeSkipped;

        private static void DoReload()
        {
            var session =
                MyLocalCache.GetAvailableWorldInfos().OrderByDescending(s => s.Item2.LastLoadTime).FirstOrDefault();
            if (session != null)
                MyGuiScreenLoadSandbox.LoadSingleplayerSession(session.Item1);

            _isMenuToBeSkipped = false;
        }

        public static void SkipMenuIfStartupParamIsTrue()
        {
            if (ShouldReloadLastSave)
            {
                DoReload();
            }
        }
    }
}