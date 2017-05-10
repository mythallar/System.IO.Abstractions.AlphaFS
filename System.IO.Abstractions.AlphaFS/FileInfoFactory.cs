using AfsFileInfo = Alphaleonis.Win32.Filesystem.FileInfo;

namespace System.IO.Abstractions.AlphaFS
{
    [Serializable]
    internal class FileInfoFactory : IFileInfoFactory
    {
        public FileInfoBase FromFileName(string fileName)
        {
            var realFileInfo = new AfsFileInfo(fileName);
            return new FileInfoWrapper(realFileInfo);
        }
    }
}