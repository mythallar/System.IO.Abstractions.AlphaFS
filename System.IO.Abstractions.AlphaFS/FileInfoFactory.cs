using AfsFileInfo = Alphaleonis.Win32.Filesystem.FileInfo;

namespace System.IO.Abstractions.AlphaFS
{
    [Serializable]
    internal class FileInfoFactory : IFileInfoFactory
    {
        private readonly IFileSystem fileSystem;

        public FileInfoFactory(IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }

        public FileInfoBase FromFileName(string fileName)
        {
            var realFileInfo = new AfsFileInfo(fileName);
            return new FileInfoWrapper(fileSystem, realFileInfo);
        }
    }
}