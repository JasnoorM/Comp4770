using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAI;


namespace Project.States
{
    public class PursueState : State
    {
        Soldier SolAgent;
        public override void Enter(Agent agent)
        {

            
            agent.Log("Pursuing target");
            
        }
        public override void Execute(Agent agent)
        {
            base.Execute(agent);
            float distance = 1000;
            

            SolAgent = (Soldier)agent;
            Soldier Enemy = (Soldier)agent;
            
            if (SolAgent != null)
            {
                foreach(Soldier.EnemyMemory a in SolAgent.DetectedEnemies)    
                {
                    if(a.Distance < distance)
                    {
                        distance = a.Distance;
                        Enemy = a.Enemy;
                    }
                }

                if (Enemy.isQueen || Enemy.AtkPoints > SolAgent.AtkPoints)
                {
                    SolAgent.Move(Enemy.headPosition.position, EasyAI.Navigation.Steering.Behaviour.Evade);

                }
                else if (SolAgent.DetectedEnemies == null)
                {
                    SolAgent.SetState<PickupState>();
                }
                else
                {
                    SolAgent.Navigate(Enemy.headPosition.position);
                }
            }


            
        }

    }
}
