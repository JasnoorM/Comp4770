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
        Microbe magent;
        NearestMateSensor NearMate;
        Microbe mate;
        public override void Enter(Agent agent)
        {
            agent.Log("Looking to mate");
            magent = (Microbe)agent;
            NearMate = agent.GetComponent<NearestMateSensor>();
            mate = (Microbe)NearMate.Sense();
        }
        
        public override void Execute(Agent agent)
        {
            if (mate != null)
            {
                magent.AttractMate(mate);
                magent.Mate();
            }
        }
        
        public override void Exit(Agent agent)
        {
            // TODO - Assignment 2 - Complete this state. Have microbes look for mates and reproduce.
        }
    }
}