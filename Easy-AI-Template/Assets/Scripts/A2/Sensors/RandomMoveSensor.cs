using System.Collections;
using System.Collections.Generic;
using A2.Pickups;
using System.Linq;
using UnityEngine;



namespace A2.Sensors
{
    
    [DisallowMultipleComponent]
    public class RandomMoveSensor : EasyAI.Sensor
    {
        float x, y, z;

        public override object Sense()
        {

            x = Random.Range(-20, 20);
            z = Random.Range(-20, 20);

            Vector3 pos = new Vector3(x, 0, z);

            return pos;


        }
    }
}
