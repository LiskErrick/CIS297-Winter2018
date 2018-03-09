using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week9
{
    public class Threads
    {
        int counter = 0;

        // you can use anything to lock, we typically use a generic object with a nice name
        // so you know that it's a lock and you shouldn't play with it
        object deadlockMeNot = new object();

        List<int> ints = new List<int>();

        string lockMe = "Lock me!";

        private Random random;

        public Threads()
        {
            random = new Random();

            for (int n = 0; n < 100000; n++)
            {
                ints.Add(random.Next(1, 100000));
            }

            //foreach ( int n in ints )
            //{
            //    Console.WriteLine(n);
            //}

            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));

            //var result = MergeSort(ints.ToArray(),0,ints.Count-1);

            dynamic hello = "Hello world!";
            
            Console.WriteLine(hello);
            hello = 42;
            Console.WriteLine(hello);

            object hi = "Hi";
            Console.WriteLine(hi);
            hi = 42;
            Console.WriteLine(hi);

            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));

            int x;
            unsafe
            {
                int* pointerToX = &x;

                *pointerToX = 3;

                pointerToX->GetType();
            }
            Console.WriteLine("x"+x);

            //foreach (int n in ints)
            //{
                //Console.WriteLine(n);
            //}

            //CountTo1000();


            // this is bad, too many threads too little CPU

            //for ( int thread = 0; thread < 1000; thread++ )
            //{
            //    new Thread(CountTo1000).Start();
            //}

            // using a threadpool is better

            //for (int thread = 0; thread < 100; thread++)
            //{
            //    ThreadPool.QueueUserWorkItem(t => CountTo1000());
            // }



            //Thread thread1 = new Thread(CountTo1000);
            //Thread thread2 = new Thread(CountTo1000);
            //thread1.Start();
            //thread2.Start();
            //CountTo1000();
            //thread1.Join();
            //long tickCount = 0;
            //while ( thread1.ThreadState != ThreadState.Stopped)
            //{
            //    tickCount++;

            //}
            //Console.WriteLine($"Done, we counted {tickCount} ticks");

            // if we don't join, Done gets printed before the thread finishes
            //thread1.Join();
            //thread2.Join();
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Done");
        }

        public List<int> sort(List<int> ints)
        {
            for (int position = 0; position < ints.Count; position++)
            {
                int smallest = ints[position];
                int smallestIndex = position;
                for (int index = position+1; index < ints.Count; index++)
                {
                    if (ints[index] < smallest)
                    {
                        smallest = ints[index];
                        smallestIndex = index;
                    }
                }
                int temp = ints[position];
                ints[position] = smallest;
                ints[smallestIndex] = temp;

            }

            return ints;

        }

        // stolen from http://cppqa.blogspot.com/2014/10/merge-sort-multithreading-in-c.html
        int[] MergeSort(int[] input, int start, int end)
        {
            if (end - start < 2)
            {
                int[] result = new int[1];
                result[0] = input[start];
                return (result);
            }

            Task<int[]> Tleft = Task<int[]>.Factory.StartNew(() => { return MergeSort(input, start, (start + end) / 2); });

            Task<int[]> Tright = Task<int[]>.Factory.StartNew(() => { return MergeSort(input, (start + end) / 2, end); });

            //Task<int[]>.WaitAll(new Task<int[]>[]{Tleft,Tright});

            int[] left = Tleft.Result;

            int[] right = Tright.Result;
            int[] Result = Task<int[]>.Factory.StartNew(() => { return Merge(left, right); }).Result;

   
           

            return Result;
        }

        int[] Merge(int[] left, int[] right)
        {
            int leftSize = left.Length, rightSize = right.Length;
            int[] result = new int[leftSize + rightSize];
            int leftIndex = 0, rightIndex = 0, resultIndex = 0;

            while (rightIndex < rightSize && leftIndex < leftSize)
            {
                result[resultIndex++] = left[leftIndex] < right[rightIndex] ? left[leftIndex++] : right[rightIndex++];
            }
            while (rightIndex < rightSize)
                result[resultIndex++] = right[rightIndex++];
            while (leftIndex < leftSize)
                result[resultIndex++] = left[leftIndex++];
            return result;
        }


        public void CountTo1000()
        {
            // add some random wait to see if thread2 gets the lock first
            //Thread.Sleep(random.Next(100, 1000));

            // this only works with reference types, try it and it won't compile
            //lock (lockMe)
            // {
            for (int i = 0; i < 1000; i++)
            {
                counter = counter + 1;
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {counter}");
            }
            // unlocks when you leave the lock block
            //}

        }

        public async void DoSomething()
        {

        }
    }


}
