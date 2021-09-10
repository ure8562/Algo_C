using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete
{
    class Program
    {


        static void Main(string[] args)
        {
            FUNC func = new FUNC();

            string[] participant = { "A", "B", "C", "C" };
            string[] completion = { "A", "B", "C" };

            Console.WriteLine("Start Algo #1");


            Console.WriteLine("Fail : " + func.Func1(participant, completion));



        }
    }

    class FUNC
    {
        public void TEMP1()
        {
            Hashtable ht = new Hashtable();

            string[] C = { "1" };

            ht.Add(1,C[0]);

            Console.WriteLine(ht[1]);

            Console.WriteLine(C[0].GetHashCode());
            Console.WriteLine(C[0].GetHashCode());
            Console.WriteLine(C[0].GetHashCode());
        }

        public string Func1(string[] Participant, string[] completion)
        {
            Hashtable ht = new Hashtable();

            //Hashtable 등록

            foreach(string X in Participant)
            {
                if(ht.Contains(X))
                {
                    // 있음
                    ht[X] = (int)ht[X] + 1;
                }
                else 
                {
                    ht.Add(X, 1); 
                }
            }

            //찾아서 삭제
            foreach(string X in completion)
            {
                if(ht.Contains(X))
                {
                    if((int)ht[X] == 1)
                    {
                        ht.Remove(X);
                    }
                    else
                    {
                        ht[X] = (int)ht[X] - 1;
                    }
                }
                else
                {
                    Console.WriteLine("ERR : Not Exist");
                }
            }

            string Failer = string.Empty;
            
            foreach(string key in ht.Keys)
            {
                Failer = key;
            }

            return Failer;
        }
    }

}
