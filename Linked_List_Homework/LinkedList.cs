using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }
        public Node Last { get; set; }

        public void Print()
        {
            if (First == null) return;
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data + "\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
            Node temp = new Node();
            temp.Data = val;

            if (First == null)
            {
                First = temp;
                Last = temp;
                return;
            }

            Last.Next = temp;
            Last = temp;
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty

            Node currentNode = First;

            if (currentNode == null)
                return;

            if (currentNode.Data == key)
            {
                First = currentNode.Next;
            }

            while (currentNode.Next != null)
            {
                if (currentNode.Next.Data == key)
                {
                    Node temp = currentNode.Next.Next;
                    currentNode.Next = temp;
                }

                currentNode = currentNode.Next;
            }
        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list

            Node move = other_list.First;

            //merging to the end of main list

            while (move != null)
            {
                Last.Next = move;
                Last = move;

                move = move.Next;
            }
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
            if (First == null || First.Next == null)
                return;

            Node before = null;
            Node middle = First;
            Node after;

            while (middle != null)
            {

                after = middle.Next; // find the next node after me

                middle.Next = before; // then make the node after me the one before me

                before = middle; // then make the one before me to me so next time the next node will point to me

                middle = after; // then make middle point to the next node of me

            }
            First = before; // update the new First
        }
    }
}