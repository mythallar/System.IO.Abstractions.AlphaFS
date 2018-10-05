using System.Collections.Generic;
using System.Security.AccessControl;
using AfsDirectory = Alphaleonis.Win32.Filesystem.Directory;

namespace System.IO.Abstractions.AlphaFS
{
    [Serializable]
    public class DirectoryWrapper : DirectoryBase
    {
        public DirectoryWrapper(IFileSystem fileSystem) : base(fileSystem)
        {
        }

        public override DirectoryInfoBase CreateDirectory(string path)
        {
            return new DirectoryInfoWrapper(FileSystem, AfsDirectory.CreateDirectory(path));
        }

        public override DirectoryInfoBase CreateDirectory(string path, DirectorySecurity directorySecurity)
        {
            return new DirectoryInfoWrapper(FileSystem, AfsDirectory.CreateDirectory(path, directorySecurity));
        }

        public override void Delete(string path)
        {
            AfsDirectory.Delete(path);
        }

        public override void Delete(string path, bool recursive)
        {
            AfsDirectory.Delete(path, recursive);
        }

        public override bool Exists(string path)
        {
            return AfsDirectory.Exists(path);
        }

        public override DirectorySecurity GetAccessControl(string path)
        {
            return AfsDirectory.GetAccessControl(path);
        }

        public override DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
        {
            return AfsDirectory.GetAccessControl(path, includeSections);
        }

        public override DateTime GetCreationTime(string path)
        {
            return AfsDirectory.GetCreationTime(path);
        }

        public override DateTime GetCreationTimeUtc(string path)
        {
            return AfsDirectory.GetCreationTimeUtc(path);
        }

        public override string GetCurrentDirectory()
        {
            return AfsDirectory.GetCurrentDirectory();
        }

        public override string[] GetDirectories(string path)
        {
            return AfsDirectory.GetDirectories(path);
        }

        public override string[] GetDirectories(string path, string searchPattern)
        {
            return AfsDirectory.GetDirectories(path, searchPattern);
        }

        public override string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return AfsDirectory.GetDirectories(path, searchPattern, searchOption);
        }

        public override string GetDirectoryRoot(string path)
        {
            return AfsDirectory.GetDirectoryRoot(path);
        }

        public override string[] GetFiles(string path)
        {
            return AfsDirectory.GetFiles(path);
        }

        public override string[] GetFiles(string path, string searchPattern)
        {
            return AfsDirectory.GetFiles(path, searchPattern);
        }

        public override string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return AfsDirectory.GetFiles(path, searchPattern, searchOption);
        }

        public override string[] GetFileSystemEntries(string path)
        {
            return AfsDirectory.GetFileSystemEntries(path);
        }

        public override string[] GetFileSystemEntries(string path, string searchPattern)
        {
            return AfsDirectory.GetFileSystemEntries(path, searchPattern);
        }

        public override DateTime GetLastAccessTime(string path)
        {
            return AfsDirectory.GetLastAccessTime(path);
        }

        public override DateTime GetLastAccessTimeUtc(string path)
        {
            return AfsDirectory.GetLastAccessTimeUtc(path);
        }

        public override DateTime GetLastWriteTime(string path)
        {
            return AfsDirectory.GetLastWriteTime(path);
        }

        public override DateTime GetLastWriteTimeUtc(string path)
        {
            return AfsDirectory.GetLastWriteTimeUtc(path);
        }

        public override string[] GetLogicalDrives()
        {
            return AfsDirectory.GetLogicalDrives();
        }

        public override DirectoryInfoBase GetParent(string path)
        {
            return new DirectoryInfoWrapper(FileSystem, AfsDirectory.GetParent(path));
        }

        public override void Move(string sourceDirName, string destDirName)
        {
            AfsDirectory.Move(sourceDirName, destDirName);
        }

        public override void SetAccessControl(string path, DirectorySecurity directorySecurity)
        {
            AfsDirectory.SetAccessControl(path, directorySecurity);
        }

        public override void SetCreationTime(string path, DateTime creationTime)
        {
            AfsDirectory.SetCreationTime(path, creationTime);
        }

        public override void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            AfsDirectory.SetCreationTimeUtc(path, creationTimeUtc);
        }

        public override void SetCurrentDirectory(string path)
        {
            AfsDirectory.SetCurrentDirectory(path);
        }

        public override void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            AfsDirectory.SetLastAccessTime(path, lastAccessTime);
        }

        public override void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            AfsDirectory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }

        public override void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            AfsDirectory.SetLastAccessTime(path, lastWriteTime);
        }

        public override void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            AfsDirectory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }

        public override IEnumerable<string> EnumerateDirectories(string path)
        {
            return AfsDirectory.EnumerateDirectories(path);
        }

        public override IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        {
            return AfsDirectory.EnumerateDirectories(path, searchPattern);
        }

        public override IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return AfsDirectory.EnumerateDirectories(path, searchPattern, searchOption);
        }

        public override IEnumerable<string> EnumerateFiles(string path)
        {
           return AfsDirectory.EnumerateFiles(path);
        }
 
        public override IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            return AfsDirectory.EnumerateFiles(path, searchPattern);
        }

        public override IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return AfsDirectory.EnumerateFiles(path, searchPattern, searchOption);
        }

        public override IEnumerable<string> EnumerateFileSystemEntries(string path)
        {
            return AfsDirectory.EnumerateFileSystemEntries(path);
        }

        public override IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        {
            return AfsDirectory.EnumerateFileSystemEntries(path, searchPattern);
        }

        public override IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return AfsDirectory.EnumerateFileSystemEntries(path, searchPattern, searchOption);
        }
    }
}