/*
Create a C# method called ModifyValue that takes three parameters:
    ref int a: a reference to an integer variable that will be modified by the method
    in int b: a read-only integer value that will be used in the method, but not modified
    out int c: an integer variable that will be set to a new value by the method and passed back to the calling code

The ModifyValue method should perform the following operations on the a, b, and c parameters:
    Add the value of b to the value of a
    Set the value of c to the result of subtracting b from a
 */

namespace Ref_In_Out;

class Program
{
    public static void Main(String[] args)
    {
        int x = 10;
        int y = 5;
        int z;
        Console.WriteLine($"Before calling ModifyValue: x={x}, y={y}");
        ModifyValue(ref x, y, out z);
        Console.WriteLine($"After calling ModifyValue: x={x}, z={z}");
    }

    private static void ModifyValue(ref int x, int y, out int z)
    {
        z = x + y;
        x = x - z;
    }
}