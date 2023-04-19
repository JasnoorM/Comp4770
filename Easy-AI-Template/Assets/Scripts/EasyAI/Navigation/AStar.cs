using System.Collections.Generic;
using EasyAI.Navigation.Nodes;
using UnityEngine;

namespace EasyAI.Navigation
{
    /// <summary>
    /// A* pathfinding.
    /// </summary>
    public static class AStar
    {
        /// <summary>
        /// Perform A* pathfinding.
        /// </summary>
        /// <param name="current">The starting position.</param>
        /// <param name="goal">The end goal position.</param>
        /// <param name="connections">All node connections in the scene.</param>
        /// <returns>The path of nodes to take to get from the starting position to the ending position.</returns>
        /// 
        

        public static List<Vector3> Perform(Vector3 current, Vector3 goal, List<Connection> connections)
        {
            
            AStarNode node;
            float cost= 200;
            List<Vector3> path = new List<Vector3>(); //shortest path
            Vector3 minvec = new Vector3();
            
            foreach (Connection i in connections) //runs to all connections
            {
                AStarNode nodeB;
                node = new AStarNode(i.A, goal);                  
                    nodeB = new AStarNode(i.B, goal);
                    if(nodeB.CostF < cost) //checks the cost 
                    {
                        cost = nodeB.CostF; //replace with previous smaller cost
                        minvec = i.B; //notes which node has lowest cost
                    }
                
                path.Add(minvec); //add to path
            }

            Manager manager = new Manager(); //navigates the agent
            manager.Agents[0].Navigate(goal);



            // TODO - Assignment 4 - Implement A* pathfinding.
            return path; //returns shortest path
        }
    }
}