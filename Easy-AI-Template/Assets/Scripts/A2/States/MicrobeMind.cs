using EasyAI;
using UnityEngine;

namespace A2.States
{
    /// <summary>
    /// The global state which microbes are always in.
    /// </summary>
    [CreateAssetMenu(menuName = "A2/States/Microbe Mind", fileName = "Microbe Mind")]
    public class MicrobeMind : State
    {

        public override void Execute(Agent agent)
        {



            Microbe magent = (Microbe)agent;
            magent.SetState<MicrobeRoamingState>();
            
             
        }
    }
}