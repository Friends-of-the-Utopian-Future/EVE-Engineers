using System.Collections.Generic;
using Sandbox.Graphics.GUI;

namespace SpaceEngineers.GameConversion.GUI.Screens.Developer
{
  public class MyDevelopGroup
  {
    public readonly List<MyGuiControlBase> ControlList;
    public readonly string Name;
    public MyGuiControlBase GroupControl;

    public MyDevelopGroup(string name)
    {
      Name = name;
      ControlList = new List<MyGuiControlBase>();
    }
  };
}