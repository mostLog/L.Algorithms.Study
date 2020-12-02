using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedList
{
    public class SingleList<T>
    {
        public LinkedNode<T> Head { set; get; }

        public SingleList()
        {
            Head = null;
        }

        /// <summary>
        /// 求单链表的长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            int length = 0;
            while (Head != null)
            {
                Head = Head.NextNode;
                length++;
            }
            return length;
        }

        /// <summary>
        /// 获取节点对应的值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            LinkedNode<T> node = Head;
            if (index == 0)
            {
                return node.Data;
            }

            int i = 1;
            while (node.NextNode!=null)
            {
                if (index == i)
                {
                    return node.NextNode.Data;
                }

                i++;
            }

            return default(T);
        }

        /// <summary>
        /// 在头部之前添加
        /// </summary>
        /// <param name="item"></param>
        public void AddAtHead(T item)
        {
            LinkedNode<T> node = new LinkedNode<T>(item);
            node.NextNode = Head;
            Head = node;
        }

        /// <summary>
        /// 追加节点
        /// </summary>
        public void AddAtTail(T item)
        {
            LinkedNode<T> foot = new LinkedNode<T>(item);
            LinkedNode<T> head = new LinkedNode<T>();
            //头部为空
            if (Head == null)
            {
                Head = foot;
                return;
            }

            head = Head;
            while (head.NextNode != null)
            {
                head = head.NextNode;
            }
            head.NextNode = foot;
        }
    
        /// <summary>
        /// 插入节点
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        public void AddAtIndex(T item,int index)
        {
            int nodeLength = GetLength();
            if (index> nodeLength)
            {
                return;
            }
            //增加到头部前
            if (index <= 0)
            {
                LinkedNode<T> linkedNode = new LinkedNode<T>(item);
                linkedNode.NextNode = Head;
                Head = linkedNode;
                return;
            }

            //增加到末尾
            if (index == nodeLength)
            {
                AddAtTail(item);
            }

            LinkedNode<T> headNode = Head;
            for (int i = 1; i <= index; i++)
            {
                if (headNode.NextNode!=null)
                {
                    headNode = headNode.NextNode;
                    if (i == index)
                    {
                        LinkedNode<T> node = new LinkedNode<T>(item);
                        node.NextNode = headNode.NextNode;
                        headNode.NextNode = node;
                    }
                    else
                    {
                        headNode = headNode.NextNode;
                    }
                }
            }



        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="index"></param>
        public void Delete(int index)
        {
            LinkedNode<T> head = Head;
            if (index == 0)
            {
                LinkedNode<T> node = new LinkedNode<T>();
                node = head.NextNode;
                Head = node;
            }
            else
            {
                int i = 1;
                while (head.NextNode!=null)
                {
                    if (i==index)
                    {
                        head.NextNode = head.NextNode.NextNode;
                    }
                    else
                    {
                        head = head.NextNode;
                    }
                    
                }

                Head = head;
            }
        }

        

    }
}
