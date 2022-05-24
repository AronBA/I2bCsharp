/*
class Program
{
    static void Main(string[] args)
    {
        string postText = Console.ReadLine();
        Post post = new Post();
        post.Text = postText;
        post.ShowPost();
    }
}

class Post
{
    private string text;
    //hier einen Konstruktor schreiben   

    public Post()
    {
        Console.WriteLine("Neuer Beitrag");
    }

    public string Text
    {
        get => text;
        set => text = value ?? throw new ArgumentNullException(nameof(value));
    }
    public void ShowPost()
    {
        Console.WriteLine(text);
    }
    //eine Eigenschaft für Mitgliedstext schreiben
}
*/