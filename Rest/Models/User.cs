namespace Rest.Models;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public ReadingList? ReadingList { get; set; }
}