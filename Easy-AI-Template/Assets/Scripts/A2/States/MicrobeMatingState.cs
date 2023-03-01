using EasyAI;
using UnityEngine;
using A2.Sensors;
using EasyAI.Navigation;

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
            mate = (Microbe)NearMate.Sense(); //sense microbe to mate with
        }
        
        public override void Execute(Agent agent)
        {
            //when microbe and the mate are not dead and microbe has not already mated
            if (mate != null && magent !=null && !magent.DidMate)
            {
                //microbe goes to the attracted mate
                magent.AttractMate(mate);

                //when microbe has mated
                if (magent.DidMate)
                {
                    //go back to roaming
                    magent.SetState<MicrobeRoamingState>();
                }
            }
            
        }
        
        public override void Exit(Agent agent)
        {
            agent.Log("Done mating");
        }
    }
}