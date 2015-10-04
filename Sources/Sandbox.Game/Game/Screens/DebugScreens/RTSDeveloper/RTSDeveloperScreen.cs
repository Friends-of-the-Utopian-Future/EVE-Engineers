#region

using System;
using System.Text;
using Sandbox.Game.Gui;
using Sandbox.Graphics.GUI;
using VRage.Input;
using VRageMath;

#endregion

namespace Sandbox.Game.Screens.DebugScreens.RTSDeveloper
{
  public class RTSDeveloperScreen : MyGuiScreenDebugBase
  {
    private RTSDeveloperScreenView ScreenView { get; set; }

    public RTSDeveloperScreen()
      : base(new Vector2(.5f, .5f), new Vector2(0.35f, 0.9f), 0.35f*Color.Yellow.ToVector4(), true)
    {
      ScreenView = new RTSDeveloperScreenView();

      // This disable drawing of the background image as well:
      m_backgroundColor = null;

      EnabledBackgroundFade = true;
      m_backgroundFadeColor = new Color(1.0f, 1.0f, 1.0f, 0.2f);

      RecreateControls(true);
    }

    public override sealed void RecreateControls(bool constructor)
    {
      base.RecreateControls(constructor);

      ScreenView.DevScreenCaption = AddCaption("RTS Developer screen", Color.AliceBlue.ToVector4());
      ScreenView.ATestButton = AddButton(new StringBuilder("Test"), (OnClickATestButton));
    }

    private void OnClickATestButton(MyGuiControlButton myGuiControlButton)
    {
      RTSDeveloperController.UpdateCaption(myGuiControlButton, ScreenView);
    }

    public override string GetFriendlyName()
    {
      return "RTSDeveloperScreen";
    }

    public override void HandleInput(bool receivedFocusInThisUpdate)
    {
      base.HandleInput(receivedFocusInThisUpdate);

      if (MyInput.Static.IsNewKeyPressed(MyKeys.F12))
      {
        CloseScreen();
      }
    }
  }

  internal class RTSDeveloperScreenView
  {
    public MyGuiControlLabel DevScreenCaption { get; set; }
    public MyGuiControlButton ATestButton { get; set; }
  }

  internal static class RTSDeveloperController
  {
    public static void UpdateCaption(MyGuiControlButton myGuiControlButton, RTSDeveloperScreenView screenView)
    {
      screenView.DevScreenCaption.Text = DateTime.Now.ToLongDateString();
      screenView.DevScreenCaption.Update();
    }
  }
}