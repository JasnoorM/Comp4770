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

        private NavMeshAgent navAgent;
        Soldier SolAgent;
        Vector3 position;
        private NavMeshPath path;
        private float elapsed = 0.0f;

        void Start()
        {
            
            elapsed = 0.0f;
        }

        public override void Execute(Agent agent)
        {

            /*position = new Vector3(0, 0, 0);
            SolAgent = (Soldier)agent;
            navAgent = SolAgent.GetComponent<NavMeshAgent>();
            //navAgent.autoBraking = false;
            //navAgent.SetDestination(position);
            SolAgent.Navigate(position);
            Debug.Log(position);*/



            //SolAgent.SetState<PursueState>();
            SolAgent = (Soldier)agent;



           /* if (SolAgent.isQueen)
            {
             //   SolAgent.SetState<PursueState>();
            }
            else
            {
               // SolAgent.SetState<PickupState>();
            }*/



            position = new Vector3(0, 0, 0);
            SolAgent = (Soldier)agent;
            SolAgent.NavMeshMove(position);
            

            //SolAgent.Navigate(position);

            //SolAgent.Navigate(position);
            //navAgent.SetDestination(position);


        }
    }
}