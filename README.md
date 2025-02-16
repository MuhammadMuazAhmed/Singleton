# Singleton Design Pattern in C#

This repository contains a simple implementation of the Singleton design pattern in C#. The Singleton pattern ensures that a class has only one instance and provides a global point of access to it.

## About the Code

The main class in this implementation is `President`, which follows the Singleton pattern by ensuring only one instance of the class is created. The `Directors` class is included as an example of a regular class that does not enforce a singleton instance.

### How It Works

- The `President` class has a private static variable `instance` to store the single instance.
- The constructor is `protected` to prevent direct instantiation.
- The `Instance()` method ensures that only one instance of `President` is created.
- The `Directors` class allows multiple instances.

### Code Explanation

```csharp
public class President
{
    static President? instance;
    
    // Constructor is 'protected'
    protected President()
    {
    }

    public static President Instance()
    {
        if (instance == null)
        {
            instance = new President();
        }
        return instance;
    }
}
```

- `instance` is a static variable to hold the single instance.
- `protected President()` prevents creating instances from outside.
- `Instance()` method checks if an instance exists; if not, it creates one.

### Usage

To use this Singleton implementation, follow these steps:

1. Clone the repository:
   ```sh
   git clone <repository-url>
   cd <repository-name>
   ```

2. Run the program in a C# environment:
   ```sh
   dotnet run
   ```

### Expected Output

When you run the program, you should see:

```
president are the same instance
directors are not same instance
```

This confirms that `President` follows the Singleton pattern, whereas `Directors` allows multiple instances.

---
