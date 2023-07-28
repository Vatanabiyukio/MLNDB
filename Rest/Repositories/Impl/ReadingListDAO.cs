using Rest.Models;

namespace Rest.Repositories.Impl;

public class ReadingListDAO : IReadingListDAO
{
    public ReadingList AddReadingList(ReadingList readingListData)
    {
        throw new NotImplementedException();
    }

    public ReadingList UpdateReadingList(int id, ReadingList readingListData)
    {
        throw new NotImplementedException();
    }

    public bool DeleteReadingList(int id)
    {
        throw new NotImplementedException();
    }

    public List<ReadingList> GetAllReadingLists()
    {
        throw new NotImplementedException();
    }

    public ReadingList GetReadingListById(int id)
    {
        throw new NotImplementedException();
    }

    public List<ReadingList> GetReadingListByUser(User user)
    {
        throw new NotImplementedException();
    }

    public bool AddNovelToList(ReadingList list, LightNovel novel)
    {
        throw new NotImplementedException();
    }
}