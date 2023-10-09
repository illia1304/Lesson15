namespace Lesson15
{
    public class Stack<T>
    {
        public Stack() { }

        public List<T> stack = new List<T>();
        public void Push(T item)
        {
            stack.Add(item);
        }
        public void Pop()
        {
            int lastElement = stack.Count - 1;
            stack.RemoveAt(lastElement);
        }

        public void Clear()
        {
            stack.Clear();
        }


        public int Count()
        {
            return stack.Count;
        }
        public T Peek()
        {
            return stack[stack.Count - 1];
        }
        public T CopyToArr(T[] array, int i)
        {
            foreach (T item in stack)
            {
                array[i] = item;
                i++;
            }
            return array[stack.Count - 1];
        }

    }
    class Programme
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (var item in stack.stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("/////////////////////////");
            stack.Pop();
            stack.Pop();
            foreach (var item in stack.stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("/////////////////////////");
            Console.WriteLine(stack.Peek());

            Console.WriteLine("/////////////////////////");
            Console.WriteLine(stack.Count());

            Console.WriteLine("/////////////////////////");
            int[] array = new int[stack.Count()];
            stack.CopyToArr(array, 0);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
