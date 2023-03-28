using A2.Pickups;
using A2.Sensors;
using EasyAI;
using UnityEngine;
using EasyAI.Navigation;


namespace A2.States
{
    /// <summary>
    /// State for microbes that are seeking a pickup.
    /// </summary>
    [CreateAssetMenu(menuName = "A2/States/Microbe Seeking Pickup State", fileName = "Microbe Seeking Pickup State")]
    public class MicrobeSeekingPickupState : State
    {
        Microbe magent;
        NearestPickupSensor NearPickup;
        MicrobeBasePickup pickup;

        public override void Enter(Agent agent)
        {

            magent = (Microbe)agent;
            agent.Log("Looking for a pickup");
            NearPickup = magent.GetComponent<NearestPickupSensor>(); 
            pickup = (MicrobeBasePickup)NearPickup.Sense(); //sense the nearest pickup
        }
        
        public override void Execute(Agent agent)
        {
            if (pickup != null) //if the pickup still exists
            {
                
                magent.SetPickup(pickup); //sets the target to the pickup
                magent.Move(pickup.transform.position, Steering.Behaviour.Seek); //move towards the pickup
                if(magent.HasPickup)magent.SetState<MicrobeRoamingState>(); //go to roaming state when pickup is taken
            }               
            
        }
        
        public override void Exit(Agent agent)
        {
            
        }
    }
}