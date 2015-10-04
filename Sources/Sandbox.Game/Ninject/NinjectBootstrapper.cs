using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using Sandbox.Game.Gui;

namespace Sandbox.Ninject
{
  public class NinjectBootstrapper : NinjectModule
  {
    public override void Load()
    {
      //Bind<IMyGuiScreenDebugDeveloper>().To<MyGuiScreenDebugDeveloper>();
    }
  }
}
