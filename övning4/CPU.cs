using System.Globalization;

class CPU : Hardware
{
    public string name;
    public int Price = 3500;
    public int NumberofCores;

    static string GetCPUname(string name)
    {
        name = "CPU";
        return name;
    }
        static string GetCPUPrice(int Price)
    {
        Price = 3000;
        string PriceString = Price.ToString();
        return PriceString;
    }
    static string GetCPUCores(int NumberofCores)
    {
        NumberofCores = 6;
        string NumberofCoresString = NumberofCores.ToString();
        return NumberofCoresString;
    }
}