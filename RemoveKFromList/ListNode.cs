using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveKFromList
{
   public class ListNode<T>
    {
        public T value { get; set; }
        public ListNode<T> next { get; set; }
    }


    public class LinkList<T>
    {
        public ListNode<T> head;

       public ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            ListNode<int> head = l;
            ListNode<int> prev = new ListNode<int>();
            ListNode<int> temp = head;

            /// Start with if k matches with head value
            while (temp!=null && temp.value == k)
            {
                head = temp.next;
                temp = head;
            }

            //now delete the key occurance other then head

            while (temp!=null)
            {
                while (temp!=null && temp.value!=k)
                {
                    // to keep track of prev node so we can easily go to next next node.
                    prev = temp;
                    temp = temp.next;
                }

                //now we found the occurance
                if (temp!=null)
                {
                    //unlink that node
                    prev.next = temp.next;
                    temp = prev.next;
                }

            }

            return head;
        }

        public void add(T data)
        {
            if (head == null)
            {
                head = new ListNode<T>();

                head.value = data;
                head.next = null;
            }
            else if (head.next == null)
            {
                ListNode<T> toadd = new ListNode<T>();
                toadd.value = data;

                head.next = toadd;
                toadd.next = null;
            }
            else
            {
                ListNode<T> toAdd = new ListNode<T>();
                toAdd.value = data;
                toAdd.next = null;
                ListNode<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }          
        }

        public void printAllNode()
        {
            ListNode<T> cur = head;
            while (cur != null)
            {
                Console.Write($"{cur.value}  ");
                cur = cur.next;
            }
            Console.WriteLine();
        }
    }
}
