using EasyAI;
using UnityEngine;
using A2.Sensors;

namespace A2.States
{
    /// <summary>
    /// State for microbes that are seeking a mate.
    /// </summary>
    [CreateAssetMenu(menuName = "A2/States/Microbe Mating State", fileName = "Microbe Mating State")]
    public class MicrobeMatingState : State
    {
        
        public override void Enter(Agent agent)
        {
            agent.Log("About to mate");
        }
        
        public override void Execute(Agent agent)
        {

            

        }
        
        public override void Exit(Agent agent)
        {
            // TODO - Assignment 2 - Complete this state. Have microbes look for mates and reproduce.
        }
    }
}