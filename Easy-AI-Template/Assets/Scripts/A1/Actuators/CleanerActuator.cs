using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAI;
using A1;

public class CleanerActuator : Actuator
{
    

    public override bool Act(object agentAction)
    {
        if (agentAction == null)
        {
            Agent.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0.0f, 0.0f, 0.0f), Time.deltaTime * 5f);
        }
        else
        {
            Floor tile = (Floor)agentAction;


            //Agent.transform.Translate(tile.transform.position * Time.deltaTime);
            Agent.transform.position = Vector3.MoveTowards(transform.position, tile.transform.position, Time.deltaTime * 5f);

            if (Vector3.Distance(Agent.transform.position, tile.transform.position) < 0.1f)
            {

                tile.Clean();



            }
        }
        
        return true;
    }
}
