bool validSelection = true;
List<double> sales = new List<double>();
    while (validSelection)
    {
        MenuOptions();
        string userSelection = ReceiveUserSelection();
        switch (userSelection)
        {
            case "1":
                EnterGameSales(sales);
                break;
            case "2":
                AverageAmount(sales);
                break;
            case "3":
                MedianAmount(sales);
                break;
            case "4":
                validSelection = false;
                ExitProgram();
                break;
            default:
                Console.WriteLine("Invalid Selection");
                break;
            }
        }
static void MenuOptions()
{
    Console.WriteLine("Please select from the following options:");
    Console.WriteLine("1. Enter game sales\n2. Display the average amount a game is sold for\n3. Display the median amount a game is sold for\n4. Exit");
}

static string ReceiveUserSelection()
{
    return Console.ReadLine();
}

static void EnterGameSales(List<double> sales)
{
    Console.WriteLine("Enter the sale for the game (Enter -1 to go back to main menu):");
    double sale = double.Parse(Console.ReadLine());
    while (sale != -1)
    {
        sales.Add(sale);
        Console.WriteLine("Enter the sale for the game (Enter -1 to go back to main menu):");
        sale = double.Parse(Console.ReadLine());
    }
}

static void AverageAmount(List<double> sales)
{
    double average = 0;
    for (int i = 0; i < sales.Count; i++)
    {
        average += sales[i];
    }
    average = average / sales.Count;
    Console.WriteLine("The average amount a game is sold for is: " + average);
    }

static void MedianAmount(List<double> sales)
{
    List<double> sortedSales = SelectionSort(sales);
    double median = sortedSales[sortedSales.Count / 2];
    Console.WriteLine("The median amount a game is sold for is: " + median);
}

static List<double> SelectionSort(List<double> sales)
{
    for (int i = 0; i < sales.Count - 1; i++)
    {
        for (int j = i + 1; j < sales.Count; j++)
        {
            if (sales[i] > sales[j])
            {
                Swap(sales, i, j);
            }
        }
    }
        return sales;
    }

static void Swap(List<double> sales, int i, int j)
{
    double temp = sales[i];
    sales[i] = sales[j];
    sales[j] = temp;
}

static void ExitProgram()
{
    Console.WriteLine("Exiting the program. Goodbye!");
}






//  List<double> sales = new List<double>();
//  bool validSelection = true;

//         while (validSelection)
//         {
//             MenuOptions();
//             string userSelection = ReceiveUserSelection();

//             switch (userSelection)
//             {
//                 case "1":
//                     EnterGameSales(sales); 
//                     break;
//                 case "2":
//                     AverageAmount(sales);
//                     break;
//                 case "3":
//                     MedianAmount(sales);
//                     break;
//                 case "4":
//                     validSelection = false;
//                     ExitProgram();
//                     break;
//                 default:
//                     Console.WriteLine("Invalid Selection");
//                     break;
//             }
//         }
    
//     static void MenuOptions()
//     {
//         Console.WriteLine("Please select from the following options:");
//         Console.WriteLine("1. Enter game sales\n2. Display the average amount a game is sold for\n3. Display the median amount a game is sold for\n4. Exit");
//     }

//     static string ReceiveUserSelection()
//     {
//         return Console.ReadLine();
//     }

//     static void EnterGameSales(List<double> sales)
//     {
//         while (true)
//         {
//             Console.WriteLine("Please enter game sale: (Enter STOP to return to main menu)");
//             string userInput = Console.ReadLine();

//             if (userInput.ToUpper() == "STOP")
//             {
//                 break;
//             }

//             if (double.TryParse(userInput, out double sale) && sale >= 0)
//             {
//                 sales.Add(sale); 
//                 Console.WriteLine($"The sale of {sale} was added.");
//             }
//             else
//             {
//                 Console.WriteLine("Please enter a valid positive number.");
//             }
//         }
//     }

//     static void AverageAmount(List<double> sales)
//     {
//         if (sales.Count == 0)
//         {
//             Console.WriteLine("No data available.");
//         }
//         else
//         {
//             double average = sales.Average(); 
//             Console.WriteLine($"The average amount a game is sold for is: {average}");
//         }
//     }

//     static void MedianAmount(List<double> sales)
//     {
//         if (sales.Count == 0)
//         {
//             Console.WriteLine("No data available.");
//             return;
//         }

//         SelectionSort(sales);

//         double medianOfSales;
//         int size = sales.Count;

//         if (size % 2 == 0)
//         {
//             medianOfSales = (sales[size / 2 - 1] + sales[size / 2]) / 2;
//         }
//         else
//         {
//             medianOfSales = sales[size / 2];
//         }

//         Console.WriteLine($"The median amount a game is sold for is: {medianOfSales}");
//     }

//     static void SelectionSort(List<double> sales)
//     {
//         for (int i = 0; i < sales.Count - 1; i++)
//         {
//             for (int j = i + 1; j < sales.Count; j++)
//             {
//                 if (sales[i] > sales[j])
//                 {
//                     Swap(sales, i, j);
//                 }
//             }
//         }
//     }

//     static void Swap(List<double> sales, int i, int j)
//     {
//         double temp = sales[i];
//         sales[i] = sales[j];
//         sales[j] = temp;
//     }

//     static void ExitProgram()
//     {
//         Console.WriteLine("Exiting the program. Goodbye!");
//     }

