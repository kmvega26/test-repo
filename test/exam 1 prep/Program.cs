Console.WriteLine("Please enter your animal's age: (Type -1 to STOP)");
int animalAge = Convert.ToInt32(Console.ReadLine());

int animalCount = 0;
int totalAnimalAgeSum = 0;
    while(animalAge != -1){
        totalAnimalAgeSum = totalAnimalAgeSum + animalAge;
        animalCount++;
    Console.WriteLine("Please enter your animal's age: (Type -1 to STOP)");
    animalAge = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"The count of animals is {animalCount} and the sum of the animal's ages is {totalAnimalAgeSum}");
