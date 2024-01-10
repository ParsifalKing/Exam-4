using Microsoft.VisualBasic;

namespace task_5;

public class Stack<T>
{
    public List<T> lists = new List<T>();
    public void Push(T item)
    {
        lists.Add(item);
    }
    public T Pop()
    {
        var list = lists.Last();
        return list;
        lists.Remove(list);
    }
    public T Peek()
    {
        var list = lists.Last();
        return list;
    }
}
