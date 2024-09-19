namespace DataStructure
{
    internal class NumberConverter
    {

        public static int ConvertToBinary(int number)
        {
            string binaryNumber = string.Empty;
            while (number != 0)
            {
                var lastBit = number & 1;
                binaryNumber = lastBit + binaryNumber;
                number = number >> 1;
            }
            return Convert.ToInt32(binaryNumber);
        }
    }
}
