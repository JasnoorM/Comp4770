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
        /// 

        
        
        public override void Generate()
        {
            
            int check = 0;

            for (int i = 0; i < NodeArea.RangeX; i++)
            {

                for (int j = 0; j < NodeArea.RangeZ; j++)
                {
                    if (NodeArea.IsOpen(i,j))
                    {
                        if (!NodeArea.IsOpen(i - 1, j - 1)) check++;
                        if (!NodeArea.IsOpen(i - 1, j)) check++;
                        if (!NodeArea.IsOpen(i, j - 1)) check++;
                        if (!NodeArea.IsOpen(i + 1, j + 1)) check++;
                        if (!NodeArea.IsOpen(i, j + 1)) check++;
                        if (!NodeArea.IsOpen(i + 1, j)) check++;
                        if (!NodeArea.IsOpen(i - 1, j + 1)) check++;
                        if (!NodeArea.IsOpen(i + 1, j - 1)) check++;
                        Debug.Log(check);
                        if (check == 1)
                        {
                            if(NodeArea.IsOpen(i + cornerNodeSteps, j + cornerNodeSteps)) NodeArea.AddNode(i + cornerNodeSteps, j + cornerNodeSteps);
                            if (NodeArea.IsOpen(i - cornerNodeSteps, j - cornerNodeSteps))NodeArea.AddNode(i - cornerNodeSteps, j - cornerNodeSteps);
                        }
                        /*else if(check == 3)
                        {
                            if (NodeArea.IsOpen(i + 4, j + 4)) NodeArea.AddNode(i + 4, j + 4);
                            if (NodeArea.IsOpen(i - 4, j - 4)) NodeArea.AddNode(i - 4, j - 4);
                        }*/
                        check = 0;
                    }

                    
                }
                

            }


            //40 nodes, 236 connections, 1560 lookups

            //calc nodes per step(scans that need to be free from a corner)
            //4 nodes per step with 3 corner node steps

            //to loop through all spaces:
            //NodeArea.RangeX and NodeArea.RangeZ
            //double loop

            //check to see if space is open:
            //NodeArea.IsOpen(int x, int z)


            //Place node: NodeArea.Place(int x, int y)



            // TODO - Assignment 4 - Complete corner-graph node generation.
        }
    }
}