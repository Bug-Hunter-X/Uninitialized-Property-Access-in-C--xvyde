# Uninitialized Property Access in C#

This repository demonstrates a subtle bug in C# related to accessing properties before they've been explicitly initialized.  While not a compile-time error, it can lead to unexpected behavior and runtime issues.

## The Bug

The `bug.cs` file shows a simple class with a property that's not initialized before being accessed.  Depending on the circumstances, this might return a default value (0 for integers, null for references), but the behavior is undefined.  This can be very hard to trace in larger applications.

## The Solution

The `bugSolution.cs` file demonstrates how to explicitly initialize the property before using it, thus ensuring predictable behavior and avoiding potential issues.

## How to reproduce:

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Run the `bug.cs` example and observe the output.
4. Run the `bugSolution.cs` example and compare the output.

This example highlights the importance of careful initialization when working with properties in C# to avoid unforeseen issues. 