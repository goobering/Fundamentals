using System;

namespace Fundamentals.Objects
{
    public class DNode<T> where T:IComparable
    {
        public T Data { get; set; }
        public DNode<T> Prev { get; set; } = null;
        public DNode<T> Next { get; set; } = null;

        public DNode(T data)
        {
            Data = data;
        }
    }
}