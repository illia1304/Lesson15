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

        }
    }
}
