using Rest.Models;

namespace Rest.Repositories;

public interface IReadingListDAO
{
    public ReadingList AddReadingList(ReadingList readingListData);
    public ReadingList UpdateReadingList(int id, ReadingList readingListData);
    public bool DeleteReadingList(int id);
    public List<ReadingList> GetAllReadingLists();
    public ReadingList GetReadingListById(int id);
    public List<ReadingList> GetReadingListByUser(User user);
    public bool AddNovelToList(ReadingList list, LightNovel novel);
}