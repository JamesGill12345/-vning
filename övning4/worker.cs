class Worker
{
    protected string name;
    protected int age;
    protected int wage = 0;

    static string GetName(string name)
    {
        name = "bob";
        return name;
    }

     static int GetAge(int age)
    {
        age = 19;
        return age;
    }

    static int GetWage(int wage)
    {
        wage = 30000;
        return wage;
    }
}