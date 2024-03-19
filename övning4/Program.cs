//punkt 1

using System.Xml.Serialization;

Book b1 = new Book();
Book b2 = new Book();
Book b3 = new Book();

static int Turnpage(int currentPage)
{
    currentPage++;

    return currentPage;
}
static int GetCurrentPage(int currentPage)
{
    return currentPage;
}

static string Getname(string name)
{
    return name;
}
static int Getpages(int pages)
{
    return pages;
}

static int GetWeight(int weight)
{
    return weight;
}


// punkt 6

Console.WriteLine("Skriv ett nummer för att bestämma hur många stenar som ska finnas");
string rockcounter_string = Console.ReadLine();
int rockcounter;
int.TryParse (rockcounter_string, out rockcounter);

Rock r1 = new Rock();

int [] rocks ={};


Console.WriteLine("ange hur mycket vikt en sten ska ha och skriv exit när du är klar");
bool exit = false;
while(exit == false)
{   
    int loopcount;
    loopcount = 1;
    loopcount ++;
    string input = Console.ReadLine();
    if (input == "exit")
    {
        exit = true;
    }


}
int [] arrayrocks = new int[loopcount];
List<string> stringRocks = new List<string> (arrayrocks);


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