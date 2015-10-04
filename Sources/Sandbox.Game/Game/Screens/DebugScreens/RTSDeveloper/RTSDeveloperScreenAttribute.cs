using System;

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
}