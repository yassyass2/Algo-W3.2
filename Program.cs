IStack<char> stk = new Solution.Stack<char>(1);
stk.Push('a');
stk.Push('b');
char[] actual = new char[4];
actual[0] = stk.Pop();
stk.Push('c');
actual[1] = stk.Pop();
actual[2] = stk.Pop();
actual[3] = stk.Pop();
Console.WriteLine();

IStack<char> stack = new Solution.Stack<char>(5);
stack.Push('a');
Console.WriteLine($"{stack.Peek()}");
stack.Push('b');
stack.Push('c');
stack.Push('c');
stack.Push('c');
stack.Push('c');


