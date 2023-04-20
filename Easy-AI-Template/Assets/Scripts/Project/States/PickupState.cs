using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAI;
using Project.Sensors;
using UnityEngine.AI;


namespace Project.States
{
    public class PickupState : State
    {

        Soldier SolAgent;
        NearestPointPickupSensor point;
        Pickups.HealthAmmoPickup pointspickup;
        NavMeshAgent NavAgent;
        public override void Enter(Agent agent)
        {

            SolAgent = (Soldier)agent;
            NavAgent = SolAgent.GetComponent<NavMeshAgent>();
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
                SolAgent.Navigate(position);
                //NavAgent.SetDestination(position);
                
            }

            if(SolAgent.DetectedEnemies != null)
            {
                SolAgent.SetState<PursueState>();
            }

            
        }

    }
}
