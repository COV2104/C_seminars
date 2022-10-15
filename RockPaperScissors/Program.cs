// Игра: камень , ножницы , бумага.
// камень бьет ножницы
// ножницы режут бумагу
// бумага оборачивает камнь

Console.WriteLine("Сделайте выбор: 1 - камень, 2 - ножницы, 3 - бумага"); // (1 - камень, 2 - ножницы, 3 - бумага)
Console.Write("Введите: ");

int user = Convert.ToInt32(Console.ReadLine());
int computerRandom = new Random().Next(1, 4);

string computerChoice = "";
if (computerRandom == 1)
    computerChoice = "камень";
else if (computerRandom == 2)
    computerChoice = "ножницы";
else if (computerRandom == 3)
    computerChoice = "бумага";

string userChoice = "";
if (user == 1)
    userChoice = "камень";
else if (user == 2)
    userChoice = "ножницы";
else if (user == 3)
    userChoice = "бумага";
else
    Console.WriteLine("Введите число от 1 до 3");
    
Console.WriteLine();
Console.WriteLine($"Ваш выбор: {userChoice}\nВыбор компьютера: {computerChoice}\n");

if (userChoice == computerChoice)
    Console.WriteLine("Ничья");
else if (userChoice == "камень" && computerChoice == "ножницы")
    Console.WriteLine("Вы победили!!! Камень бьет ножницы.\n");
else if (userChoice == "камень" && computerChoice == "бумага")
    Console.WriteLine("Вы проиграли. Бумага оборачивает камень.\n");
else if (userChoice == "ножницы" && computerChoice == "камень")
    Console.WriteLine("Вы проиграли. Камень бьет ножницы.\n");
else if (userChoice == "ножницы" && computerChoice == "бумага")
    Console.WriteLine("Вы победили!!! Ножницы режут бумагу .\n");
else if (userChoice == "бумага" && computerChoice == "камень")
    Console.WriteLine("Вы победили!!! Бумага оборачивает камень.\n");
else if (userChoice == "бумага" && computerChoice == "ножницы")
    Console.WriteLine("Вы проиграли. Ножницы режут бумагу .\n");
