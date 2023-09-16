/******************************************************************************
* Filename    = GreenLightState.cs
*
* Author      = Lekshmi R Nair
*
* Product     = TrafficLightStateMachine
* 
* Project     = LightStateMachine
*
* Description = Represents the state of a traffic light when its green color. 
*               Manages the behavior and transition of light when its green.
*****************************************************************************/

namespace LightStateMachine
{
    /// <summary>
    /// Represents the state of Green traffic light.
    /// </summary>
    internal class GreenLightState : ILightState
    {
        /// <summary>
        /// Changes the state of the traffic light to yellow.
        /// </summary>
        /// <param name="context">The context associated with the traffic light.</param>
        public void ChangeState(Context context)
        {
            context._state = new YellowLightState();
        }
        /// <summary>
        /// Shows the current state of the traffic light as "Green."
        /// </summary>
        /// <returns>A string representing the current state of the traffic light.</returns>
        public string ShowCurrentState()
        {
            return "Green";
        }
        /// <summary>
        /// Stores the previous state of the traffic light.
        /// </summary>
        /// <param name="context">The context associated with the traffic light.</param>
        public void StorePreviousState(Context context)
        {
            context._previousState = context._state;
        }
    }
}
