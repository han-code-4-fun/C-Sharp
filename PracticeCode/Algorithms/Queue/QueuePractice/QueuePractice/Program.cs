using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QueuePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstTest
            //MyQueue myQueue = new MyQueue(5);
            //myQueue.Enqueue(100);
            //myQueue.Enqueue(10);
            //myQueue.Enqueue(20);
            //myQueue.Enqueue(30);
            //myQueue.Display();

            //WriteLine($"Front of queue is {myQueue.Peek()} ");

            //WriteLine("About to remove item from queue");
            //myQueue.Dequeue();
            //WriteLine($"Front of queue is {myQueue.Peek()} ");
            #endregion

            #region Test.NetQueue
            Queue<string> movies = new Queue<string>();
            movies.Enqueue("Ace Ventura");
            movies.Enqueue("Batman");
            movies.Enqueue("Cable Guy");
            movies.Enqueue("Dallas Buyers Club");
            movies.Enqueue("East of Eden");

            WriteLine("Default content of Queue");

            foreach (string movie in movies)
            {
                WriteLine(movie);
            }

            WriteLine("\nDequeuing '{0}'", movies.Dequeue());
            WriteLine("The next item to dequeue using peek: {0}",
                movies.Peek());
            WriteLine("Dequeuing '{0}'", movies.Dequeue());

            Queue<string> queueCopy = new Queue<string>(movies.ToArray());

            WriteLine("\nContents of the first copy:");
            foreach (string movie in queueCopy)
            {
                WriteLine(movie);
            }

            string[] array2 = new string[movies.Count * 2];
            movies.CopyTo(array2, movies.Count);

            Queue<string> queueCopy2 = new Queue<string>(array2);

            WriteLine("\nContents of the second copy, with duplicates and" +
                      " nulls:");
            foreach (string movie in queueCopy2)
            {
                WriteLine(movie);
            }

            WriteLine("\nqueueCopy.Contains(\"Dallas Buyers Club\") = {0}",
                queueCopy.Contains("Dallas Buyers Club"));

            //Console.WriteLine(queueCopy[-1]);

            WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);

            #endregion
            Console.ReadLine();
        }

        public class MyQueue
        {
            int currentPointerPosition = 0;
            int maxSize = 0;
            int startPosition = 0;

            private int[] myStringQueue;

            public MyQueue(int maxSize)
            {
                this.maxSize = maxSize;
                myStringQueue = new int[maxSize];
                

            }


            public void Enqueue(int inputString)//add to the end
            {
                if (IsFull())
                {
                    WriteLine($"The queue is full, {inputString} cannot be added");
                   
                }
                else
                {
                    myStringQueue[currentPointerPosition] = inputString;
                    currentPointerPosition++;
                    if(currentPointerPosition == maxSize - 1)//Queue is full
                    {
                        WriteLine("Please note that queue is full");
                    }
                    
                }
            }

            public int Dequeue()//remove position[0] element
            {
                if (IsEmpty())
                {
                    Console.WriteLine("The queue is empty, you cannot delete anymore");
                    return 0;
                }
                else
                {
                    int positionToBeReturned = startPosition;
                    startPosition++; 
                    if(startPosition == maxSize)//when all values has been dequeued
                    {
                        startPosition = 0;
                    }
                    return myStringQueue[positionToBeReturned];

                }
            }

            public int Peek()//get value of first element
            {
                return myStringQueue[startPosition];
            }

            public void Display()
            {
                
                int count = new int();
                count = startPosition;
               while(count < maxSize)
                {
                    Console.WriteLine(myStringQueue[count]);
                    count++;
                }
            }

            public bool IsFull()
            {


                return (currentPointerPosition >= (maxSize -1));
            }

            public bool IsEmpty()
            {
                return (currentPointerPosition == -1);
            }

        }
    }
}
