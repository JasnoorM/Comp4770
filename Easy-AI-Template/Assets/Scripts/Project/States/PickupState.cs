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
        Pickups.HealthAmmoPickup mysterypickup;
        NearestAmmoPickupSensor mystery;
        NavMeshAgent NavAgent;
        private bool pickedup = true;
        public override void Enter(Agent agent)
        {

            SolAgent = (Soldier)agent;
            NavAgent = SolAgent.GetComponent<NavMeshAgent>();
            point = SolAgent.GetComponent<NearestPointPickupSensor>();
            mystery = SolAgent.GetComponent<NearestAmmoPickupSensor>();
            pointspickup = (Pickups.HealthAmmoPickup)point.Sense();  //sense the nearest pickup
            mysterypickup = (Pickups.HealthAmmoPickup)mystery.Sense();
        }
        public override void Execute(Agent agent)
        {
            base.Execute(agent);

            if (pointspickup != null)
            {
                Vector3 position = pointspickup.transform.position;
                NavAgent.SetDestination(position);
                pickedup = true;
                SolAgent.SetState<PursueState>();


            }
            else SolAgent.SetState<PickupState2>(); //mistery pickup

            

            if(pickedup)
            {
                SolAgent.SetState<PursueState>(); //pursue state
            }

           

        }

    }
}
