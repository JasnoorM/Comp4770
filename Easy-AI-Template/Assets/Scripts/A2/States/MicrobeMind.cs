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

        public override void Execute(Agent agent)
        {

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
            else if (!magent.HasPickup)
            {
                magent.SetState<MicrobeSeekingPickupState>();
            }
            
            else {
                magent.SetState<MicrobeRoamingState>();
            }
             
        }
    }
}