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
        public static int INDEX = 100;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            byte[] array = new byte[Define.INDEX];
            int[] Array = new int[Define.INDEX];
            rand.NextBytes(array);
            for(int i = 0; i < Define.INDEX; i++)
            {
                Array[i] = (int)array[i];
            }
            FUNC func = new FUNC();
            Console.WriteLine("Start Algo #2");
            int[] list = { 5, 2, 4, 6, 1, 7, 3 };
            func.QuickSoart(Array, 0, Array.Length - 1);

            foreach(int X in Array)
            {
                Console.WriteLine(X);
            }
        }
    }

    class FUNC
    {
        public void TEMP1(int[] Array)
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

