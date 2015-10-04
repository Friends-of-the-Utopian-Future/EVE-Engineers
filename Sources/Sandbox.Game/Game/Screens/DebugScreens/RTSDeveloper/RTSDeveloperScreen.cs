#region

using System;
using Sandbox.Game.Gui;
using VRage.Input;
using VRageMath;

#endregion

namespace Sandbox.Game.Screens.DebugScreens.RTSDeveloper
{
  [AttributeUsage(AttributeTargets.Class, Inherited = false)]
  public class RTSDeveloperScreenAttribute : Attribute
  {
    public readonly string Group;
    public readonly string Name;

    public RTSDeveloperScreenAttribute(string group, string name)
    {
      Group = group;
      Name = name;
    }
  }

  public class RTSDeveloperScreen : MyGuiScreenDebugBase
  {
    public RTSDeveloperScreen()
      : base(new Vector2(.5f, .5f), new Vector2(0.35f, 0.9f), 0.35f*Color.Yellow.ToVector4(), true)
    {
      // This disable drawing of the background image as well:
      m_backgroundColor = null;

      EnabledBackgroundFade = true;
      m_backgroundFadeColor = new Color(1.0f, 1.0f, 1.0f, 0.2f);

      RecreateControls(true);
    }

    public override sealed void RecreateControls(bool constructor)
    {
      base.RecreateControls(constructor);

      AddCaption("RTS Developer screen", Color.AliceBlue.ToVector4());
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
}