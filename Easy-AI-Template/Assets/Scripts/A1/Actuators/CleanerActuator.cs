using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAI;
using A1;

namespace A1
{
    public class CleanerActuator : Actuator
    {
        public float contSpeed;

        public override bool Act(object agentAction)
        {

            //Timer to count number of seconds
            Agent.timer += Time.deltaTime;
            int seconds = (int)Agent.timer % 60;
            
            //Finding which vaccum is being used using tags
            if (Agent.CompareTag("Cleaner1"))
            {
                contSpeed = 5f;
            }

            if (Agent.CompareTag("Cleaner2"))
            {
                contSpeed = 3f;
            }

            //Returns back to starting position if there are no dirty tiles
            if (agentAction == null)
            {
                Agent.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0.0f, 0.0f, 0.0f), Time.deltaTime * contSpeed);

            }

  
            else
            {

                
                Floor tile = (Floor)agentAction;


                //Goes to the tile that is returned from the sensor and goes to its position
                Agent.transform.position = Vector3.MoveTowards(transform.position, tile.transform.position, Time.deltaTime * contSpeed);
              
                //Checks if its closer to the tile
                if (Vector3.Distance(Agent.transform.position, tile.transform.position) < 0.1f)
                {
                    //Cleans it if it closer to the tile
                    tile.Clean();

                    //Increments tile count to keep track of counts
                    Agent.tileCount++;

                }
            

            }

            //Check number of tiles cleaned in 10 secs and prints the value
            if (seconds == 10)
            {
                Debug.Log("Performance measure: " + Agent.tileCount);
            }


            return true;
        }

        
    }
}
