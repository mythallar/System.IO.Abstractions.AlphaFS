using AfsDirectoryInfo = Alphaleonis.Win32.Filesystem.DirectoryInfo;

namespace System.IO.Abstractions.AlphaFS
{
    [Serializable]
    internal class DirectoryInfoFactory : IDirectoryInfoFactory
    {
        public DirectoryInfoBase FromDirectoryName(string directoryName)
        {
            var realDirectoryInfo = new AfsDirectoryInfo(directoryName);
            return new DirectoryInfoWrapper(realDirectoryInfo);
        }
    }
}