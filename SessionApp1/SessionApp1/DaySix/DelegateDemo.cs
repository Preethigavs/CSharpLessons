public delegate void MethodHandlerA(); //parameterless void
public delegate int MethodHandlerB(int x, int y); //parameterized and return empty
public class MathCalculator
{
    public void DoTask()
    {
        Console.WriteLine("calculator DoTask");
    }
    public int Add(int x, int y)
    {
        Console.WriteLine(x + " ," + y);
        return x + y;
    }
    public int Sub(int x, int y)
    {
        Console.WriteLine(x + " ," + y);
        return x - y;
    }
    public int Mul(int x, int y)
    {
        Console.WriteLine(x + " ," + y);
        return x * y;
    }
    public int Div(int x, int y)
    {
        Console.WriteLine(x + " ," + y);
        return x / y;
    }
    public String GetMode()
    {
        return "X500";
    }
}
public class DelegateDemo
{
    public static void TestOne() // single cast delegate
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerA methodHandlerA = mc.DoTask; //new MethodHandlerA(mc.DoTask); // both can be used 
        MethodHandlerB methodHandlerB = mc.Add;  //new MethodHandlerB(mc.Add);
        MethodHandlerB methodHanderTwoB = mc.Mul;  // new MethodHandlerB(mc.Mul);
        // MethodHandlerB methodHandlerTwo = new MethodHandlerB(mc.Divide);
        methodHandlerA();
        int addResult = methodHandlerB(100, 50);
        Console.WriteLine(addResult);
        int MultiplyResult = methodHandlerB(20, 5);
        Console.WriteLine(MultiplyResult);

    }
    public static void TestTwo() // mulitcast delegates
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerB methodHandlerB = mc.Add;
        methodHandlerB += mc.Mul;
        methodHandlerB(100, 50);
    }
}