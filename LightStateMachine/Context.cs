/******************************************************************************
* Filename    = Context.cs
*
* Author      = Lekshmi R Nair
*
* Product     = TrafficLightStateMachine
* 
* Project     = LightStateMachine
*
* Description = Represents the context of a traffic light. Manages the current 
*               light state and transitions of the traffic light.
*****************************************************************************/

namespace LightStateMachine
{
    /// <summary>
    /// Represents the context of traffic light in a situation.
    /// </summary>
    public class Context : ILightState
    {
        /// <summary>
        /// Gets or sets the current state of the traffic light.
        /// </summary>
        public ILightState _state { get; set;  }
        /// <summary>
        /// Gets or sets the previous state of the traffic light.
        /// </summary>
        public ILightState? _previousState { get; set; }
        /// <summary>
        /// Initializes a new instance of the Context class.
        /// Sets the initial state to red and no previous state.
        /// </summary>
        public Context()
        {
            _state = new RedLightState();
            _previousState = null;
        }
        /// <summary>
        /// Changes the state of the traffic light.
        /// </summary>
        /// <param name="self">The current context.</param>
        public void ChangeState(Context self)
        {
            StorePreviousState(this);
            _state.ChangeState(this);
        }
        /// <summary>
        /// Shows the current state of the traffic light.
        /// </summary>
        /// <returns>A string representing the current state of the traffic light.</returns>
        public string ShowCurrentState()
        {
            return _state.ShowCurrentState();
        }
        /// <summary>
        /// Stores the previous state of the traffic light.
        /// </summary>
        /// <param name="self">The current context.</param>
        public void StorePreviousState(Context self)
        {
            _state.StorePreviousState(this);
        }
    }
}
