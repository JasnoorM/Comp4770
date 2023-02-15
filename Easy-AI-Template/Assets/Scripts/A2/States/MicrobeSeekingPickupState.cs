using A1;
using A2.Pickups;
using EasyAI;
using T1.Sensors;
using UnityEngine;
using UnityEngine.UIElements;

namespace A2.States
{
    /// <summary>
    /// State for microbes that are seeking a pickup.
    /// </summary>
    [CreateAssetMenu(menuName = "A2/States/Microbe Seeking Pickup State", fileName = "Microbe Seeking Pickup State")]
    public class MicrobeSeekingPickupState : State
    {
        A2.Sensors.NearestPickupSensor sensor;
        MicrobeBasePickup pickup;



        public override void Enter(Agent agent)
        {
            // TODO - Assignment 2 - Complete this state. Have microbes look for pickups.
            //Debug.Log("Moveing?");
            //pickup = (MicrobeBasePickup)sensor.Sense();
           
        }
        
        public override void Execute(Agent agent)
        {
            // TODO - Assignment 2 - Complete this state. Have microbes look for pickups.


            //agent.transform.position = Vector3.MoveTowards(agent.transform.position, pickup.transform.position, Time.deltaTime * 5f);
            Debug.Log("Moveing?");
            //pickup = (MicrobeBasePickup)sensor.Sense();
            Transform pickup = agent.Sense<A2.Sensors.NearestPickupSensor, Transform>();
            agent.Move(pickup.position);
        }
        
        public override void Exit(Agent agent)
        {
            // TODO - Assignment 2 - Complete this state. Have microbes look for pickups.
        }
    }
}