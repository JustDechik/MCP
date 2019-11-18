using System;

class MCP
{
    static void Main(string[] args)
    {
        Console.WriteLine("MCP\n");


    }

    
    private static double Rotate(int[] A, int[] B, int[] C)
    {
        // z > 0 left else right
        return ((B[0] - A[0]) * (C[1] - B[1])) - ((B[1] - A[1]) * (C[0] - B[0]));
    }
}

