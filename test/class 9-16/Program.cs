// // See https://aka.ms/new-console-template for more information

// int [] grades = new int [100];
// int count = 0;
// System.Console.WriteLine("Enter grade, -1 to STOP");
// int grade = int.Parse(Console.ReadLine());
// while (grade != -1) {

//     grades[count] = grade;
//     count++;
//     System.Console.WriteLine("Enter grade, -1 to STOP");
//     grade = int.Parse(Console.ReadLine());
// }
// PrintAllGrades(grades,count);
// static void PrintAllGrades(int[] grades, int count) {

//     for(int = 0; int < count; int++) {

//         System.Console.WriteLine(grades[i]);
//     }
// }

// new code 

string [] titles = new string [100];
string [] authors = new string [100];
int count = GetAllBooks(titles, authors);
PrintAllBooks(titles, authors, count);


// end main

static void GetAllBooks(string[] titles, string[] authors){
    int count = 0;
    System.Console.WriteLine("Enter the book title, STOP to stop");
    string userInput = Console.ReadLine();
    while(userInput.ToUpper() != "STOP"){
        titles[count] = userInput;
        System.Console.WriteLine("Who wrote the book?");
        authors[count] = Console.ReadLine();
        count++;
        System.Console.WriteLine("Enter the book title, STOP to stop");
        userInput = Console.ReadLine();
    }
        return count;
}
static void PrintAllBooks(string[] titles, string[] authors, int count){

    for(int i = 0; i < count; i++){
        System.Console.WriteLine($"{titles, authors}");
    }
}
