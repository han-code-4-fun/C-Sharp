using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedNode myList = new LinkedNode();
            myList.AddToFirst(100);
            myList.AddToFirst(50);
            myList.AddToFirst(99);
            myList.AddToFirst(88);
            myList.AddToFirst(20);
            myList.AddToLast(3333);

            myList.DisplayLinkedNode();

            myList.RemoveFirst();
            myList.DisplayLinkedNode();
        }
    }

    public class LinkedNode
    {
        private Node firstNode;

        public void AddToFirst(double inputData)
        {
            Node newNode = new Node();
            newNode.AccessData = inputData;

            newNode.next = firstNode;

            firstNode = newNode;

        }

        public Node RemoveFirst()
        {
            firstNode = firstNode.next;

            return firstNode;
        }


        public void AddToLast(double inputData)
        {
            Node current = firstNode;
            //current now is a pointer of firstNode after beening referenced
            while(current.next != null)
            {
                current = current.next;
            }
            Node newNode = new Node();

            newNode.AccessData = inputData;

            current.next = newNode;

            #region Current is a pointer of firstNode
            //Console.WriteLine("+++++ See What's in the Node current  +++++");
            //Node nodeForCurrent = current;
            //while (nodeForCurrent != null)
            //{
            //    nodeForCurrent.Show();
            //    nodeForCurrent = nodeForCurrent.next;
            //}
            #endregion

        }

        public void DisplayLinkedNode()
        {
            Console.WriteLine("+++++ See the results +++++");
            Node nodeForPrint = firstNode;
            while(nodeForPrint != null)
            {
                nodeForPrint.Show();
                nodeForPrint = nodeForPrint.next;
            }
        }


    }


    public class Node
    {
        private double data;
        public Node next;

        public double AccessData
        {
            get { return data; }
            set { data = value; }
        }

        public void Show()
        {
            Console.WriteLine($"The number is {AccessData}");
        }



    }
}
