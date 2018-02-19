using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.Test.Unit
{
   public class FakeHeater:IHeater
   {
      public bool WasTurnOnCalled { get; set; }
      public bool WasTurnOffCalled { get; set; }

      public FakeHeater()
      {
         WasTurnOnCalled = false;
         WasTurnOffCalled = false;
      }
      public void TurnOn()
      {
         WasTurnOnCalled = true;
      }

      public void TurnOff()
      {
         WasTurnOffCalled = true;
      }

      public bool RunSelfTest()
      {
         return true;
      }
   }
}
