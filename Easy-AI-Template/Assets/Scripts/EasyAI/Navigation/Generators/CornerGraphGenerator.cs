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

            for (int i = 0; i < NodeArea.RangeX; i++) //goes through all ranges of x
            {

                for (int j = 0; j < NodeArea.RangeZ; j++) //goes through all ranges of z
                {
                    if (NodeArea.IsOpen(i,j)) 
                    {
                        //checking for corners
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
                            //add node
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



            // TODO - Assignment 4 - Complete corner-graph node generation.
        }
    }
}