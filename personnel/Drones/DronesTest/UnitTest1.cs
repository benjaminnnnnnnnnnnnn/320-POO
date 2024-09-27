using Drones;
using Microsoft.VisualStudio.TestPlatform.TestHost;



namespace DronesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            

            foreach (Drone drone in fleet)
            {
                int _charge = 100;
                drone.Update(interval);
            }


            

        }
    }
}