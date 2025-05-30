// Step 4: Combining Loops with Switch Statements for Task Scheduling
// Instructions:
// Define an array named weekDays contain the strings "Monday", "Tuesday", "Wednesday", "Thursday", "Friday".
string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

// Use a for loop to iterate over each element in the array.
// Inside the loop, use a switch statement to assign a task to each day:
// If it's "Monday", print "Team Meeting."
// If it's "Tuesday", print "Code Review."
// If it's "Wednesday", print "Development."
// If it's "Thursday", print "Testing."
// If it's "Friday", print "Deployment."
for (int i = 0; i < weekDays.Length; i++)
{
    switch (weekDays[i])
    {
        case "Monday":
            Console.WriteLine("Monday: Team Meeting.");
            break;
        case "Tuesday":
            Console.WriteLine("Tuesday: Code Review.");
            break;
        case "Wednesday":
            Console.WriteLine("Wednesday: Development.");
            break;
        case "Thursday":
            Console.WriteLine("Thursday: Testing.");
            break;
        case "Friday":
            Console.WriteLine("Friday: Deployment.");
            break;
    }
}