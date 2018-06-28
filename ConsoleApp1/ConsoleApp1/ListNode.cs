using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyList
    {
        public ListNode<int> headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new ListNode<int>(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }
    }

    public class ListNode<T>
    {
        public T value { get; set; }
        public ListNode<T> next { get; set; }

        public ListNode(T i)
        {
            value = i;
            next = null;
        }

        public ListNode()
        {
        }


        public void Print()
        {
            Console.Write("|" + value + "|->");
            if (next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(T data)
        {
            if (next == null)
            {
                next = new ListNode<T>(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
    }
}
