using UnityEngine;
using EasyAI;
using A1;
using System.Linq;
using System;

namespace A1
{
    public class DirtSensor : Sensor
    {

        //Senses the tiles that are dirty      
        public override object Sense()
        {
           //Gets all objects of type floor and checks if it is dirty
            Floor[] tiles = FindObjectsOfType<Floor>().Where(f => f.IsDirty == true).ToArray();

            //Checks if the tiles array is empty, if it is, returns null else sorts the array in terms of distance and returns the closest tile
            return tiles.Length == 0 ? null : tiles.OrderBy(f => Vector3.Distance(f.transform.position, Agent.transform.position)).First();

        }
    }
}
