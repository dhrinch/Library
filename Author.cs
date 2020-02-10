namespace Library
{
    class Author
    {
        public string Name { get; private set; }
        public string lastName { get; private set; }
        public override string ToString()
        {
            return Name + " " + lastName;
        }
        public Author(string name, string lastName)
        {
            Name = name;
            this.lastName = lastName;
        }
    }
}
