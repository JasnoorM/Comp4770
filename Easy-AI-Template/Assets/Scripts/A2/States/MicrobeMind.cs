using EasyAI;
using UnityEngine;
using A2.Sensors;
using A2.Pickups;

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
            else
            {
                magent.SetState<MicrobeRoamingState>();
            }


        }
    }
}