using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AfsDirectoryInfo = Alphaleonis.Win32.Filesystem.DirectoryInfo;
using AfsFileInfo = Alphaleonis.Win32.Filesystem.FileInfo;
using AfsFileSystemInfo = Alphaleonis.Win32.Filesystem.FileSystemInfo;

namespace System.IO.Abstractions.AlphaFS
{
    internal static class Converters
    {
        internal static IEnumerable<FileSystemInfoBase> WrapFileSystemInfos(this IEnumerable<AfsFileSystemInfo> input, IFileSystem fileSystem)
            => input.Select(info => WrapAfsFileSystemInfo(fileSystem, info));

        internal static FileSystemInfoBase[] WrapFileSystemInfos(this AfsFileSystemInfo[] input, IFileSystem fileSystem)
            => input.Select(info => WrapAfsFileSystemInfo(fileSystem, info)).ToArray();

        internal static IEnumerable<DirectoryInfoBase> WrapDirectories(this IEnumerable<AfsDirectoryInfo> input, IFileSystem fileSystem)
            => input.Select(info => WrapDirectoryInfo(fileSystem, info));

        internal static DirectoryInfoBase[] WrapDirectories(this AfsDirectoryInfo[] input, IFileSystem fileSystem)
            => input.Select(info => WrapDirectoryInfo(fileSystem, info)).ToArray();

        internal static IEnumerable<FileInfoBase> WrapFiles(this IEnumerable<AfsFileInfo> input, IFileSystem fileSystem)
            => input.Select(info => WrapFileInfo(fileSystem, info));

        internal static FileInfoBase[] WrapFiles(this AfsFileInfo[] input, IFileSystem fileSystem)
            => input.Select(info => WrapFileInfo(fileSystem, info)).ToArray();

        private static FileSystemInfoBase WrapAfsFileSystemInfo(IFileSystem fileSystem, AfsFileSystemInfo item)
        {
            if (item is AfsFileInfo)
            {
                return WrapFileInfo(fileSystem, (AfsFileInfo)item);
            }
            else if (item is AfsDirectoryInfo)
            {
                return WrapDirectoryInfo(fileSystem, (AfsDirectoryInfo)item);
            }
            else
            {
                throw new NotImplementedException(string.Format(
                    CultureInfo.InvariantCulture,
                    "The type {0} is not recognized by the System.IO.Abstractions library.",
                    item.GetType().AssemblyQualifiedName
                ));
            }
        }

        private static FileInfoBase WrapFileInfo(IFileSystem fileSystem, AfsFileInfo f) => new FileInfoWrapper(fileSystem, f);

        private static DirectoryInfoBase WrapDirectoryInfo(IFileSystem fileSystem, AfsDirectoryInfo d) => new DirectoryInfoWrapper(fileSystem, d);
    }
}