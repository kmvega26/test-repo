// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

while(true) {
OptionMenu();
string userInput = ReceiveUserInput();
UserOptions(userInput);

    if(userInput == "3"){ // Will break the while loop if user selcts option 3 (to exit program)
        break;
    }

}

static void OptionMenu()
{
    Console.Clear();
    Console.WriteLine("1. Convert the units of measure\n2. Display the rock classification\n3. Exit");
}

static string ReceiveUserInput()
{

    return Console.ReadLine();
}


static void UserOptions(string userInput)
{

    switch (userInput)
    {
        case "1": // If user wants to convert units
            ConvertUnitsMenu();
            break;
        case "2": // If user wants to receive rock classification score
            RockClassification();
            break;
        case "3": // If user wants to exit the program
            ExitProgram();
            break;
        default:
            Console.WriteLine("Invalid Selection");
            break;
    }
}

static void ConvertUnitsMenu()
{
    bool returnToMainMenu = false;

    while(returnToMainMenu == false) {
        Console.WriteLine("Please select which unit type you would like to convert: ");
        Console.WriteLine("1. Length\n2. Mass\n3. Temperature\n4. Return back to main menu");
        string unitType = Console.ReadLine();

        switch (unitType)
        {
            case "1": // If user wants to convert length measurements
                LengthConversion();
                break;
            case "2": // If user wants to convert mass measurements
                MassConversion();
                break;
            case "3": // If user wants to convert temperature measurements
                TemperatureConversion();
                break;
            case "4": // If user wants to return to main menu
                returnToMainMenu = true;
                break;
            default:
                Console.WriteLine("Invalid Selection");
                break;
        }

    }
    
}

static void LengthConversion()
{

    Console.WriteLine("Please select the units you are converting to and from:");
    Console.WriteLine("1. Millimeters to Inches\n2. Inches to Millimeters\n3. Centimeters to Inches\n4. Inches to Centimeters\n5. Meters to Yards\n6. Yards to Meters\n7. Kilometers to Miles\n8. Miles to Kilometers");
    Console.WriteLine("9. Millimeters to Miles\n10. Miles to Millimeters");
    string lengthConversionSelection = Console.ReadLine();

    Console.WriteLine("Please enter the amount: ");
    double userAmount = Convert.ToDouble(Console.ReadLine());

    double lengthResult = 0;

    switch (lengthConversionSelection)
    {
        case "1": // Millimeters to Inches
            lengthResult = userAmount * 0.03937;
            break;
        case "2": // Inches to Millimeters
            lengthResult = userAmount / 0.03937;
            break;
        case "3": // Centimeters to Inches
            lengthResult = userAmount * 0.3937;
            break;
        case "4": // Inches to Centimeters
            lengthResult = userAmount / 0.3937;
            break;
        case "5": // Meters to Yards
            lengthResult = userAmount * 1.0936;
            break;
        case "6": // Yards to Meters 
            lengthResult = userAmount / 1.0936;
            break;
        case "7": // Kilometers to Miles
            lengthResult = userAmount * 0.6214;
            break;
        case "8": // Miles to Kilometers 
            lengthResult = userAmount / 0.6214;
            break;
        case "9": // EXTRA: Millimeters to Miles
            lengthResult = userAmount * 6.2137e-7;
            break;
        case "10": // EXTRA: Miles to Millimeters
            lengthResult = userAmount * 1_609_344;
            break;
        default:
            Console.WriteLine("Invalid Selection");
            break;
    }

    Console.WriteLine($"Converted amount: {lengthResult}");

}
static void MassConversion()
{

    Console.WriteLine("Please select the units you are converting to and from: ");
    Console.WriteLine("1. Grams to Ounces\n2. Ounces to Grams\n3. Kilograms to Pounds\n4. Pounds to Kilograms");
    Console.WriteLine("5. Grams to Pounds\n6. Pounds to Grams\n7. Grams to Kilograms\n8. Kilograms to Grams\n9. Ounces to Pounds");
    Console.WriteLine("10. Pounds to Ounces\n11. Ounces to Kilograms\n12. Kilograms to Ounces");
    string massConversionSelection = Console.ReadLine();

    Console.WriteLine("Please enter the amount: ");
    double userAmount = Convert.ToDouble(Console.ReadLine());

    double massResult = 0;

    switch (massConversionSelection)
    {
        case "1": // Grams to Ounces
            massResult = userAmount * 0.0353;
            break;
        case "2": // Ounces to Grams
            massResult = userAmount / 0.0353;
            break;
        case "3": // Kilograms to Pounds
            massResult = userAmount * 2.2046;
            break;
        case "4": // Pounds to Kilograms
            massResult = userAmount / 2.2046;
            break;
        case "5": // EXTRA: Grams to Pounds
            massResult = userAmount * 0.00220462;
            break;
        case "6": // EXTRA: Pounds to Grams
            massResult = userAmount / 0.00220462;
            break;
        case "7": // EXTRA: Grams to Kilograms
            massResult = userAmount * 0.001;
            break;
        case "8": // EXTRA: Kilograms to Grams
            massResult = userAmount / 0.001;
            break;
        case "9": // EXTRA: Ounces to Pounds
            massResult = userAmount * 0.0625; 
            break;
        case "10": // EXTRA: Pounds to Ounces
            massResult = userAmount / 0.0625;
            break;
        case "11": // EXTRA: Ounces to Kilograms
            massResult = userAmount * 0.0283495;
            break;
        case "12": // EXTRA: Kilograms to Ounces
            massResult = userAmount / 0.0283495;
            break;
        default:
            Console.WriteLine("Invalid Selection");
            break;

    }

    Console.WriteLine($"Converted amount: {massResult}");

}

