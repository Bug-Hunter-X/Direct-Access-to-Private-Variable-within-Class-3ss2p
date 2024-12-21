# Direct Access to Private Variable within a C# Class

This example demonstrates a common but potentially problematic coding style in C#: directly accessing a private variable from another method within the same class.  While it works, it undermines the principles of encapsulation and can lead to maintainability issues.

The file `bug.cs` shows the code with the direct access to the private variable `_myVariable`.  The improved version, `bugSolution.cs`, uses the property `MyProperty` for both reading and writing the variable.

**Why is this a problem?**

* **Breaks encapsulation:**  Direct access bypasses any potential validation or logic you might want to include in the property's setter.
* **Makes refactoring harder:** If you later decide to add complexity to how the variable is accessed or stored (e.g., validation, caching), you have to change every instance of direct access.
* **Reduces readability:** It's clearer to read and understand the code when access to variables is through properties.

This repository serves as a small example to illustrate good coding practices in C#.