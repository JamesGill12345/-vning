class GPU : Hardware
{
    public string name;
    public int Price;

    public int Gbammountofvram = 6;
    static string GetGPUname(string name)
    {
        name = "GPU";
        return name;
    }
        static string GetGPUPrice(int Price)
    {
        Price = 4000;
        string PriceString = Price.ToString();
        return PriceString;
    }
    static string GetGPUVRAM(int Gbammountofvram)
    {
        Gbammountofvram = 6;
        string GbammountofvramString = Gbammountofvram.ToString();
        return GbammountofvramString;
    }

}