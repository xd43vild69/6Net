using System;

namespace baseLib.framework;

internal delegate void TestDelegate(string name);
internal delegate void TestDelegateAux(string name);

public class Delegate
{
    public void RunManagerDelegates()
    {
        TestDelegate td = new TestDelegate(FooSingleReturnsVoid);
        TestDelegateAux tdA = new TestDelegateAux(FooSingleReturnsVoid);

        td("deletegate td:run string delegate");
        tdA("delegate tdA:run string delegate");

        td = FooSingleReturnsVoid2;
        td("delegate td:run string delegate");

        // with an anonymous function
        td = delegate (string value2) { Console.WriteLine($"call delegate anonymous {value2}"); };
        tdA = delegate (string value2) { string stdA = value2 + " "; };
        td("delegate td: anonymus function");

        // with a lambda expression
        td = name => { Console.WriteLine($"call delegate lambda {name}"); };
        td("delegate td: lamdda expresion");
    }

    public void RunFuncDelegate()
    {
        // input, input, output
        Func<int, int, string> TestFuncDelegate;

        TestFuncDelegate = SumFoo;
        Console.WriteLine($"call Func {TestFuncDelegate(2, 3)}");

        TestFuncDelegate = MulFoo;
        Console.WriteLine($"call Func {TestFuncDelegate(2, 3)}");
    }

    public void RunPredicateDelegate()
    {
        Predicate<int> predicate1;
        int number1 = 10;

        predicate1 = IsFooGreater10;

        if (!predicate1(number1)) Console.WriteLine("Call Predicate delegate");

        predicate1 = name => number1 > 10;

        if (!predicate1(number1)) Console.WriteLine("Call predicate delegate as lambda");
    }

    public void RunActionDelegate()
    {
        Action<string> TestActionDelegate = FooSingleReturnsVoid;
        TestActionDelegate("Action");
    }

    private void FooSingleReturnsVoid(string value1)
    {
        Console.WriteLine($"call delegate function {value1}");
    }

    private void FooSingleReturnsVoid2(string value1)
    {
        Console.WriteLine($"call delegate function {value1}");
    }

    private void FooVoid2(string value1, string value2)
    {
        Console.WriteLine($"call delegate function {value1}");
    }

    private string SumFoo(int number1, int number2)
    {
        return $"The sum : {number1 + number2}";
    }

    private string MulFoo(int number1, int number2)
    {
        return $"The mul : {number1 * number2}";
    }

    public bool IsFooGreater10(int number1)
    {
        return number1 > 10 ? true : false;
    }
}
