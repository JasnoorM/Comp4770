using EasyAI;
using UnityEngine;
using System;

namespace A1.States
{
    /// <summary>
    /// The global state which the cleaner is always in.
    /// </summary>
    [CreateAssetMenu(menuName = "A1/States/Cleaner Mind", fileName = "Cleaner Mind")]
    public class CleanerMind : State
    {
        public override void Execute(Agent agent)
        {
            // TODO - Assignment 1 - Complete the mind of this agent along with any sensors and actuators you need.
            
            DirtSensor sensor = agent.gameObject.AddComponent<DirtSensor>();
            Floor tile = (Floor)sensor.Sense();

            agent.transform.Translate(tile.transform.position *2 * Time.deltaTime);
            tile.Clean();
   

        }
    }
}