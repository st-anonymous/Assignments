using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyStack : ICloneable
    {
        private int[] Array;
        private int Val;
        private int Size;
        private int Index;

        public MyStack(int size)
        {
            Size = size;
            Array = new int[Size];
            Index = 0;
        }

        public MyStack CloneStack()
        {
            MyStack stack = new MyStack(this.Size);
            for (int i = 0; i < Index; i++)
            {
                stack.Push(this.Array[i]);
            }
            return stack;
        }

        public void Push(int num)
        {
            if (Index < Size)
            {
                Array[Index++] = num;
                Val = Array[Index - 1];
            }
            else throw new StackException("\n\tStack OverFlow.");
        }

        public void Pop()
        {
            if (Index > 0)
            {
                Index--;
                if(Index > 0) Val = Array[Index - 1];
            }
            else throw new StackException("\n\tStack UnderFlow.");
        }

        public int Peek()
        {
            if(Index > 0)
            {
                return Val;
            }
            else throw new StackException("\n\tEmpty Stack");
        }
        public void Show()
        {
            if (Index > 0)
            {
                Console.Write("\n\t");
                for(int i=0; i<Index; i++)
                {
                    Console.Write(this.Array[i] + " ");
                }
                Console.WriteLine();
            }
            else throw new StackException("\n\tEmpty Stack");
        }
    }
}
