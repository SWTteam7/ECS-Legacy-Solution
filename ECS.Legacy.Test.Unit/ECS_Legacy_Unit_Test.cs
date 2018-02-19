using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace ECS.Legacy.Test.Unit
{
   [TestFixture]
    public class ECS_Legacy_Unit_Test
   {

      private ECS uut;

      [SetUp]
      public void SetUp()
      {
         
      }

      [Test]
      public void Regulate_HighTemp_HeaterIsTurnedOn()
      {
         var fh = new FakeHeater();
         var ts = new FakeTempSensor();

         var uut = new ECS(25, ts, fh);

         ts.Temp = 27;

         uut.Regulate();

         Assert.That(fh.WasTurnOffCalled, Is.EqualTo(true));
      }

      [Test]
      public void Expection_TempUnder0()
      {
         var fh = new FakeHeater();
         var ts = new FakeTempSensor();

         var uut = new ECS(25, ts, fh);

         ts.Temp = -2;

         Assert.Throws(Is.TypeOf<ArgumentException>(),()=> uut.Regulate());
      }
   }
}
