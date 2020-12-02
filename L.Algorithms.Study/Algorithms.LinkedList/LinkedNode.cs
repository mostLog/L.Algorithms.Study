using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedList
{
    public class LinkedNode<T>
    {
        public T Data { get; set; }

        public LinkedNode<T> NextNode { set; get; }

        public LinkedNode()
        {
            this.Data = default(T);
            this.NextNode = null;
        }

        public LinkedNode(T item)
        {
            this.Data = item;
            this.NextNode = null;
        }
    }
}
