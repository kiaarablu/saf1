using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saf_1
{
     
    internal class Program
    {
        int[] safarray;
        int front=0;
        int rear=0;
        int arraysize;

        static void Main(string[] args)
        {
        }
        public bool isfull()
        {
            if (safarray.Length >= rear)
            {
                Console.WriteLine("array is full");
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool isempty()
        {
            if (safarray.Length <= front)
            {
                Console.WriteLine("array is empty");
               return false;
            }
            else
            {
                return true;
            }

        }
        public void Enqueue(int Number)
        {
            if (!isfull())
            {
                 safarray[rear] = Number;
                 rear++;
            }
            else
            {
                Console.WriteLine("array is full");
            }
                
        }
        public int Dequeue()
        {
            if (!isempty())
            {
                int res = safarray[front];
                for (int i = 0; i < safarray.Length; i++)
                {
                    safarray[i] = safarray[i + 1];
                }
                rear--;
                return res;
            }
           return -1;
        }
        public void showarray()
        {
            if (!isempty())
            {
                for (int i =front;i<rear ; i++)
                {
                    Console.WriteLine(safarray[i]);
                }
            }

        }
    }
}
