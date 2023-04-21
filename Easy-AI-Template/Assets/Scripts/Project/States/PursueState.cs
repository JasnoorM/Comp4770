using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAI;
using UnityEngine.AI;
using System.Linq;


namespace Project.States
{
    public class PursueState : State
    {
        Soldier SolAgent;
        NavMeshAgent navAgent;
        public override void Enter(Agent agent)
        {
            
            SolAgent = (Soldier)agent;
        }
        public override void Execute(Agent agent)
        {

            NavMeshAgent navAgent = SolAgent.GetComponent<NavMeshAgent>();

            if (SolAgent != null)
            {
                Soldier.EnemyMemory target = SolAgent.DetectedEnemies.OrderBy(e => e.Distance).FirstOrDefault();

                if (target != null)
                {
                    if (target.Enemy.isQueen || target.Enemy.AtkPoints > SolAgent.AtkPoints)
                    {
                        
                        SolAgent.NavMeshMove(-target.Position, navAgent);

                    }
                    else if (SolAgent.DetectedEnemies == null)
                    {
                        
                        SolAgent.SetState<PickupState>();
                    }
                    else
                    {
                        //navAgent.SetDestination(target.Position);
                        //SolAgent.NavMeshMove(target.Position, navAgent);
                        //Debug.Log(Enemy.transform.position);


                        
                        if (Vector3.Distance(SolAgent.headPosition.position, target.Position) < 20f && (SolAgent.AtkPoints > target.Enemy.AtkPoints))
                        {
                            
                            target.Enemy.SwitchTeam();
                            target.Enemy.AtkPoints -= 50;
                            SolAgent.AtkPoints += 50;
                        }
                        else
                        {

                            SolAgent.SwitchTeam();
                            target.Enemy.AtkPoints += 50;
                            SolAgent.AtkPoints -= 50;
                        }
                    }
                }
                
            }
            

            
        }

    }
}
