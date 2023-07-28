namespace Rest.Models;

public class ReadingList
{
    public string Name { get; set; }
    public List<LightNovel> Novels { get; set; }
}