using System;

namespace _18Mart
{
    class Program
    {
        static void Main(string[] args)
        {

             string numberSizeTool = Console.ReadLine();
             int numberSize = Convert.ToInt32(numberSizeTool);
             int[] array = new int[numberSize];
             for (int i = 0; i < array.Length; i++)
             {
                 array[i] = Convert.ToInt32(Console.ReadLine());

             }
             int numb;
             numberAdd(ref array, out numb);
             for (int i = 0; i < array.Length; i++)
             {
                 Console.WriteLine(array[i]);
             }          //TASK1

            /*int number = Convert.ToInt32(Console.ReadLine());
            numberKok(ref number);
            Console.WriteLine(number);*/ //TASK3

            /*string name = Console.ReadLine();
            string check = deleteSpace(ref name);
            Console.WriteLine(check); //TASK2
*/

        }

        static string deleteSpace(ref string name) 
            { 
                string nameNew = " ";
                int count = 0;
              for (int i = 0; i < name.Length; i++)
              {
                 if (name[i] != ' ')
                 {
                    nameNew += name[i];
                    
                 }
              } return nameNew; //TASK2
            }






        static int[] numberAdd(ref int[] array, out int numb)
        {
            numb = 3;
            
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count ++;
            }
            int[] arrayNew = new int[count+1];

            for (int i = 0; i < array.Length-1; i++)
            {
                arrayNew[i] = array[i];
                
            }
            arrayNew[arrayNew.Length-1] = numb;

            array = arrayNew;
            return array; //TASK1
        }


        static void numberKok(ref int number)
        {
            int numberOne = 0;
            for (int i = 2; i < number; i = i * i)
            {
                numberOne = i;

            }
            number = numberOne; //TASK3

        }



      


        






    }
}
        
    
