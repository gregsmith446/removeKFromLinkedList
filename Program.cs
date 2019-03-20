using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

// This challenge relies on the fact that this ListNode is created as such but is hidden from us.
// The Linked List has 2 getters + setters: value + next;

/*
  public class ListNode<T>
  {
    public T value { get; set; }
    public ListNode<T> next { get; set; }
  } 
 */

namespace removeKFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
        }

        public class LinkedListNode<T>
        {
            public T value { get; set; }
            public LinkedListNode<T> next { get; set; }
        }


            LinkedListNode<int> removeKFromList(LinkedListNode<int> l, int k)
            {
                // deals with/solves Case 4
                // if l = null or [], we return null as [].
                if (l == null)
                {
                    return l;
                }

                // this deals with test cases where k only occurs once in l or not at all 
                while (l.value == k)
                {
                    if (l.next == null)
                    {
                        return l.next;
                    }
                    l = l.next;
                }

                // this key part handles where k occurs multiple times in l
                // uses the keyword continue;
                LinkedListNode<int> trav = l;
                while (trav.next != null)
                {
                    if (trav.next.value == k)
                    {
                        trav.next = trav.next.next;
                        continue;
                    }
                    trav = trav.next;
                }
                return l;
            }


        }

       
    }
}
