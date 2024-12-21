public class ExampleClass
{
    private int _myVariable;

    public int MyProperty
    {
        get { return _myVariable; }
        set { _myVariable = value; }
    }

    public void MyMethod()
    {
        // Accessing the private variable through the property
        MyProperty = 10; 
    }
}