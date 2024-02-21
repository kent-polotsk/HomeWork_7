namespace ClassLibrary3
{
    //==============Стек==============================

    public class MyFirstStack
    {
        private List<string> myStack;

        public MyFirstStack()
        {
            myStack = new List<string>();
            myStack.Capacity = 8;
        }
        public MyFirstStack(int capacity)
        {
            myStack = new List<string>();
            myStack.Capacity = capacity;
        }
        
        public void Push(string value)
        {
            if (myStack.Count < myStack.Capacity-1)
                myStack.Add(value);
            else
            {
                myStack.Capacity *= 2;
                myStack.Add(value);
            }
            Console.WriteLine($"(PUSH) В стек добавлен элемент: {value}");
            Console.Write($"В стеке находятся элементы: ");
            for (int i = myStack.Count-1 ; i >= 0; i--)
            {
                Console.Write(myStack[i] + " ");
            }
            Console.WriteLine();
        }
        
        public void PrintStack(List<string> stack1)
        {
            for (int i = stack1.Count - 1; i > 0; i--)
            {
                Console.WriteLine(stack1[i]);
            }
        }
            
        public void Pop()
        {
            if (myStack.Count == 0) Console.WriteLine("Стек пуст");
            else
            {
                Console.WriteLine("(POP) Из стека извлечен элемент: "+myStack[myStack.Count - 1]);

                myStack.RemoveAt(myStack.Count - 1);
                Console.Write($"В стеке остаются элементы: ");
                for (int i = myStack.Count - 1; i >= 0; i--)
                {
                    Console.Write(myStack[i] + " ");
                }
                Console.WriteLine();
                if (myStack.Capacity >= (myStack.Count) * 2)
                {
                    myStack.Capacity /= 2;
                }
            }
        }
          
        public bool IsEmpty()
        {
            if (myStack.Count == 0) return true;
            else return false;
        }
    }


    //==============Очередь===========================

    public class MyFirstQueue
    {
        private List<string> myQueue;

        public MyFirstQueue()
        {
            myQueue = new List<string>();
            myQueue.Capacity = 8;
        }
        public MyFirstQueue(int capacity)
        {
            myQueue = new List<string>();
            myQueue.Capacity = capacity;
        }

        public void Push(string value)
        {
            if (myQueue.Count < myQueue.Capacity-1)
                myQueue.Add(value);
            else
            {
                myQueue.Capacity *= 2;
                myQueue.Add(value);
            }
            Console.WriteLine($"(PUSH) В очередь добавлен элемент: {value}");
            Console.Write($"В очереди находятся элементы: ");
            for (int i = 0;  i < myQueue.Count ; i++)
            {
                Console.Write(myQueue[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintQueue(List<string> myQueue)
        {
            for (int i = 0; i < myQueue.Count ; i++)
            {
                Console.WriteLine(myQueue[i]);
            }
        }

        public void Pop()
        {
            if (myQueue.Count == 0) Console.WriteLine("Очередь пуста");
            else
            {
                Console.WriteLine("(POP) Из очереди извлечен элемент: " + myQueue[0]);

                myQueue.RemoveAt(0);
                Console.Write($"В стеке остаются элементы: ");
                for (int i = 0;  i < myQueue.Count ; i++)
                {
                    Console.Write(myQueue[i] + " ");
                }
                Console.WriteLine();
                if (myQueue.Capacity >= (myQueue.Count) * 2)
                {
                    myQueue.Capacity /= 2;
                }
            }
        }

        public bool IsEmpty()
        {
            if (myQueue.Count == 0) return true;
            else return false;
        }

        public int Size()
        {
            return myQueue.Count;
        }
    }
}
