using EasyAI;
using UnityEngine;

namespace A2.States
{
    /// <summary>
    /// State for microbes that are hungry and wanting to seek food.
    /// </summary>
    [CreateAssetMenu(menuName = "A2/States/Microbe Hungry State", fileName = "Microbe Hungry State")]
    public class MicrobeHungryState : State
    {
        public override void Enter(Agent agent)
        {
            agent.Log("Looking for food");
        }
        
        public override void Execute(Agent agent)
        {
            
        }
        
        public override void Exit(Agent agent)
        {
            
        }
    }
}