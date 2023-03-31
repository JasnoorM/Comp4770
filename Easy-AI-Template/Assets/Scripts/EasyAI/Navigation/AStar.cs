﻿using System.Collections.Generic;
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
            foreach (Connection i in connections)
            {
                node = new AStarNode(i.A, goal);
            }
            /*AStarNode node = new AStarNode();
            float i = node.CostF;*/


            //look at AStarNode
            //assign lookup table to manager
            //Navigate agent to position of node

            //open node

            if (current == goal)
            {
                Debug.Log("Reached Goal");
            }else
            {
               

            }


            // TODO - Assignment 4 - Implement A* pathfinding.
            return new();
        }
    }
}