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


    }
    class Programme
    {
        static void Main(string[] args)
        {

        }
    }
}
