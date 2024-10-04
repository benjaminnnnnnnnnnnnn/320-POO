using Drones;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Windows.Forms;



namespace DronesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone(500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }

        [TestMethod]
        public void Test_addbox()
        {
            Box box = new Box(1);


            Dispatch dispatch = new Dispatch();
            dispatch.addbox(box);

            Assert.AreEqual(1, dispatch.dispatchbox.Count);



            dispatch.removebox(box);

            Assert.AreEqual(0, dispatch.dispatchbox.Count);
        }

    }
}