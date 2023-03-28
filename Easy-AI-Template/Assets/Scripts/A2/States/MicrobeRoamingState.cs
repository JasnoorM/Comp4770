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

        Vector3 wanderTarget;
        Vector3 pos;

        float radius, distance , jitter;


        public override void Enter(Agent agent)
        {

            distance = Random.Range(-10, 10);
            radius = Random.Range(1, 20);
            jitter = Random.Range(0, 5);
            magent = (Microbe)agent;
            agent.Log("Roaming");
            
            wanderTarget = new Vector2(Random.value, Random.value);
            magent.Move(wanderTarget);
        }

        public override void Execute(Agent agent)
        {

            
            
            /*wanderTarget.Normalize();
            wanderTarget *= radius;
            wanderTarget.x += distance;
            wanderTarget.y += distance;
            wanderTarget.z += distance;*/

            if (magent != null)
            {



                if (!magent.Moving || Vector2.Distance(magent.transform.position, wanderTarget) >= 0.2f)
                {
                    wanderTarget = MicrobeManager.RandomPosition;
                    magent.Move(wanderTarget);
                }
                

            }

            

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


            }*/

        }

        public override void Exit(Agent agent)
        {
            // TODO - Assignment 2 - Complete this state. Have microbes randomly roam around.

            

        }




    }
}