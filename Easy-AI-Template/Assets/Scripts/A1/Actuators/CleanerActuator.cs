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
        float timer=0f;
        int seconds;
        
        public override bool Act(object agentAction)
        {
            timer+= Time.deltaTime;
            seconds = (int)timer % 60;
            //  Debug.Log(seconds);
            

            if (Agent.CompareTag("Cleaner1"))
            {
                contSpeed = 5f;
            }

            if (Agent.CompareTag("Cleaner2"))
            {
                contSpeed = 3f;
            }
            if (agentAction == null)
            {
                Agent.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0.0f, 0.0f, 0.0f), Time.deltaTime * contSpeed);
            }
            else
            {

                
                Floor tile = (Floor)agentAction;


                //Agent.transform.Translate(tile.transform.position * Time.deltaTime);
                Agent.transform.position = Vector3.MoveTowards(transform.position, tile.transform.position, Time.deltaTime * contSpeed);
              
                if (Vector3.Distance(Agent.transform.position, tile.transform.position) < 0.1f)
                {
                    
                    tile.Clean();
                    tile.tileCount++;
                    Debug.Log(tile.tileCount);

                }
                if (seconds == 10)
                {
                    Debug.Log("Performance measure: " + tile.tileCount);
                }

            }
            


            return true;
        }

        
    }
}
