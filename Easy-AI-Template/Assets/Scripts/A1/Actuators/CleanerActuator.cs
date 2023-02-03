using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAI;
using A1;

public class CleanerActuator : Actuator
{
    public float contSpeed = 5f;

    public override bool Act(object agentAction)
    {

        
        if (agentAction == null)
        {
            Agent.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0.0f, 0.0f, 0.0f), Time.deltaTime * contSpeed);
        }
        else
        {

            int tileCount=0;
            Floor tile = (Floor)agentAction;


            //Agent.transform.Translate(tile.transform.position * Time.deltaTime);
            Agent.transform.position = Vector3.MoveTowards(transform.position, tile.transform.position, Time.deltaTime * contSpeed);

            if (Vector3.Distance(Agent.transform.position, tile.transform.position) < 0.1f)
            {

                tile.Clean();
                tileCount++;


            }
        }
        
        return true;
    }
}
