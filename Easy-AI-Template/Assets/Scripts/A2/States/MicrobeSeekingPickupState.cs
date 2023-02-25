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
            pickup = (MicrobeBasePickup)NearPickup.Sense();
        }
        
        public override void Execute(Agent agent)
        {
            if (pickup != null)
            {
                magent.SetPickup(pickup);
                magent.Move(pickup.transform.position, Steering.Behaviour.Seek);
                if(magent.HasPickup)magent.SetState<MicrobeRoamingState>();
            }               
            
        }
        
        public override void Exit(Agent agent)
        {
            
        }
    }
}