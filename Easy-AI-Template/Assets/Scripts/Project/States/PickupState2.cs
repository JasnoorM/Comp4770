using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAI;
using Project.Sensors;
using UnityEngine.AI;


namespace Project.States
{
    public class PickupState2 : State
    {

        Soldier SolAgent;
        Pickups.HealthAmmoPickup mysterypickup;
        NearestAmmoPickupSensor mystery;
        NavMeshAgent NavAgent;
        private bool pickedup = true;
        public override void Enter(Agent agent)
        {

            SolAgent = (Soldier)agent;
            NavAgent = SolAgent.GetComponent<NavMeshAgent>();
            mystery = SolAgent.GetComponent<NearestAmmoPickupSensor>();
            mysterypickup = (Pickups.HealthAmmoPickup)mystery.Sense();
        }
        public override void Execute(Agent agent)
        {
            base.Execute(agent);

            if (mysterypickup != null) //pickup mistery pickup:
            {
                Vector3 position = mysterypickup.transform.position;
                SolAgent.NavMeshMove(position, NavAgent);
                pickedup = true;
                SolAgent.SetState<PursueState>(); //switch to pursue
            }
            

            if(pickedup)
            {
                SolAgent.SetState<PursueState>();
            }

           

        }

    }
}
