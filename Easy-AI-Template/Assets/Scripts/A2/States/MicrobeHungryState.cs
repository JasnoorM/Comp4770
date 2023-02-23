using EasyAI;
using UnityEngine;
using A2.Sensors;

namespace A2.States
{
    /// <summary>
    /// State for microbes that are hungry and wanting to seek food.
    /// </summary>
    [CreateAssetMenu(menuName = "A2/States/Microbe Hungry State", fileName = "Microbe Hungry State")]
    public class MicrobeHungryState : State
    {

        Microbe magent;
        NearestPreySensor NearPrey;
        Microbe prey;
        public override void Enter(Agent agent)
        {
            agent.Log("Looking for food");
            magent = (Microbe)agent;
            NearPrey = agent.GetComponent<NearestPreySensor>();
            prey = (Microbe)NearPrey.Sense();
            magent.StartHunting(prey);
        }
        
        public override void Execute(Agent agent)
        {
            
            magent.Move(prey.transform.position);
            magent.Eat();
            
        }
        
        public override void Exit(Agent agent)
        {
            
        }
    }
}