// Step 3: Combining Loops and If-Else to Determine Pass or Fail
// Instructions:
// Define an array named studentScores containing the integers 45, 60, 72, 38, and 55.
int[] studentScores = { 45, 60, 72, 38, 55 };

// Use a for loop to iterate over each element in the array.
// Inside the loop, use an if-else statement to check if the score is 50 or above.
// Print "Pass" if the score is 50 or above; otherwise, print "Fail".
for (int i = 0; i < studentScores.Length; i++)
{
    if (studentScores[i] >= 50)
    {
        Console.WriteLine(studentScores[i] + ": Passed");
    }
    else
    {
        Console.WriteLine(studentScores[i] + ": Failed");
    }
}