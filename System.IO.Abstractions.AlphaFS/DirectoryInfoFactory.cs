using AfsDirectoryInfo = Alphaleonis.Win32.Filesystem.DirectoryInfo;

namespace System.IO.Abstractions.AlphaFS
{
    [Serializable]
    internal class DirectoryInfoFactory : IDirectoryInfoFactory
    {
        private readonly IFileSystem fileSystem;

        public DirectoryInfoFactory(IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }

        public DirectoryInfoBase FromDirectoryName(string directoryName)
        {
            var realDirectoryInfo = new AfsDirectoryInfo(directoryName);
            return new DirectoryInfoWrapper(fileSystem, realDirectoryInfo);
        }
    }
}