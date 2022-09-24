using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureAlgorithm
{
    internal class LinkedListGeneric<T>
    {
        internal Node<T> head;

        internal void Add(T data)   
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal int Search(T value)
        {
            Node<T> node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            Console.WriteLine("The Linked List is:");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
