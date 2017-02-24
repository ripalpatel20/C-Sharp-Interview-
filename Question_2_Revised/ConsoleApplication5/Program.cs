using System;
using System.Collections.Generic;


namespace Question_2_Revised
{
    enum Color { WHITE, GRAY, BLACK };

    class Program
    {

        static void Main(string[] args)
        {

            int[] vertices = new[] { 1, 2, 3, 4 };

            Tuple<int, int>[] edges = new[] { Tuple.Create(1, 2), Tuple.Create(1, 4), Tuple.Create(2, 3), Tuple.Create(4, 1) };
            var graph = new Graph<int>(vertices, edges);

            Algorithms obj = new Algorithms();
            List<int> path = new List<int>();

            Console.WriteLine(string.Join(", ", obj.DFS(graph, 1, v => path.Add(v))));
            bool t = Program.isCyclic(vertices);
            //Console.WriteLine(t);

            if (Program.isCyclic(vertices))
                Console.WriteLine("Graph doesn't contains cycle");
            else
                Console.WriteLine("Graph  contains cycle");
        }

        private static unsafe bool isCyclic(int[] vertices)
        {
            // Initialize color of all vertices as WHITE
            //forloop
            //    color[i] = Color.WHITE;

            // Do a DFS traversal beginning with all vertices
            //for (int i = 0; i < V; i++)
            //    if (color[i] == Convert.ToInt32(Color.WHITE))
            //        if (DFSUtil(i, color) == true)
            //            return true;


            return false;
        }

        private static unsafe bool DFSUtil(int u, int* color)
        {
            ////// GRAY :  This vertex is being processed 
            ////color[u] = Convert.ToInt32(Color.GRAY);
            ////Tuple<int, int>[] edges = new[] { Tuple.Create(1, 2), Tuple.Create(1, 4), Tuple.Create(2, 3), Tuple.Create(4, 1) };
            ////// Iterate through all adjacent vertices
            ////foreach (var edge in edges)
            ////{
            ////    for (int i = edge.Item1; i != edge.Item2; ++i)
            ////    {
                   

            ////        // If there is
            ////        if (color[i] == Convert.ToInt32(Color.GRAY))
            ////            return true;

            ////        // If v is not processed and there is a back
            ////        // edge in subtree rooted with v
            ////        if (color[i] == Convert.ToInt32(Color.WHITE) && DFSUtil(i, color))
            ////            return true;
            ////    }

            //}



            //color[u] = Convert.ToInt32(Color.BLACK);
            return false;
        }
    }
}
