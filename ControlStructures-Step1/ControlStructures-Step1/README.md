# Step 1: If-Else Statement for Ticket Pricing
You are developing a program for a travel company to determine the ticket price based on the passenger's age. The company offers discounted prices for children and seniors. The rules are: <br>
* Children (under 12) pay half price.
* Adults (12 to 65) pay full price.
* Seniors (over 65) get a 20% discount.

Write a program using an if-else statement to determine which price a passenger will pay. <br>
Steps: <br>
1. Declare a variable int age to store the passenger’s age.
2. Prompt the user to enter their age using Console.WriteLine and capture the input using Console.ReadLine().
3. Use int.Parse() to convert the input string into an integer and store it in the age variable.
4. Write an if-else statement to determine the ticket price:
   * If age < 12, print "Half price ticket."
   * If age is between 12 and 65, print "Full price ticket."
   * Otherwise, print "Senior discount ticket."
