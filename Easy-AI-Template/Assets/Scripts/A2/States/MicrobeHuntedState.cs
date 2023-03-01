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
            
            agent.Log("I'm being hunted!");
            magent = (Microbe)agent;
        }

        public override void Execute(Agent agent)
        {

            // when microbes being hunted and the hunter microbe are not dead, and the microve detects the hunter microbe
            if (magent != null && magent.Hunter != null && Vector3.Distance(magent.transform.position, magent.Hunter.transform.position)< magent.DetectionRange)
            {
                //microbe move away 'evade' from the hunter
                magent.Move(magent.Hunter.transform.position, Steering.Behaviour.Evade);
                

            }
            if (!magent.BeingHunted) //if mirobe no longer being hunted
            {
                magent.StopMoving(); //stop moving
                magent.SetState<MicrobeRoamingState>(); //go back to roaming
            }
        }
        
        public override void Exit(Agent agent)
        {
            agent.Log("No longer being hunted.");
        }
    }
}