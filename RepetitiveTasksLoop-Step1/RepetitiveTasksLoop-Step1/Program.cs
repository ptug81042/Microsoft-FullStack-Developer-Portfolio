// Step 1: Using a For Loop to Calculate Total Scores
// Instructions:
// Define an array named scores containing the integers 85, 90, 78, 92, and 88.
int[] scores = { 85, 90, 78, 92, 88 };

// Use a for loop to iterate over each element in the array and calculate the total score.
int totalScore = 0;
for (int i = 0; i < scores.Length; i++)
{
    totalScore += scores[i];
}

// Print the total score using Console.WriteLine().
Console.WriteLine("Total Score: " + totalScore);