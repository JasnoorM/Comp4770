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

        Vector3 wanderTarget; //new position
        Vector3 pos;

        float radius, distance , jitter;


        public override void Enter(Agent agent)
        {

            distance = Random.Range(-10, 10);
            radius = Random.Range(1, 20); //random ralue for radius
            jitter = Random.Range(0, 5);
            magent = (Microbe)agent;
            agent.Log("Roaming");
            wanderTarget = new Vector3(Random.value, Random.value, Random.value); //creates a vector 3 with random values
        }

        public override void Execute(Agent agent)
        {

            
            
            wanderTarget.Normalize(); //finds a normal vector
            wanderTarget *= radius; // multiplies to the raduis so is stays within range
            wanderTarget.x += distance; //adds distance to x axis
            wanderTarget.y += distance; //adds distance to y axis
            wanderTarget.z += distance; //adds distance to z axis

            if (magent != null) //when microbe is not destroyed yet
            {
                
                magent.Move(wanderTarget); //move to the new position

                // if microbe is not moving then go to the mind state
                if (!magent.Moving) magent.SetState<MicrobeMind>(); 
                

            }

            

            

        }

        public override void Exit(Agent agent)
        {
            

            

        }




    }
}