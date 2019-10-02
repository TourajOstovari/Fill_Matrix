using System;
namespace Fill_Matrix_NoReptative_
{
    using System.Collections.Generic;

    internal class Program
    {
        public static int possible_patterns_count = 1;

        private static void Main(string[] args)
        {
            
            Rep_Matrix Rep_Matrixs = new Rep_Matrix();

            Console.Title = "Developed by Mr. Touraj Ostovari :) 2019";
            Console.Write("Hi, welcome to my practive project that University Gave Me, It is a project for filling matrix\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Our numbers are: \n\t0 - 1 - 2 - 3 - 4 - 5 - 6 - 7 - 8");
            Console.WriteLine("Our Matrix: \n\t3 × 3 = 9, Our aiming numbers and matrix counts are same so for calculating\npossible patterns of this matrix while none of numbers should not repeat anymore is n!");
            for (byte i = 1; i <= 9; i++)
            {
                possible_patterns_count *= i;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nAll of possible patterns count is::\t{0}", possible_patterns_count.ToString());

            int Counter = 1;
            System.Collections.Generic.List<int> rep_temp = new List<int>();
            while (Counter != possible_patterns_count)
            {
                byte[] buffer_ = new byte[9];
                Random rand = new Random();
                for (int i = 0; i < 9; )
                {
                    int temp_numbers = (byte)rand.Next(0, 9);

                    if (!rep_temp.Contains(temp_numbers)) { 
                    rep_temp.Add((byte)temp_numbers);
                    buffer_[i] = (byte)temp_numbers;
                        i++;
                    }
                }
                rep_temp.Clear();
                if (Rep_Matrixs.Contains_(buffer_) == false) {
                    Rep_Matrixs.set_buffer(buffer_);
                    Counter +=1;
                    Console.WriteLine("\nONE NEW PATTERN OF MATRIX FOUND!!! \n");
                    int temp_counter = 0;
                    for (int satrha = 0; satrha < 3; satrha++)
                    {
                        for (int sotonha = 0; sotonha < 3; sotonha++)
                        {
                            Console.Write("{0}\t", buffer_[temp_counter]);
                            temp_counter += 1;
                        }
                        Console.Write("\n");
                    }
                    byte[] buffer_clean = new byte[9];
                    Rep_Matrixs.set_buffer(buffer_clean);
                    }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPattern number:\t{0}", Counter);
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(300);
            }
            Console.ReadKey();
        }
    }
    public class Rep_Matrix
    {
        public List<Array> arrays = new List<Array>();
        public bool Contains_ (byte[] buffered_)
        {
            if (arrays.Contains(buffered_)) return true;
            else return false;
        }
        public void set_buffer(byte[] buffered_)
        {
            arrays.Add(buffered_);
        }
    }
}
