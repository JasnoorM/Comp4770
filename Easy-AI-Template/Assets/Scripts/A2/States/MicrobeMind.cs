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


            


            if (magent.IsHungry) //when microbe is hungry
            {
                magent.SetState<MicrobeHungryState>(); //go to hungry state
            }
            else if (magent.IsAdult) //when microbe is an adult
            {
                magent.SetState<MicrobeMatingState>(); // go to mating state
            }
            else if (magent.BeingHunted) //when microbe is being hunted
            {
                magent.SetState<MicrobeHuntedState>(); //go to hunted state
            }
            else if (!magent.HasPickup) //when microbe has not picked up a pickup
            {
                magent.SetState<MicrobeSeekingPickupState>(); //go to pickup state
            }
            else
            {
                magent.SetState<MicrobeRoamingState>(); //go to roaming state
            }
            
        }
    }
}