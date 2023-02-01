using UnityEngine;
using EasyAI;
using A1;
using System.Linq;
using System;

namespace A1
{
    public class DirtSensor : Sensor
    {

              
        public override object Sense()
        {
            Console.WriteLine("State");
            Floor[] tiles = FindObjectsOfType<Floor>().Where(f => f.IsDirty == true).ToArray();
            return tiles.Length == 0 ? null : tiles.OrderBy(f => Vector3.Distance(f.transform.position, Agent.transform.position)).First();

        }
    }
}
