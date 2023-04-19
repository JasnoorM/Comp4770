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
        public override void Execute(Agent agent)
        {
            Soldier SolAgent = (Soldier)agent;
            SolAgent.NavMovement(new Vector3(0, 0, 0));
        }
    }
}