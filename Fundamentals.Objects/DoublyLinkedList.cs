using System;

namespace Fundamentals.Objects
{
    public class DoublyLinkedList<T> where T:IComparable
    {
        private DNode<T> Head { get; set; }
        public int Length { get; private set; }

        public DNode<T> GetHeadNode()
        {
            return this.Head;
        }

        public DNode<T> GetLastNode()
        {
            if(this.Head == null)
            {
                return null;
            }

            var current = this.Head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            return current;
        }

        public void AddToFront(T data)
        {
            DNode<T> newNode = new DNode<T>(data);

            if(this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                this.Head.Prev = newNode;
                newNode.Next = this.Head;
                this.Head = newNode;
            }

            this.Length++;
        }

        public void AddToEnd(T data)
        {
            var newNode = new DNode<T>(data);

            var current = this.GetLastNode();
            if(current == null)
            {
                this.Head = newNode;
            }
            else
            {
                current.Next = newNode;
                newNode.Prev = current;
            }

            this.Length++;
        }

        public void DeleteFirstNode()
        {
            if(this.Head == null)
            {
                return;
            }
            else
            {
                if(this.Head.Next == null)
                {
                    this.Head = null;
                }
                else
                {
                    this.Head.Next.Prev = null;
                    this.Head = this.Head.Next;
                }

                this.Length--;
            }
        }

        public void DeleteLastNode()
        {
            if(this.Head == null)
            {
                return;
            }

            if(this.Length == 1)
            {
                this.Head = null;
                this.Length--;
                return;
            }

            var current = this.Head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Prev.Next = null;
            current = null;
            this.Length--;
        }

        public DNode<T> Find(T data)
        {
            if(this.Head == null)
            {
                return null;
            }

            var current = this.Head;
            while(current != null)
            {
                if(current.Data.CompareTo(data) == 0)
                {
                    return current;
                }
                current = current.Next;    
            }

            return null;
        }
    }
}