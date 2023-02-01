using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAI;
using A1;

public class CleanerActuator : Actuator
{
    public override bool Act(object agentAction)
    {
        Floor tile = (Floor)agentAction;
        Agent.transform.Translate(tile.transform.position * Time.deltaTime);

        if (Vector3.Distance(Agent.transform.position, tile.transform.position) < 0.1f)
        {
            tile.Clean();

        }
        return true;
    }
}
