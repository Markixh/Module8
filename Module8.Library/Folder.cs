namespace Module8.Library
{
    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();
        public string Name { get; }

        public Folder(string name)
        {
            Name = name;
        }
    }
}
