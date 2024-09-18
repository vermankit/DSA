namespace DataStructure
{
    internal class Complexity
    {
        public static void Sample()
        {
            // Time : BigO(1) Constant         
            // Space : O(1)
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[0]);


            // Time BigO(n) linear
            // Space : O(1)
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // Time  O(n^2) quad
            // Space O(1)
            int[,] arr2d = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    Console.WriteLine(arr2d[i, j]);
                }
            }
        }
    }
}
