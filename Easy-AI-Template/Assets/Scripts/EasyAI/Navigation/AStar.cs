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
            List<Vector3> path = new List<Vector3>();
            Vector3 minvec = new Vector3();
            
            foreach (Connection i in connections)
            {
                AStarNode nodeB;
                node = new AStarNode(i.A, goal);
                while(i.B != null)
                {                    
                    nodeB = new AStarNode(i.B, goal);
                    if(nodeB.CostF < cost)
                    {
                        cost = nodeB.CostF;
                        minvec = i.B;
                    }
                }
                path.Add(minvec);
            }

            /*Agent agent;
            agent.Navigate(goal);*/

            

            // TODO - Assignment 4 - Implement A* pathfinding.
            return path;
        }
    }
}