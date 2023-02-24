using EasyAI;
using UnityEngine;
using A2.Sensors;
using EasyAI.Navigation;

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
            if(prey != null) magent.StartHunting(prey);
            
        }
        
        public override void Execute(Agent agent)
        {
            if (prey != null && magent != null)
            {
                
                    magent.Move(prey.transform.position, Steering.Behaviour.Pursue);
                    magent.Eat();
                    magent.SetState<MicrobeRoamingState>();
            }
            
        }
        
        public override void Exit(Agent agent)
        {
            agent.Log("Done eating");
        }
    }
}