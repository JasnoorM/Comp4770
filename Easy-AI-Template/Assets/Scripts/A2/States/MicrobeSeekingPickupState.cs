using EasyAI;
using UnityEngine;

namespace A2.States
{
    /// <summary>
    /// State for microbes that are seeking a pickup.
    /// </summary>
    [CreateAssetMenu(menuName = "A2/States/Microbe Seeking Pickup State", fileName = "Microbe Seeking Pickup State")]
    public class MicrobeSeekingPickupState : State
    {
        public override void Enter(Agent agent)
        {
            agent.Log("Looking for pickups");
        }
        
        public override void Execute(Agent agent)
        {
            
        }
        
        public override void Exit(Agent agent)
        {
            
        }
    }
}