using EasyAI;
using UnityEngine;
using EasyAI.Navigation;

namespace A2.States
{
    /// <summary>
    /// State for microbes that are being hunted.
    /// </summary>
    [CreateAssetMenu(menuName = "A2/States/Microbe Hunted State", fileName = "Microbe Hunted State")]
    public class MicrobeHuntedState : State
    {
        Microbe magent;
        public override void Enter(Agent agent)
        {
            // TODO - Assignment 3 - Complete this state. Add the ability for microbes to evade hunters.
            agent.Log("I'm being hunted!");
            magent = (Microbe)agent;
        }

        public override void Execute(Agent agent)
        {
            if (magent != null && magent.Hunter != null)
            {
                magent.Move(magent.Hunter.transform.position, Steering.Behaviour.Evade);
                magent.SetState<MicrobeRoamingState>();

            }
            if (magent.BeingHunted == false)
            {
                magent.StopMoving();
                magent.SetState<MicrobeRoamingState>();
            }
        }
        
        public override void Exit(Agent agent)
        {
            // TODO - Assignment 3 - Complete this state. Add the ability for microbes to evade hunters.
            agent.Log("No longer being hunted.");
        }
    }
}