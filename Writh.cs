using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wirth_Problem_15._12
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> m = new HashSet<int>();
            HashSet<int> mBuffer = new HashSet<int>();

            mBuffer.Add(1);
            mBuffer.Add(3);
            mBuffer.Add(4);
            mBuffer.Add(7);
            mBuffer.Add(9);
            mBuffer.Add(10);
            
            int num_seq_found = m.Count;
            int iterations = 1;

            while (num_seq_found < 100)
            {
                bool needToClear = true;
                foreach (int seq_num in mBuffer.ToList())
                {
                    bool shouldPrint = false;
                    if (needToClear) { needToClear = false; mBuffer = new HashSet<int>(); }
                    int y = 2 * seq_num + 1;
                    int z = 3 * seq_num + 1;
                    if (m.Add(y)) 
                    { 
                        shouldPrint = true; 
                        mBuffer.Add(y); 
                        num_seq_found++; 
                        if (num_seq_found >= 100) { break; } 
                    }
                    if (m.Add(z)) 
                    { 
                        shouldPrint = true; 
                        mBuffer.Add(z); 
                        num_seq_found++; 
                        if (num_seq_found >= 100) { break; } 
                    }
                    if (shouldPrint) { Console.WriteLine(seq_num); }
                    iterations++;
                }                
            }

            int[] wirth_set = m.OrderBy(a => a).ToArray();

            Console.WriteLine(wirth_set);

            Console.ReadKey();
        }
    }
}
