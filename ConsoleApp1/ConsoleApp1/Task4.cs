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
                                break;
                            case  '1':
                                count++;
                                break;
                            case '2':
                                count++;
                                break;
                            case '3':
                                count++;
                                break;
                            case '4' :
                                count++;
                                break;
                            case '5' :
                                count++;
                                break;
                            case '6':
                                count++;
                                break;
                            case '7':
                                count++;
                                break;
                            case '8':
                                count++;
                                break;
                            case '9':
                                count++;
                                break;

                     }
                    
                  
                }
                    


            }
            Console.WriteLine(count);
            
        }
        
    }
}
