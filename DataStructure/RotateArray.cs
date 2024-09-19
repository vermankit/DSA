namespace DataStructure
{
    internal class RotateArray
    {
        public static int[] solution(int[] A, int K)
        {
            // Implement your solution here
            if (K == A.Length)
            {
                return A;
            }
            var arrToShift = A;
            while (K > 0)
            {
                arrToShift = ShiftLeft(arrToShift);
                K--;
            }
            return arrToShift;
        }

        public static int[] ShiftLeft(int[] B)
        {
            var length = B.Length;
            Console.WriteLine(length);
            var lastNumber = B[length - 1];
            for (int i = length - 1; i > 0; i--)
            {
                B[i] = B[i - 1];
            }
            B[0] = lastNumber;
            return B;
        }
    }
}
