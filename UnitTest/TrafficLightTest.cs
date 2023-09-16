/******************************************************************************
* Filename    = TrafficLightTest.cs
*
* Author      = Lekshmi R Nair
*
* Product     = TrafficLightStateMachine
* 
* Project     = UnitTest
*
* Description = Unit tests for the Traffic light state pattern demo.
*****************************************************************************/
using LightStateMachine;
/// <summary>
/// Unit test for state pattern demo
/// </summary>
namespace UnitTest
{

    /// <summary>
    /// Unit test for state pattern demo
    /// </summary>
    [TestClass]
    public class TrafficLightTest
    {

        /// <summary>
        /// Tests if Red to Yellow Transition works
        /// </summary>
        [TestMethod]
        public void RedToYellowTest()
        {
            Context context = new();
            Assert.AreEqual(context.ShowCurrentState(),"Red");
            context.ChangeState(context);
            Assert.AreEqual( context.ShowCurrentState(),"Yellow");
        }

        /// <summary>
        /// Tests if Yellow to Green Transition works
        /// </summary>
        [TestMethod]
        public void YellowToGreenTest()
        {
            Context context = new();
            context.ChangeState(context);
            Assert.AreEqual( context.ShowCurrentState() ,"Yellow");
            context.ChangeState(context);
            Assert.AreEqual(context.ShowCurrentState() ,"Green");
        }
        /// <summary>
        /// Tests if cyclic change in traffic light is happening, by running two cycles
        /// </summary>
        [TestMethod]
        public void CompleteCycleTest()
        {
            Context context = new();
            context.ChangeState(context);
            context.ChangeState(context);
            context.ChangeState(context);
            context.ChangeState(context);
            Assert.AreEqual(context.ShowCurrentState(),"Red");
            context.ChangeState(context);
            Assert.AreEqual(context.ShowCurrentState(),"Yellow");
            context.ChangeState(context);
            Assert.AreEqual(context.ShowCurrentState(),"Green");

        }
    }
}
