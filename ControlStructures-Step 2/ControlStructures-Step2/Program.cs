// Step 2: Switch Statement for Travel Mode Selection
// Steps:
// Declare a string variable string mode to store the user's travel mode.
string mode;

// Prompt the user to select a mode using Console.WriteLine and capture the input using Console.ReadLine().
Console.WriteLine("Select a travel mode: Bus, Train, Flight:");
mode = Console.ReadLine();

// Use a switch statement to determine which message to print:
// If the user selects "Bus", print "Booking a bus ticket."
// If the user selects "Train", print "Booking a train ticket."
// If the user selects "Flight", print "Booking a flight ticket."
// Include a default case for invalid inputs with the message "Invalid selection. Please choose Bus, Train, or Flight."
switch (mode)
{
    case "Bus":
        Console.WriteLine("Booking a bus ticket.");
        break;
    case "Train":
        Console.WriteLine("Booking a train ticket.");
        break;
    case "Flight":
        Console.WriteLine("Booking a flight ticket.");
        break;
    default:
        Console.WriteLine("Invalid selection. Please choose Bus, Train, or Flight.");
        break;
}