using UnityEngine;

namespace EasyAI.Navigation.Generators
{
    /// <summary>
    /// Convex corner graph placement for nodes.
    /// </summary>
    public class CornerGraphGenerator : NodeGenerator
    {
        [SerializeField]
        [Min(0)]
        [Tooltip("How far away from corners should the nodes be placed.")]
        private int cornerNodeSteps = 3;
    
        /// <summary>
        /// Place nodes at convex corners.
        /// </summary>
        public override void Generate()
        {
            //40 nodes, 236 connections, 1560 lookups

            //calc nodes per step(scans that need to be free from a corner)
                //4 nodes per step with 3 corner node steps

            //to loop through all spaces:
                //NodeArea.RangeX and NodeArea.RangeZ
                //double for loop

            //check to see if space is open:
                //NodeArea.IsOpen(int x, int z)


            //Place node: NodeArea.Place(int x, int y)

            

            // TODO - Assignment 4 - Complete corner-graph node generation.
        }
    }
}