using EasyAI;
using UnityEngine;

namespace A2.States
{
    /// <summary>
    /// Roaming state for the microbe, doesn't have any actions and only logs messages.
    /// </summary>
    [CreateAssetMenu(menuName = "A2/States/Microbe Roaming State", fileName = "Microbe Roaming State")]
    public class MicrobeRoamingState : State
    {
        Microbe agentMicrobe;
        Vector3 position;
        public override void Enter(Agent agent)
        {
            agent.Log("Roaming now");
            position = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));
        }

        public override void Execute(Agent agent)
        {
            
            agent.Move(position);

            
        }
        
        public override void Exit(Agent agent)
        {
            
        }
    }
}