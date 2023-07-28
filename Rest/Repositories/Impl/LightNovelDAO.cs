using Rest.Models;

namespace Rest.Repositories.Impl;

public class LightNovelDAO : ILightNovelDAO
{
    public LightNovel AddNovel(LightNovel novelData)
    {
        throw new NotImplementedException();
    }

    public LightNovel UpdateNovel(int id, LightNovel novelData)
    {
        throw new NotImplementedException();
    }

    public bool DeleteNovel(int id)
    {
        throw new NotImplementedException();
    }

    public List<LightNovel> GetAllNovels()
    {
        throw new NotImplementedException();
    }

    public LightNovel GetNovelById(int id)
    {
        throw new NotImplementedException();
    }

    public List<LightNovel> GetNovelsByGenre(string genre)
    {
        throw new NotImplementedException();
    }

    public List<LightNovel> GetNovelsByAuthor(string author)
    {
        throw new NotImplementedException();
    }

    public List<LightNovel> GetNovelsByYear(int year)
    {
        throw new NotImplementedException();
    }
}