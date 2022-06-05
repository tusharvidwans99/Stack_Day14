using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_day14
{
    public class Stack<T>
    {

        LinkedList<T> linkedList;
        
        //stack constructor is used to declare linked list

        public Stack()
        {
            this.linkedList = new LinkedList<T>();
        }


        //push method is used in stack operation to push the data of generic type
        public void Push(T data)
        {
            linkedList.AddFirst(data);
        }


        //pop method is last in first out process where the last element is popped out first and deletes the element
        public void Pop()
        {
            linkedList.RemoveFirst();
        }

        //peek method is to show to first element in the linked list, it does not delete the node from the stack memory
        public void Peek()
        {
            Console.WriteLine(linkedList.First());
        }

    }
}
