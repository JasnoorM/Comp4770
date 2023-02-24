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

        public override void Enter(Agent agent)
        {
           

            magent = (Microbe)agent;
            agent.Log("Roaming");            

        }

        public override void Execute(Agent agent)
        {
            /*if (magent != null)

            {
                x = Random.Range(0, 20);
                //y = Random.Range(0, 1);
                z = Random.Range(0, 20);

                Vector3 pos = new Vector3(x, 0, z);
                magent.Move(pos);




                if (Vector3.Distance(magent.transform.position, pos) < 0.1f)
                {
                    x = Random.Range(0, 20);
                    //y = Random.Range(0, 1);
                    z = Random.Range(0, 20);
                    pos = new Vector3(x, 0, z);
                    magent.Move(pos);
                }


            }
*/
        }

        public override void Exit(Agent agent)
        {
            // TODO - Assignment 2 - Complete this state. Have microbes randomly roam around.

            

        }




    }
}