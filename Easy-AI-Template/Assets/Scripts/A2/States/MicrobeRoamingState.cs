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
        Microbe magent;
        float x, y, z;
        Vector3 pos;

        public override void Enter(Agent agent)
        {
            // TODO - Assignment 2 - Complete this state. Have microbes randomly roam around.
            magent = (Microbe)agent;
            agent.Log("Roaming");

            /*x = Random.Range(0, 20);
            y = Random.Range(0, 20); ;
            z = Random.Range(0, 20);*/
        }

        public override void Execute(Agent agent)
        {

            //pos = new Vector3(x,y,z);
            pos = Random.insideUnitCircle * 30;
            magent.Move(pos);


        }

        public override void Exit(Agent agent)
        {
            // TODO - Assignment 2 - Complete this state. Have microbes randomly roam around.
        }
    }
}