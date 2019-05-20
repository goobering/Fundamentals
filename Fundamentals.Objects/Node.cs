using System;

namespace Fundamentals.Objects
{
    public class Node<T> where T:IComparable 
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; } = null;

        public Node(T data)
        {
            Data = data;
        }
    }
}