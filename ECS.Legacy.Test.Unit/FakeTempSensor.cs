using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.Test.Unit
{
   public class FakeTempSensor: ITempSensor
   {
      public bool WasGetTempCalled { get; set; }

      public int Temp { get; set; }

      public FakeTempSensor()
      {
         WasGetTempCalled = false;
      }
      public int GetTemp()
      {
         WasGetTempCalled = true;
         return Temp;
      }

      public bool RunSelfTest()
      {
         return true;
      }
   }
}
