// See https://aka.ms/new-console-template for more information

/*

In Reverse Polish Notation (RPN), you organise a math equation by postfixing the operator, 
such that you always find two values and an operand. 
This practically make any equation free of parentheses, and easy to perform.

In a Reverse Polish notation, you would examine content one by one, 
if you encounter a value, you push it on a stack. If you encounter an operand, 
you pop the two latest values and perform the operation with the values, 
and push back the result. Once you reach the ‘=‘ equality sign, the final value popped is the result.

e.g.
    5. 3  +  =
    10  5  -  2 *  =

Write a small program to read from the command line and perform the math. 
Use a stack to perform the actions, but store each value or operand in a queue. 
Once you encounter the ‘=‘ equality sign, write out the original expression 
(from the queue) and the result (from the stack).

There will be some error cases to handle, such as:
    Missing value
    Missing operand
    Ambiguities result (more data on the stack)
 

Try to make the program as resilient as possible

Use any internet resource you need to answer the questions, that may arise throughout
*/



namespace Reverse_Polish_Notation;

class Program
{
    public static void Main(string[] args)
    {
        
        
        
        
        
    }
}