
class BookmarkManagement
{
    public struct Bookmark
    {
        public string Title;
        public string URL;
        public BookmarkCategory category;

        public Bookmark(string Title, string URL, BookmarkCategory category)
        {
            this.Title = Title;
            this.URL = URL;
            this.category = category;
        }



        public override string ToString()
        {
            return $"{Title,-15}{category,-15}{URL}";
        }

    }

    public enum BookmarkCategory
    {
        Work,
        Personal,
        Education,
        Entertainment,
        Other
    }
    List<Bookmark> bookmarks = new List<Bookmark>();

    public void AddBookmark(string Title, string URL, BookmarkCategory category)
    {
        bookmarks.Add(new Bookmark(Title, URL, category));
    }
    public void DisplayBookmarks()
    {
        Console.WriteLine($"{"Title",-15}{"Category",-15}{"URL"}");
        Console.WriteLine(new string('-', 50));
        foreach (var bookmark in bookmarks)
        {
            Console.WriteLine(bookmark);
        }
    }
    public void DeleteBookmark(Bookmark? bookmark)
    {
        if (bookmark != null)
            bookmarks.Remove((Bookmark)bookmark);
    }
    public void DeleteBookmark(string title)
    {
        DeleteBookmark(SearchBookmark(title));
    }
    Bookmark? SearchBookmark(string Title)
    {
        foreach (var bookmark in bookmarks)
        {
            if (bookmark.Title == Title)
                return bookmark;
        }
        return null;
    }
}