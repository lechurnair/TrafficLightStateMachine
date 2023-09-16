/******************************************************************************
* Filename    = YellowLightState.cs
*
* Author      = Lekshmi R Nair
*
* Product     = TrafficLightStateMachine
* 
* Project     = LightStateMachine
*
* Description = Represents the state of a traffic light when its yellow color. 
*               Manages the behavior and transition of light when its yellow.
*****************************************************************************/
namespace LightStateMachine
{
    /// <summary>
    /// Represents the state of Yellow traffic light.
    /// </summary>
    internal class YellowLightState : ILightState
    {
        /// <summary>
        /// Changes the state of the traffic light to green if the previous state was red, 
        /// otherwise changes to red.
        /// </summary>
        /// <param name="context">The context associated with the traffic light.</param>
        public void ChangeState(Context context)
        {
            if (context._previousState is RedLightState)
            {
                context._state = new GreenLightState();
            }
            else
            {
                context._state = new RedLightState();
            }

        }
        /// <summary>
        /// Shows the current state of the traffic light as "Yellow."
        /// </summary>
        /// <returns>A string representing the current state of the traffic light.</returns>
        public string ShowCurrentState()
        {
            return "Yellow";
        }
        /// <summary>
        /// Does not store the previous state for the yellow light, since its same for both red and green
        /// </summary>
        /// <param name="context">The context associated with the traffic light.</param>
        public void StorePreviousState(Context context)
        {
        }
    }
}
