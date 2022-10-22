namespace Module8.Library
{
    public class FileSystem
    {        
        public char NameDisk { get; }
        public long Sizedisk { get; }
        public long FreeSpaceDisk { get; }
        public List<Folder> Folders { get; }

        public FileSystem(char namedisk, long sizedisk, long freespacedisk)
        {
            this.NameDisk = namedisk;
            this.Sizedisk = sizedisk;
            this.FreeSpaceDisk = freespacedisk;
        }

        public void AddFolder(string namefolder)
        {
            Folders.Add(new Folder(namefolder));
        }
    }
}
