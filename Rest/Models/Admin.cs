namespace Rest.Models;

public class Admin : User
{
    public int AdminId { get; set; }

    public bool IsAdmin()
    {
        return true;
    }

    public bool ManageDatabase()
    {
        return true;
    }
}