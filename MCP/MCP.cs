using System;
using System.Collections.Generic;
using System.Linq;

class MCP
{
    static void Main(string[] args)
    {
        Console.WriteLine("MCP\n");

        int n = int.Parse(Console.ReadLine());
        int[][] points = new int[n][];

        for (int i = 0, j = 0; i < n; i++, j = 0)
        {
            string s = Console.ReadLine();
            points[i] = new int[2];
            foreach (string str in s.Split(" "))
            {
                points[i][j] = int.Parse(str);
                j++;
            }
        }

        // first step find the leftmost point

        for (int i = 1; i < n; i++)
        {
            if (points[0][0] > points[i][0])
            {
                int[] temp = new int[2];
                Array.Copy(points[0], temp, 2);
                points[0] = points[i];
                points[i] = temp;
            }
        }

        // second step sort by left right relative to the zero point by using insertion sort

        for (int i = 2; i < n; i++)
        {
            int j = i;
            while (j > 1 && Rotate(points[0], points[j - 1], points[j]) < 0)
            {
                int[] temp = new int[2];
                Array.Copy(points[j], temp, 2);
                points[j] = points[j - 1];
                points[j - 1] = temp;
                j -= 1;
            }
        }

        // last step 

        List<int[]> result = new List<int[]>();
        result.Add(points[0]);
        result.Add(points[1]);

        for (int i = 2; i < n; i++)
        {
            int len = result.Count();
            while (Rotate(result[len - 2], result[len - 1], points[i]) < 0)
            {
                result.RemoveAt(len - 1);
                len -= 1;
            }
            result.Add(points[i]);
        }
         
        foreach (int[] i in result)
        {
            Console.WriteLine(String.Format("x = {0}; y = {1}", i[0], i[1]));

        }
    }

    
    private static double Rotate(int[] A, int[] B, int[] C)
    {
        // z > 0 left else right
        return ((B[0] - A[0]) * (C[1] - B[1])) - ((B[1] - A[1]) * (C[0] - B[0]));
    }

}

