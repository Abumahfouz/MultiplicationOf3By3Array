namespace MultiplicationOf3By3Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication of 3Dimensional arrays!");
            int[,,] threeDimArray = new int[3, 2, 3]
           {
            { { 12, 32, 12}, { 3, 14, 7 } },
            { { 16, 10, 5}, { 5, 2, 9 } },
            { { 6, 4, 9}, { 16, 5, 8 } }
           };
            int[,,] multiplier = new int[3, 2, 3]
{
            { { 24, 32, 5}, { 9, 14, 5 } },
            { { 32, 5, 10}, { 10, 4, 3 } },
            { { 12, 2, 9}, { 32, 10, 16 } }
};
            int[,,] result = new int[3, 2, 3];
            
            for (int i = 0; i < threeDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < threeDimArray.GetLength(1); j++)
                {
                    
                    for (int k = 0; k < threeDimArray.GetLength(2); k++)
                    {

                      result[i, j, k] += multiplier[i, j, k] * threeDimArray[i,j,k];
                        Console.WriteLine(result[i,j,k]);
                           
                     }
                        //dummy = threeDimArray[i, j, k];
                        //int[,] multipliedArray = new int[,];
                    
                }
            }
        }
    }
}