using System;

class MCP
{
    static void Main(string[] args)
    {
        Console.WriteLine("MCP\n");

        int n = int.Parse(Console.ReadLine());
        int[,] points = new int[n, 2];

        for (int i = 0, j = 0; i < n; i++, j = 0)
        {
            string s = Console.ReadLine();
            foreach(string str in s.Split(" "))
            {
                points[i,j] = int.Parse(str);
                j++;
            }
        }
    }

    
    private static double Rotate(int[] A, int[] B, int[] C)
    {
        // z > 0 left else right
        return ((B[0] - A[0]) * (C[1] - B[1])) - ((B[1] - A[1]) * (C[0] - B[0]));
    }
}

