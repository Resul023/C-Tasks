using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many number will you enter:");
            string nameSizeTool = Console.ReadLine();
            int nameSize = Convert.ToInt32(nameSizeTool);
            
            string[] names = new string[nameSize];
             
            int count = 0;
            bool check = false;
            for (int i = 0; i < nameSize; i++)
            {  
                names[i] = Console.ReadLine();
                for (int j = 0 ; j < names[i].Length; j++)
                {
                        
                    switch (names[i][j])
                     {  
                            case '0':
                                count++;
                            check = true;
                                break;
                            case  '1':
                                count++;
                            check = true;
                            break;
                            case '2':
                                count++;
                            check = true;
                            break;
                            case '3':
                                count++;
                            check = true;
                            break;
                            case '4' :
                                count++;
                            check = true;
                            break;
                            case '5' :
                                count++;
                            check = true;
                            break;
                            case '6':
                                count++;
                            check = true;
                            break;
                            case '7':
                                count++;
                            check = true;
                            break;
                            case '8':
                                count++;
                            check = true;
                            break;
                            case '9':
                                count++;
                            check = true;
                            break;

                     }

                    if (check) 
                    {
                        check = false;
                        break;
                    }
                }
                    


            }
            Console.WriteLine(count);
            
        }
        
    }
}
