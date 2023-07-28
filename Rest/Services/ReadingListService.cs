using Rest.Models;
using Rest.Repositories.Impl;

namespace Rest.Services;

public class ReadingListService
{
    private readonly ReadingListDAO _readingListDao;

    public bool AddNovelToList(ReadingList list, LightNovel novel)
    {
        return _readingListDao.AddNovelToList(list, novel);
    }

    public List<ReadingList> GetAllReadingLists()
    {
        return _readingListDao.GetAllReadingLists();
    }

    public ReadingList GetReadingListById(int id)
    {
        return _readingListDao.GetReadingListById(id);
    }

    public List<ReadingList> GetReadingListsByUser(User user)
    {
        return _readingListDao.GetReadingListByUser(user);
    }

    public ReadingList AddReadingList(ReadingList readingListData)
    {
        return _readingListDao.AddReadingList(readingListData);
    }

    public ReadingList UpdateReadingList(int id, ReadingList readingListData)
    {
        return _readingListDao.UpdateReadingList(id, readingListData);
    }

    public bool DeleteReadingList(int id)
    {
        return _readingListDao.DeleteReadingList(id);
    }
}