static void TemperatureConversion()
{

    Console.WriteLine("Please select the units you are converting to and from: ");
    Console.WriteLine("1. Celsius to Farenheit\n2. Farenheit to Celsius");
    string temperatureConversionSelection = Console.ReadLine();

    Console.WriteLine("Please enter the amount: ");
    double userAmount = Convert.ToDouble(Console.ReadLine());

    double temperatureResult = 0;

    switch (temperatureConversionSelection)
    {
        case "1": // Celsius to Farenheit 
            temperatureResult = (userAmount * 1.8) + 32;
            break;
        case "2": // Farenheit to Celsius 
            temperatureResult = (userAmount - 32) / 1.8;
            break;
        default:
            Console.WriteLine("Invalid Selection");
            break;
    }
    Console.WriteLine($"Converted amount: {temperatureResult}");

}

static void RockClassification()
{
    Console.WriteLine("Please enter the number of identical rock samples: ");
    int numberOfRockSamples = Convert.ToInt32(Console.ReadLine());

    double totalPoints = numberOfRockSamples * 4.5;
    double totalWeight = 0;
    double totalBuffAmount = 0;


    Console.WriteLine("Do you need to the rocks to be transported?: Yes or No");
    string transportDecision = Console.ReadLine();

    if (transportDecision == "Yes") // Adding 7.3 points if rocks need to be transported
    {
        totalPoints = totalPoints + 7.3;
    }

    Console.WriteLine("Please enter the surface temperature of the space rock samples in celsius: ");
    double spaceRockTemperature = Convert.ToDouble(Console.ReadLine());

    if (spaceRockTemperature <= 0) // Adding 9.2 points if space rock's temperature is less than 0 degrees celsius
    {
        totalPoints = totalPoints + 9.2;
    }

    Console.WriteLine("Please enter the weight of the rock samples in kilograms: ");
    double weightOfRockSamples = Convert.ToDouble(Console.ReadLine());

    totalWeight = totalWeight + weightOfRockSamples;

    if (totalWeight > 25) // Adding 17% increase to total points if total weight is greater than 25 kilograms 
    {
        totalPoints = totalPoints + (totalPoints * .17);
    }
    Console.WriteLine($"The total points collected by the rock classification system is: {totalPoints}");

    Console.WriteLine("Would you like to increase or decrease the score: Yes or No");
    string buffDecision = Console.ReadLine();

    while (buffDecision == "Yes") // Determining if the user would like to buff their score 
    {
        Console.WriteLine("How much would you like to increase or decrease the score? Please enter a decrease in the score as a negative number. (Enter 0 to stop): ");
        double buffAmount = Convert.ToDouble(Console.ReadLine());

        if (buffAmount == 0) // To allow user to exit 
        {
            break;
        }
        else if (buffAmount > totalPoints) // To make sure buff amount is not greather than total points
        {
            Console.WriteLine("ERROR: Buff amount cannot be greater than the originial point value.");
        }
        else // Adding buff amount to total points and calculating total buff amount 
        {
            totalPoints = totalPoints + buffAmount;
            totalBuffAmount = totalBuffAmount + buffAmount;
        }

    }
    if (buffDecision == "Yes") // Only adding total buff amount if there is one 
    {
        Console.WriteLine($"Updated point value is {totalPoints} with an increase/decrease of {totalBuffAmount}");
    }
}

static void ExitProgram()
{

    Console.WriteLine("Exiting program, goodbye!");

}
