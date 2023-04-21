using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAI;
using UnityEngine.AI;


namespace Project.States
{
    public class PursueState : State
    {
        Soldier SolAgent;
        NavMeshAgent NavAgent;
        public override void Enter(Agent agent)
        {

            SolAgent = (Soldier)agent;
            agent.Log("Pursuing target");
            NavAgent = SolAgent.GetComponent<NavMeshAgent>();

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
                    //NavAgent.SetDestination(Enemy.headPosition.position);
                    SolAgent.Move(Enemy.headPosition.position, EasyAI.Navigation.Steering.Behaviour.Pursue);

                    if(Vector3.Distance(SolAgent.headPosition.position, Enemy.headPosition.position)< 2f && (SolAgent.AtkPoints > Enemy.AtkPoints))
                    {
                        Debug.Log(this.name + "We won");
                        Enemy.SwitchTeam();
                    }
                    else if(SolAgent.AtkPoints < Enemy.AtkPoints)
                    {
                        Debug.Log("Enemy won");
                        SolAgent.SwitchTeam();
                    }
                }
            }


            
        }

    }
}
