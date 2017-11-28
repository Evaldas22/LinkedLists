using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Node
    {
        public int Data;
        public Node next;

        public Node(int data)
        {
            Data = data;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + Data + "->");
            if (next != null)
            {
                next.Print(); // recursion here
                // first node is going to tell: hey, second node, call print on yourself
                // second -> hey, third, call print on yourself
                // and so on
            }
        }

        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.Data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }

        public void AddToEnd(int data)
        {
            if(next == null) // if it's the last node
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
    }

    class MyList
    {
        public Node head;

        public MyList()
        {
            head = null;
        }

        public void AddSorted(int data)
        {
            if (head == null)
            {
                head  = new Node(data);
            }
            else if (data < head.Data)
            {
                AddToBeginning(data);
            }
            else
            {
                head.AddSorted(data);
            }
        }

        public void AddToEnd(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                head.AddToEnd(data);
            }
        }

        public void AddToBeginning(int data)
        {
            if (head == null)   
            {
                head = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = head;
                head = temp;
            }
        }

        public void Print()
        {
            if (head != null)
            {
                head.Print();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Node head = new Node(1);
            //head.next = new Node(2);
            //head.next.next = new Node(3);
            //head.next.next.next = new Node(4);

            //head.Print();
            //----------When added "AddToEnd", "Print" methods to Node class---------
            //Node head = new Node(1);
            //head.AddToEnd(2);
            //head.AddToEnd(3);
            //head.AddToEnd(4);

            //head.Print();

            //--------Created new class "LinkedList"---------
            //MyList list = new MyList();
            //list.AddToEnd(1);
            //list.AddToEnd(2);
            //list.AddToEnd(3);
            //list.AddToEnd(4);
            //list.AddToBeginning(999);

            //list.Print();

            MyList newList = new MyList();
            newList.AddSorted(5);
            newList.AddSorted(9);
            newList.AddSorted(1);
            newList.AddSorted(50);

            newList.Print();
        }
    }
}
