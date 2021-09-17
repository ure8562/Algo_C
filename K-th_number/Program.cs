using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_th_number
{
    class Define
    {
        public static int INDEX = 50;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            byte[] array = new byte[Define.INDEX];
            int[] Array = new int[Define.INDEX];
            int[,] command = { {2, 5, 3}, { 4, 4, 1 }, { 1, 7, 3 } };
            rand.NextBytes(array);
            for(int i = 0; i < Define.INDEX; i++)
            {
                Array[i] = (int)array[i];
            }
            FUNC func = new FUNC();
            Console.WriteLine("Start Algo #2");
            int[] list = { 1, 5, 2, 6, 3, 7, 4 };
            func.FINE_K_NUM(list, command);
            //func.QuickSoart(list, 0, list.Length - 1);
            //func.Show_Array(list);
        }
    }

    class FUNC
    {
        public object FINE_K_NUM(int[] array, int[,] command)
        {
            List<int> answer = new List<int>();
            int[] New_Array = new int[1];
            int command_Line = command.Length / 3;

            for (int i = 0; i < command_Line ; i++)
            {

                //New_Array = new int[command[i,1] - command[i,0] + 1];
                Array.Resize(ref New_Array, command[i, 1] - command[i, 0] + 1);
                Array.Copy(array, command[i,0]-1 , New_Array, 0, New_Array.Length);
                QuickSoart(New_Array, 0, New_Array.Length - 1);
                answer.Add(New_Array[command[i, 2] - 1]);
                
            }

            return answer;
        }
        public void Show_Array(int[] Array)
        {
            foreach(int X in Array)
            {
                Console.WriteLine(X);
            }

        }
        public void QuickSoart(int[] Array, int L, int R)
        {
            if(L <= R)
            {
                int pivot = Partition(Array, L, R);
                QuickSoart(Array, L, pivot - 1);
                QuickSoart(Array, pivot + 1, R);
            }

        }

        private int Partition(int[] Array, int L, int R)
        {
            int pivot = Array[L];
            int low = L+1;
            int high = R;

            while (low <= high)
            {
                while (low <= R && pivot >= Array[low])
                    low++;
                while (high >= (L + 1) && pivot <= Array[high])
                    high--;
                if (low <= high)
                {
                    int temp = Array[low];
                    Array[low] = Array[high];
                    Array[high] = temp;
                }
            }

            int temp1 = Array[L];
            Array[L] = Array[high];
            Array[high] = temp1;

            return high;
        }

    }


}

