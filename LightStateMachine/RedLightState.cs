/******************************************************************************
* Filename    = RedLightState.cs
*
* Author      = Lekshmi R Nair
*
* Product     = TrafficLightStateMachine
* 
* Project     = LightStateMachine
*
* Description = Represents the state of a traffic light when its red color. 
*               Manages the behavior and transition of light when its red.
*****************************************************************************/

namespace LightStateMachine
{
    /// <summary>
    /// Represents the state of Red traffic light.
    /// </summary>
    internal class RedLightState : ILightState
    {
        /// <summary>
        /// Changes the state of the traffic light to yellow.
        /// </summary>
        /// <param name="context">The context associated with the traffic light.</param>
        public void ChangeState( Context context )
        {
            context._state = new YellowLightState();
        }
        /// <summary>
        /// Shows the current state of the traffic light as "Red."
        /// </summary>
        /// <returns>A string representing the current state of the traffic light.</returns>
        public string ShowCurrentState()
        {
            return "Red";
        }
        /// <summary>
        /// Stores the previous state of the traffic light.
        /// </summary>
        /// <param name="context">The context associated with the traffic light.</param>
        public void StorePreviousState( Context context )
        {
            context._previousState = context._state;
        }
    }
}
