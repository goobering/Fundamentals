using System;

namespace Fundamentals.Objects
{
    public class SinglyLinkedList<T> where T:IComparable
    {
        private Node<T> Head { get; set; } = null;
        public int Length { get; private set; } = 0;

        public void Add(T newData)
        {
            Node<T> newNode = new Node<T>(newData);

            if(this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                Node<T> current = this.Head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            this.Length++;
        }

        public void Delete(T data)
        {
            Node<T> current = this.Head;
            
            if(current != null)
            {
                if(current.Data.Equals(data))
                {
                    if(current.Next != null)
                    {
                        current = current.Next;
                    }
                    else
                    {
                        current = null;
                    }

                    this.Head = current;
                    this.Length--;
                }
                else
                {
                    while(current.Next != null && !current.Next.Data.Equals(data))
                    {
                        current = current.Next;
                    }

                    if(current.Next != null && current.Next.Data.Equals(data))
                    {
                        current.Next = current.Next.Next;
                        current = null;
                        this.Length--;
                    }
                    else
                    {
                        // Should do something other than fail silently
                        Console.WriteLine($"{data.ToString()} could not be found in the list.");
                    }
                }
            }
        }

        public Node<T> GetLastNode()
        {
            var current = this.Head;

            if(current == null)
            {
                return current;
            }

            while(current.Next != null)
            {
                current = current.Next;
            }

            return current;
        }

        public void DeleteLastNode()
        {
            if(this.Length == 0)
            {
                return;
            }
            else if(this.Length == 1)
            {
                this.Head = null;
            }
            else
            {
                var current = this.Head;
                Node<T> prev = null;

                while(current.Next != null)
                {
                    prev = current;
                    current = current.Next;
                }

                current = null;
                prev.Next = null;
            }
            
            this.Length--;
        }

        public Node<T> Find(T data)
        {
            if(this.Length == 0)
            {
                return null;
            }

            var current = this.Head;
            while(!current.Data.Equals(data))
            {
                if(current.Next == null)
                {
                    return null;
                }

                current = current.Next;
            }

            return current;
        }
    }
}