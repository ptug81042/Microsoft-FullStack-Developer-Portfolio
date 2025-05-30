// Step 2: Using a While Loop to Calculate Factorials
// Instructions:
// Declare an integer variable number and sets its value to 5.
int number = 5;
int factorial = 1;

// Use a while loop to calculate the factorial of the number.
//After each iteration, decrement the value of number.
while (number > 0)
{
    factorial *= number;
    number--;
}

// Print the factorial using Console.WriteLine().
Console.WriteLine("Factorial: " + factorial);