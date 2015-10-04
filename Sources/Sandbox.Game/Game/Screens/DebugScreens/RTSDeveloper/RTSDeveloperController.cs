using System;
using Sandbox.Graphics.GUI;

namespace Sandbox.Game.Screens.DebugScreens.RTSDeveloper
{
  internal static class RTSDeveloperController
  {
    public static void UpdateCaption(MyGuiControlButton myGuiControlButton, RTSDeveloperScreenView screenView)
    {
      screenView.DevScreenCaption.Text = DateTime.Now.ToLongTimeString();
      screenView.DevScreenCaption.Update();
    }
  }
}