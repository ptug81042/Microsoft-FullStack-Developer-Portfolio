// Step 1: If-Else Statement for Ticket Pricing
// Steps:
// Declare a variable int age to store the passenger's age.
int age;

// Prompt the user to enter their age using Console.WriteLine and capture the input using Console.ReadLine().
Console.WriteLine("Enter passenger's age: ");

// Use int.Parse() to convert the input string into an integer and store it in the age variable.
age = int.Parse(Console.ReadLine());

// Write an if-else statement to determine the ticket price:
// If age < 12, print "Half price ticket."
// If age is between 12 and 65, print "Full price ticket."
// Otherwise, print "Senior discount ticket."
if (age < 12)
{
    Console.WriteLine("Half price ticket.");
}
else if (age <= 65)
{
    Console.WriteLine("Full price ticket.");
}
else
{
    Console.WriteLine("Senior discount ticket.");
}