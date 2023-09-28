namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1. Ədədlərdən ibarət arrayın elementleri cemini tapan alqoritm
            Console.WriteLine("\n \n Task1");

            int[] numbers = { 3,532,31,1,132,2, 3,132, 4, 5,13,1321,312,123,132,123,13,123,13132,231,231,6, 7, 8, 9, 10 };
            int sum=0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"sum: {sum}");
            #endregion

            #region Task2
            //2. Sozlerden ibaret arrayde uzunlugu 4-den boyuk olan sozleri ekrana çap edin
            Console.WriteLine("\n \n Task2");

            string[] names = { "Asiman", "Sebuhi", "Nigar", "Zulfiyye", "Anar", "Zaur" };
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length>4)
                {
                    Console.WriteLine(names[i]);
                }
            }
            #endregion

            #region Task3
            //3. N uzunluqlu massivin elementlərini azalan sıra ilə düzün
            //yuxaridaki arraydan istifade edirem
            Console.WriteLine("\n \n Task3");
            for (int i = 0; i < numbers.Length-1; i++)
            {
                
                    for (int j = 1; j < numbers.Length-i; j++)
                    {
                        if (numbers[j] < numbers[j - 1])
                        {
                            numbers[j] += numbers[j - 1];
                            numbers[j- 1] = numbers[j] - numbers[j- 1];
                            numbers[j] -= numbers[j-1];
                        }
                    
                }


            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            #endregion
            #region DimensionalArray

            Console.WriteLine("\n \n optional");
            int[,] ints = { {2,3,4,5,6,11 },{ 1,2,6,8,9,10} };
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.WriteLine(ints[i, j]);
                }
               
            }
            #endregion
        }
    }
}