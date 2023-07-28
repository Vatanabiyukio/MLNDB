using Rest.Models;
using Rest.Repositories.Impl;

namespace Rest.Services;

public class LightNovelService
{
    private readonly LightNovelDAO _lightNovelDao;

    public LightNovel AddNovel(LightNovel novelData)
    {
        return _lightNovelDao.AddNovel(novelData);
    }

    public LightNovel UpdateNovel(int id, LightNovel novelData)
    {
        return _lightNovelDao.UpdateNovel(id, novelData);
    }

    public bool DeleteNovel(int id)
    {
        return _lightNovelDao.DeleteNovel(id);
    }

    public List<LightNovel> GetAllNovels()
    {
        return _lightNovelDao.GetAllNovels();
    }

    public LightNovel GetNovelById(int id)
    {
        return _lightNovelDao.GetNovelById(id);
    }

    public List<LightNovel> GetNovelsByGenre(string genre)
    {
        return _lightNovelDao.GetNovelsByGenre(genre);
    }

    public List<LightNovel> GetNovelsByAuthor(string author)
    {
        return _lightNovelDao.GetNovelsByAuthor(author);
    }

    public List<LightNovel> GetNovelsByYear(int year)
    {
        return _lightNovelDao.GetNovelsByYear(year);
    }
}