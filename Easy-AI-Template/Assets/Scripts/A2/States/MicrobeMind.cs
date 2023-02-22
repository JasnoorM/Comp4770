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
        //MicrobeSeekingPickupState seek;

        public override void Execute(Agent agent)
        {
<<<<<<< Updated upstream
            // TODO - Assignment 2 - Complete the mind of the microbes.
=======
            Microbe magent = (Microbe)agent;
            if (magent.IsHungry)
            {
                magent.SetState<MicrobeHungryState>();
            }
            else if (magent.IsAdult)
            {
                magent.SetState<MicrobeMatingState>();
            }
            else if (magent.BeingHunted)
            {
                magent.SetState<MicrobeHuntedState>();
            }
            /*else
            {
                magent.SetState<MicrobeRoamingState>();
            }*/
>>>>>>> Stashed changes

            //seek = agent.gameObject.AddComponent<MicrobeSeekingPickupState>();
            
            //Debug.Log("Mind");
            //seek.Enter(agent);
            //seek.Execute(agent);

            
        }
    }
}