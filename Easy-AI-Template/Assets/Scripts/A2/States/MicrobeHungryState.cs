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
            prey = (Microbe)NearPrey.Sense(); //sense prey
            if(prey != null) magent.StartHunting(prey); //if prey still exists then start hunting
            
        }
        
        public override void Execute(Agent agent)
        {
            //if microbe and prey exist
            if (prey != null && magent != null)
            {
                    
                    magent.Move(prey.transform.position, Steering.Behaviour.Pursue); //microbe moves towards(pursue) the prey
                    magent.Eat(); //microbe eats the prey
                    magent.SetState<MicrobeRoamingState>(); //go back to roaming state after eating

            }
            if (!magent.IsHungry) magent.SetState<MicrobeRoamingState>(); //go to roaming state if microbe is not hungry
        }
        
        public override void Exit(Agent agent)
        {
            agent.Log("Done eating");
        }
    }
}