using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAI;
using Project.Sensors;


namespace Project.States
{
    public class PickupState : State
    {

        Soldier SolAgent;
        NearestPointPickupSensor point;
        Pickups.HealthAmmoPickup pointspickup;
        public override void Enter(Agent agent)
        {

            SolAgent = (Soldier)agent;
            agent.Log("Looking for a pickup");
            point = SolAgent.GetComponent<NearestPointPickupSensor>();
            pointspickup = (Pickups.HealthAmmoPickup)point.Sense(); ; //sense the nearest pickup
        }
        public override void Execute(Agent agent)
        {
            base.Execute(agent);

            if (pointspickup != null)
            {
                Vector3 position = pointspickup.transform.position;
                SolAgent.Move(position);
            }

            if(SolAgent.DetectedEnemies != null)
            {
                SolAgent.SetState<PursueState>();
            }

            
        }

    }
}
