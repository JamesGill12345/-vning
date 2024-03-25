//punkt 1

using System.Xml.Serialization;

Book b1 = new Book();
Book b2 = new Book();
Book b3 = new Book();



static int GetWeight(int weight)
{
    return weight;
}


// punkt 6

Console.WriteLine("Skriv ett nummer för att bestämma hur många stenar som ska finnas");
string rockcounter_string = Console.ReadLine();
int rockcounter;
int.TryParse(rockcounter_string, out rockcounter);

// Rock r1 = new Rock(5);

Rock[] rocks = new Rock[rockcounter];



for (int i = 0; i < rockcounter; i++)
{
    Console.WriteLine($"ange hur mycket vikt sten nummer {i} ska ha");
    string rocknumweightstring = Console.ReadLine();
    int rocknumweightint;
    int.TryParse(rocknumweightstring, out rocknumweightint);

    rocks[i] = new Rock(rocknumweightint);
}

// bool exit = false;
// while(exit == false)
// {   
//     int Loopcount;
//     Loopcount = 1;
//     Loopcount ++;
//     string Input;
//     Input = Console.ReadLine();
//     if (Input == "exit")
//     {
//         exit = true;

//          while (Input != "exit")
//         {
//         Rock rock = new Rock(GetWeight);
//         }
//     }

//     int [] arrayrocks = new int[Loopcount];
//     List<string> RockList = new List<string> (Rock.weight);


// }



Worker w1 = new Worker();
Worker w2 = new WhiteCollar();
Worker w3 = new BlueCollar();


Console.WriteLine("Vilken typ av hårdvara vill du skapa, skriv 1 för cpu, 2 för gpu");
string input = Console.ReadLine();
if (input == "1")
{
    CPU CPU = new CPU();
    Console.WriteLine(CPU.name);
    Console.WriteLine(CPU.Price);
    Console.WriteLine(CPU.NumberofCores);

}
else if (input == "2")
{
    GPU GPU = new GPU();
    Console.WriteLine(GPU.name);
    Console.WriteLine(GPU.Price);
    Console.WriteLine(GPU.Gbammountofvram);
}
else
{
    Console.WriteLine("Fel");
}