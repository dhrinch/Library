namespace Library
{
    class Book
    {
        public Author author { get; private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public override string ToString()
        {
            return Title + " by " + author;
        }
        public Book(string title, string authorName, string authorLastName, string text)
        {
            Title = title;
            author = new Author(authorName, authorLastName);
            Text = text;
        }
    }
}
