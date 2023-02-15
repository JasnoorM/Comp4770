using EasyAI;
using UnityEngine;

namespace A2.States
{
    /// <summary>
    /// The global state which microbes are always in.
    /// </summary>
    [CreateAssetMenu(menuName = "A2/States/Microbe Mind", fileName = "Microbe Mind")]
    public class MicrobeMind : State
    {
        //A2.Sensors.NearestPickupSensor sensor;
        MicrobeSeekingPickupState seek;

        public override void Execute(Agent agent)
        {
            // TODO - Assignment 2 - Complete the mind of the microbes.
            seek.Enter(agent);
            seek.Execute(agent);

            
        }
    }
}