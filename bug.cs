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
        // Accessing the private variable directly from another method in the same class
        _myVariable = 10; 
    }
}