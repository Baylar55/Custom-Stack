using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomStack
{
    class MyStack<T> : IEnumerable
    {

        public int Count { get; set; }
        private int Capacity { get; set; }
        private T[] arr;
        
        public IEnumerator GetEnumerator()
        {
            for (int i = Count-1; i >= 0; i--)
            {
                yield return arr[i];
            }
        }
        

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
        private int index = -1;
        

        public MyStack(int capacity)
        {
            Capacity = capacity;
            arr = new T[capacity];
        }
        

        public void Push(T element)
        {
            if (Count < Capacity)
            {
                Array.Resize(ref arr, Capacity);
                index++;
                arr[index] = element;
                
            }
            else if (Count > Capacity || Count == Capacity)
            {
                Capacity = Capacity * 2;
                Array.Resize(ref arr, Capacity);
                index++; 
                arr[index] = element;
            }
            Count++;
        }
        

        public T Peek()
        {
            return arr[index];
        }
        

        public T Pop()
        {
          
            T element = arr[index];
             arr[index] = default(T); 
            --Count;
            return element;
        }
    }

}
