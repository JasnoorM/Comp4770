using EasyAI;
using Project.Pickups;
using UnityEngine;

namespace Project.Sensors
{
    /// <summary>
    /// Sensor to sense the nearest ammo pickup to a soldier.
    /// </summary>
    [DisallowMultipleComponent]
    public class NearestAmmoPickupSensor : Sensor
    {
        /// <summary>
        /// Sense the nearest ammo pickup to a soldier.
        /// </summary>
        /// <returns>The nearest available ammo pickup, prioritizing the soldier's weapon priority, or null if no pickups available.</returns>
        public override object Sense()
        {
            if (Agent is not Soldier soldier)
            {
                return null;
            }
            
            // Store the chosen ammo pickup to move to.
            HealthAmmoPickup selected = null;
            HealthAmmoPickup pickup = null;
            
            
            if(soldier.isLosing)
            {
                pickup = SoldierManager.NearestAmmoPickup(soldier, Random.Range(0, 1));
            }
            else
            {
                pickup = SoldierManager.NearestAmmoPickup(soldier, 2);
                
            }
            

            // Set the chosen pickup.
            selected = pickup;                      

            return selected;
        }
    }
}