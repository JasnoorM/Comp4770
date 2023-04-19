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
      
        public override void Execute(Agent agent)
        {
            position = new Vector3(0, 0, 0);
            SolAgent = (Soldier)agent;
            navAgent = SolAgent.GetComponent<NavMeshAgent>();
            //navAgent.autoBraking = false;
            navAgent.SetDestination(position);
            //SolAgent.Move(navAgent.destination);
            
            Debug.Log(navAgent.destination);

        }
    }
}