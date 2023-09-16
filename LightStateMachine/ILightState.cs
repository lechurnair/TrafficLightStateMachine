/******************************************************************************
* Filename    = ILightState.cs
*
* Author      = Lekshmi R Nair
*
* Product     = TrafficLightStateMachine
* 
* Project     = LightStateMachine
*
* Description = Represents the state of a traffic light. Defines methods 
*               to manage the traffic light's behavior and transitions between states.
*****************************************************************************/

namespace LightStateMachine
{
    /// <summary>
    /// Represents the state interface of traffic light.
    /// </summary>
    public interface ILightState
    {
        /// <summary>
        /// Changes the state of the traffic light.
        /// </summary>
        /// <param name="context">The context associated with the traffic light.</param>
        void ChangeState(Context context);
        /// <summary>
        /// Stores the previous state of the traffic light.
        /// </summary>
        /// <param name="context">The context associated with the traffic light.</param>
        void StorePreviousState(Context context);
        /// <summary>
        /// Shows the current state of the traffic light.
        /// </summary>
        /// <returns>A string representing the current state of the traffic light.</returns>
        string ShowCurrentState();
    }
}
