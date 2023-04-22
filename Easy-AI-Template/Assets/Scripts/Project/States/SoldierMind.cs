using EasyAI;
using UnityEngine;
using UnityEngine.AI;

namespace Project.States
{
    /// <summary>
    /// The global state which soldiers are always in.
    /// </summary>
    [CreateAssetMenu(menuName = "Project/States/Soldier Mind", fileName = "Soldier Mind")]
    public class SoldierMind : State
    {
        Soldier SolAgent;
         
        public override void Execute(Agent agent)
        {

            
            SolAgent = (Soldier)agent;
            
            

            
            SolAgent.SetState<RoamingState>();
            
            /*if (SolAgent.AtkPoints < 0.1 * 1500)
            {

                SolAgent.SetState<PickupState>();
            }
            if(SolAgent.isLosing)
            {
                SolAgent.SetState<PickupState2>();
            }*/

        }
    }
}
