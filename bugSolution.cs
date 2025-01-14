public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Explicitly initialize the property

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now this will print 0 consistently
        MyProperty = 10;
    }
}