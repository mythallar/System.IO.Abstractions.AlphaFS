using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AfsFileSystemInfo = Alphaleonis.Win32.Filesystem.FileSystemInfo;
using AfsFileInfo = Alphaleonis.Win32.Filesystem.FileInfo;
using AfsDirectoryInfo = Alphaleonis.Win32.Filesystem.DirectoryInfo;

namespace System.IO.Abstractions.AlphaFS
{
    internal static class Converters
    {
        internal static FileSystemInfoBase[] WrapFileSystemInfos(this IEnumerable<AfsFileSystemInfo> input)
        {
            return input
                .Select<AfsFileSystemInfo, FileSystemInfoBase>(item =>
                {
                    if (item is AfsFileInfo fileInfo)
                        return ConvertToBase(fileInfo);

                    if (item is AfsDirectoryInfo directoryInfo)
                        return ConvertToBase(directoryInfo);

                    throw new NotImplementedException(string.Format(
                        CultureInfo.InvariantCulture,
                        "The type {0} is not recognized by the System.IO.Abstractions library.",
                        item.GetType().AssemblyQualifiedName
                        ));
                })
                .ToArray();
        }

        internal static DirectoryInfoBase[] WrapDirectories(this IEnumerable<AfsDirectoryInfo> input)
        {
            return input.Select(ConvertToBase).ToArray();
        }

        internal static FileInfoBase[] WrapFiles(this IEnumerable<AfsFileInfo> input)
        {
            return input.Select(ConvertToBase).ToArray();
        }

        internal static DirectoryInfoBase ConvertToBase(AfsDirectoryInfo directoryInfo)
        {
            if (directoryInfo == null) return null;
            return new DirectoryInfoWrapper(directoryInfo);
        }

        internal static FileInfoBase ConvertToBase(AfsFileInfo fileInfo)
        {
            if (fileInfo == null) return null;
            return new FileInfoWrapper(fileInfo);
        }
    }
}