using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructureLIB
{
    public class LinkedList<T> : System.Collections.Generic.ICollection<T>
    {

        /// <summary>
        /// Get the count - No of elements/ nodes present in the linked list
        /// </summary>
        public int Count 
        {
            get;
            private set;
        }

        public bool IsReadOnly 
        {
            get { return false; }
        }

        private LinkedListNode<T> head { get; set; }
        private LinkedListNode<T> tail { get; set; }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }



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

            if (Count == 1) // if the list was empty then head and taid should be the same 
            {
                tail = head;
            }
        }


        #endregion


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

    public class LinkedListNode<T> 
    {
        public LinkedListNode(T Value)
        {
            Value = Value;

        }
        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }


    }



}
