// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{ 
    class Test
    {
        private static void Multiplication()
        {
            Console.WriteLine(" Multiplication Tables");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}*{1}={2}", i, j, i*j);
                }
            }
        }

        private static void MultiplicationImp()
        {
            Console.WriteLine(" Multiplication Tables");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i*j%2 != 0)
                    {
                        Console.WriteLine("{0}*{1}={2}", i, j, i*j);
                    }
                }
            }
        }

        public static int test()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }


        private static void MultiplicationUser()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", i, result, i*result);
            }
            
        }

        private static void Prime()
        {
            int i, x, m=0, flag=0;    
            for(x = 1; x < 1000; x++)
            {
                m=x/2;    
                for(i = 2; i <= m; i++)    
                {
                    flag = 0;    
                    if(x % i == 0)    
                    {    
                    flag=1;    
                    break;    
                    }    
                }    
                if (flag==0)    
                Console.Write(x);
            }
        }

        private static void Fibonacci() 
        {
            int w, n;
            Console.Write("Enter number :");
            n = int.Parse(Console.ReadLine());
            if(n <= 0)
            Console.Write(n);
            if(n == 1)
            Console.Write(n);
            int u = 0;
            int v = 1;
            for(int i=2; i <= n; i++) 
            {
                w = u+v;
                u = v;
                v = w;
            }
            Console.Write(v);
        }


        public static void Factorial()
        {
            int i,fact=1,number;      
            Console.Write("Enter Number: ");      
            number= int.Parse(Console.ReadLine());     
            for(i=1;i<=number;i++)
            {      
                fact=fact*i;      
            }      
            Console.Write("Factorial of " +number+" is: "+fact);
        }


        






        private static void Rectangle()

        {
            Console.WriteLine("Program to Print Rectangle *'s");

            int width = 0, height = 0;
            int k = 0;
            string mn = "";
            string[] input;
            bool saisieok = false;

            while(!saisieok)
            {
                Console.Write("Enter M and N separated by space :");
                mn = Console.ReadLine();
                input = mn.Split(' ');
                if(input.Count() != 2)
                {
                    continue;
                }
                if ((Int32.TryParse(input[0], out height)) && (Int32.TryParse(input[1], out width)))
                {
                    saisieok = true;
                }
            } 


            //MN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)

            {

                for (int j = 1; j <= width; j++)

                {

                    if ((i == 1 || i == height) || (j == 1 || j == width))
                    {
                        if((i == 1 && j == 1) || (i == 1 && j == width) || (i == height && j == 1) || (i == height && j == width))
                            Console.Write("0");
                        else
                        {
                            if((j == 1 || j == width))
                                Console.Write("|"); //prints at border place
                            else
                                Console.Write("-"); //prints at border place
                        }
                    }
                    else
                    {
                        if(i == 2 && j == 2)
                        {
                            Console.Write("*");
                            k = 0;
                        }
                        else
                        {
                            if(k == 2)
                            {
                                Console.Write("*");
                                k = 0;

                            }
                            else
                            {
                                Console.Write(" ");
                                k += 1;
                            }

                        }
                    }

                }

                Console.WriteLine();

            }
            Console.WriteLine("press enter to quit the program");
            Console.ReadKey();

        } 

         private static void Sapin()
        {

            int i = 1;
            int j,k,m,n ;
            int l = 25;
            string s,sp,st,sb ;

            j = l-1;
            k = 1;
            Random rnd = new Random();

            for (i=1; i<=l;i+=1) {
            
                sp = string.Concat(Enumerable.Repeat(" ", j));
                //st = string.Concat(Enumerable.Repeat("*", k));
                st = "";
                for (m=1;m<=k;m+=1) {
                   n = rnd.Next(1, 4);
                   switch (n)
                   {
                       case 1:
                        {
                            st += "*";
                            break;
                        }
                       case 2:
                       {
                           st += "i";
                           break;
                       }
                       case 3:
                       {
                           st += "o";
                           break;
                       }
                   }
                }
                Console.WriteLine("{0}{1}",sp,st);
                j -= 1;
                k +=2;
            }
            sb = string.Concat(Enumerable.Repeat(" ", l-2)) + "| |";
            Console.WriteLine(sb);
        }
     

    


        static void Main(string[ ] args)
        { 
            Sapin();
        }
    }
}