using EasyAI;
using UnityEngine;
using UnityEngine.AI;


namespace Project.States
{
    /// <summary>
    /// The global state which soldiers are always in.
    /// </summary>
    [CreateAssetMenu(menuName = "Project/States/Soldier Mind", fileName = "Soldier Mind")]
    public class RoamingState : State
    {
        Soldier SolAgent;
         
        public override void Execute(Agent agent)
        {

            
            SolAgent = (Soldier)agent;
            NavMeshAgent meshAgent = SolAgent.GetComponent<NavMeshAgent>();

            Vector3 position = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));

            SolAgent.NavMeshMove(position, meshAgent);

            if(SolAgent.DetectedEnemies != null)
            {
                SolAgent.SetState<PursueState>();
            }



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
