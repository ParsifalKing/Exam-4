


try
{
    var stack = new Stack<int>();

    stack.Push(1);
    stack.Push(2);

    System.Console.WriteLine(stack.Pop());
    System.Console.WriteLine("Last element deleted");

    System.Console.WriteLine(stack.Peek());
}
catch (System.Exception)
{
    System.Console.WriteLine("khato kadi ");
}

