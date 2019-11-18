using System;

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
            foreach(string str in s.Split(" "))
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
    }

    
    private static double Rotate(int[] A, int[] B, int[] C)
    {
        // z > 0 left else right
        return ((B[0] - A[0]) * (C[1] - B[1])) - ((B[1] - A[1]) * (C[0] - B[0]));
    }

    private static void Swap<T>(T[] a, T[] b)
    {
        for (int i = 0; i < 0; i++)
        {
            T temp = a[i];
            a[i] = b[i];
            b[i] = temp;
        }
    }
}

