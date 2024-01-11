using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace TestAnimalFarm
{
    [TestFixture]
    internal class TestProgram
    {
        [Test]
        public void TestCheckSettingsInput()
        {
            /*
                Tested Class: Program
                Tested Func: CheckSettingInput
            */
            Assert.AreEqual(true, AnimalFarm.Program.CheckSettingInput("2"));
        }

        [Test]
        public void Test()
        {
            /*
                Tested Class: Building
                Tested Func: GetOwner & SetOwner
            */            
            AnimalFarm.Building b = new AnimalFarm.Building();
            AnimalFarm.Farmer farmer1 = new AnimalFarm.Farmer("TestUser1");

            b.SetOwner(farmer1);

            Assert.AreEqual(farmer1, b.GetOwner());
        }

    }
}
