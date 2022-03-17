using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string numberTool = Console.ReadLine();
             int number = Convert.ToInt32(numberTool);
             int qaliq = 0;
             int sum = 0;
             int result = qaliqTapma(number, qaliq, sum);
              Console.WriteLine( result);  //Task3*/

            /*string numberTool = Console.ReadLine();
            int number = Convert.ToInt32(numberTool);
            int resultNumber = 0;
            int result = kokTapma(number, resultNumber);
            Console.WriteLine(result);*/  //TASK2

            /*string word = Console.ReadLine();

            int result = indexFind(word, 'a');
            Console.WriteLine(result);*/ //TASK1


            /*Console.WriteLine("Enter your array size:");
            string numberSizeTool = Console.ReadLine();
            int numberSize = Convert.ToInt32(numberSizeTool);
            int[] number =new int [numberSize] ;
            
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = findBigNumber(number,number[0] );
            Console.WriteLine(result);*/ //TASK4

          /*  Console.WriteLine("Enter your array size:");
            string numberSizeTool = Console.ReadLine();
            int numberSize = Convert.ToInt32(numberSizeTool);
            int[] number = new int[numberSize];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = changePositiveNumber(number);
                for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }   */ //TASK5
        }
        //METODLAR

        static int[] changePositiveNumber(int[] array) 
        {
            
            for (int i = 0; i < array.Length ; i++)
            {
                if (array[i]<0)
                {
                    array[i] = -array[i];
                      
                }
            } return array; //TASK5
            
        }



        static int findBigNumber(int[] array, int max)
        {
            max = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]> max)
                    {
                         max = array[i];
                         return max;
                    }
                
                }   return max; //Task4
            
        }

        static int indexFind(string word, char findTool)
        {

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == findTool)
                {
                    return i;
                }

            }
            return -1; //Task1



            static int kokTapma(int number, int resultNumber)
            {
                for (int i = 1; i * i <= number; i++)
                {
                    resultNumber = i;

                }
                return resultNumber; //Task2
            }



            static int qaliqTapma(int number, int qaliq, int sum)
            {
                while (number >= 1)
                {
                    qaliq = number % 10;
                    sum += qaliq;
                    number = number / 10;

                }
                return sum; //Task3
            }

        }
    }
}
