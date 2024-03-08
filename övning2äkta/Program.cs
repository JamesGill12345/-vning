
//punkt 1

string[] leksaker = { "Lego", "Docka", "leksaksbil" };

foreach (string lekssak in leksaker)
{
    Console.WriteLine(leksaker);
}

//punkt 2

string[] klasskamrater = { "hampus", "neo", "oliver", "hector", "yuriy" };

// punkt 3

int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };


//punkt 4



for (int i = 0; i < klasskamrater.Length; i++)
{
    int r1 = Random.Shared.Next(0, 5);
    int r2 = Random.Shared.Next(0, 10);

    Console.WriteLine($"{klasskamrater[i]} ger {klasskamrater[i]} {numbers[i]} i betyg");
}

// punkt 5

List<string> cities = new List<string>();

// punkt 6
bool run;
run = true;
while(run = true)
{
    Console.WriteLine("Skriv något");
    string input = Console.ReadLine();
    cities.Add(input);
    if (input == "exit")
    {
        run = false;
    }
}

// punkt 7

Console.WriteLine(cities);

