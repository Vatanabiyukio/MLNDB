using Rest.Models;

namespace Rest.Repositories;

public interface ILightNovelDAO
{
    public LightNovel AddNovel(LightNovel novelData);
    public LightNovel UpdateNovel(int id, LightNovel novelData);
    public bool DeleteNovel(int id);
    public List<LightNovel> GetAllNovels();
    public LightNovel GetNovelById(int id);
    public List<LightNovel> GetNovelsByGenre(string genre);
    public List<LightNovel> GetNovelsByAuthor(string author);
    public List<LightNovel> GetNovelsByYear(int year);
}