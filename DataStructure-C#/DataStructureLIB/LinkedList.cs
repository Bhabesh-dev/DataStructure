using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructureLIB
{

    public class LinkedListNode<T>
    {
        public LinkedListNode(T Value)
        {
            Value = Value;

        }
        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }


    }
    public class LinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        public T Head
        {
            get { return head.Value; }
        }

        public T Tail { get { return tail.Value; } }

        #region Add



        public void AddHead(T value)
        {
            AddHead(new LinkedListNode<T>(value));
        }

        public void AddHead(LinkedListNode<T> node)
        {
            // Save the head before updating 
            LinkedListNode<T> temp = head;

            // update the head as new node;
            head = node;
            // inset the new node 
            head.Next = temp;

            Count++;

            // if the list was empty then head and taid should be the same 
            if (Count == 1)
            {
                tail = head;
            }
        }

        public void AddTail(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }

            tail = node;
            Count++;
        }

        public void AddTail(T value)
        {
            AddTail(new LinkedListNode<T>(value));
        }


        #endregion


        #region Remove
        public void RemoveFirst()
        {
            if (Count != 0)
            {

                head = head.Next;
                Count--;
                if (Count == 0)
                {
                    tail =null;
                }
            }
        }

         


        #endregion

        #region ICollectiion
        public int Count
        {
            get;
            private set;
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        public void Add(T item)
        {
            AddHead(item);
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current =head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;            
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool Remnve(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current=head;

            //use case
            //empty list - nothing to do
            //single node - previous is null
            //many node 
            //     1- node to remove is the first node
            //     2 - node to remove is the middle 

            while (current!= null)
            {
                if (current.Value.Equals(item))
                {

                }
                else
                {
                    RemoveFirst()
                }

            }

            return true;
        }

   



        #endregion

        /// <summary>
        /// Get the count - No of elements/ nodes present in the linked list
        /// </summary>


        private LinkedListNode<T> head { get; set; }
        private LinkedListNode<T> tail { get; set; }







        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }




}
