class Book
{
    private string name;
    private int pages;
    private int currentPage = 0;


    public Book()
    {
        name = "bok1";
        pages = 100;
    }
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
}

