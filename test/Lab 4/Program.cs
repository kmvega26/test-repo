// See https://aka.ms/new-console-template for more information

bool validSelection = false;
while(validSelection == false){
MenuOptions();
string userSelection = ReceiveUserSelection();
    switch (userSelection) {
        case "1":
        validSelection = true;
            PlainPizza();
            break;
        case "2":
        validSelection = true;
            CheesePizza();
            break;
        case "3":
        validSelection = true;
            PepPizza();
            break;
        case "4":
        validSelection = true;
            ExitProgram();
            break;
        default: 
        validSelection = false;
        Console.WriteLine("Invalid Selection");
            break;
    }
}


static void MenuOptions() {
    Console.WriteLine("Please select which type of pizza you would like:");
    Console.WriteLine("1. Plain pizza\n2. Cheese pizza\n3. Pepperoni pizza\n4. Exit");
}

static string ReceiveUserSelection(){
    return Console.ReadLine();
}


static void PlainPizza() {
    Random random = new Random();

    int numberOfRows = random.Next(8, 13); 

            for (int i = numberOfRows; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
}
static void CheesePizza(){
    Random random = new Random();
    int numberOfRows = random.Next(8, 13); 

        for (int i = numberOfRows; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (j == 0 || j == i -1 || i == numberOfRows)
                {
                    Console.Write("*" + " "); 
                }
                else 
                {
                    Console.Write("#" + " "); 
                }
            }
            Console.WriteLine();
        }

}

static void PepPizza(){
     Random random = new Random();
    int numberOfRows = random.Next(8, 13); 

        for (int i = numberOfRows; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (j == 0 || j == i -1 || i == numberOfRows)
                {
                    Console.Write("*" + " "); 
                }
                else 
                {
                    if(random.Next(3) == 0){ 
                        
                        Console.Write("[]" + " ");
                    }
                    else 
                    {
                        Console.Write("#" + " ");
                    }
                }
            }
            Console.WriteLine();
        }

}

static void ExitProgram(){

    Console.WriteLine("Exiting program, goodbye!");

}

