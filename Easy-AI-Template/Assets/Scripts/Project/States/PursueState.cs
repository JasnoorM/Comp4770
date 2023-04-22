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
        Soldier.EnemyMemory target;
        public override void Enter(Agent agent)
        {
            
            SolAgent = (Soldier)agent;
            NavMeshAgent navAgent = SolAgent.GetComponent<NavMeshAgent>();
        }
        public override void Execute(Agent agent)
        {
                target = SolAgent.DetectedEnemies.OrderBy(e => e.Distance).FirstOrDefault();
                NavMeshAgent navAgent = SolAgent.GetComponent<NavMeshAgent>();
                Collider collider = SolAgent.GetComponent<Collider>();
                

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


                        
                        if (Vector3.Distance(SolAgent.headPosition.position, target.Position) < 2f && (SolAgent.AtkPoints > target.Enemy.AtkPoints))
                        
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
            

            private void OnTriggerEnter(Collider collider)
            {
                Debug.Log("Hello");
                target.Enemy.SwitchTeam();
                target.Enemy.AtkPoints -= 50;
                SolAgent.AtkPoints += 50;
            }
        

    }

    
}
