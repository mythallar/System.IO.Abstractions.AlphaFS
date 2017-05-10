using AfsPath = Alphaleonis.Win32.Filesystem.Path;

namespace System.IO.Abstractions.AlphaFS
{
    [Serializable]
    public class PathWrapper : PathBase
    {
        public override char AltDirectorySeparatorChar
        {
            get { return AfsPath.AltDirectorySeparatorChar; }
        }

        public override char DirectorySeparatorChar
        {
            get { return AfsPath.DirectorySeparatorChar; }
        }

        [Obsolete("Please use GetInvalidPathChars or GetInvalidFileNameChars instead.")]
        public override char[] InvalidPathChars
        {
            get { return AfsPath.GetInvalidPathChars(); }
        }

        public override char PathSeparator
        {
            get { return AfsPath.PathSeparator; }
        }

        public override char VolumeSeparatorChar
        {
            get { return AfsPath.VolumeSeparatorChar; }
        }

        public override string ChangeExtension(string path, string extension)
        {
            return AfsPath.ChangeExtension(path, extension);
        }

        public override string Combine(params string[] paths)
        {
            return AfsPath.Combine(paths);
        }

        public override string Combine(string path1, string path2)
        {
            return AfsPath.Combine(path1, path2);
        }

        public override string Combine(string path1, string path2, string path3)
        {
            return AfsPath.Combine(path1, path2, path3);
        }

        public override string Combine(string path1, string path2, string path3, string path4)
        {
            return AfsPath.Combine(path1, path2, path3, path4);
        }

        public override string GetDirectoryName(string path)
        {
            return AfsPath.GetDirectoryName(path);
        }

        public override string GetExtension(string path)
        {
            return AfsPath.GetExtension(path);
        }

        public override string GetFileName(string path)
        {
            return AfsPath.GetFileName(path);
        }

        public override string GetFileNameWithoutExtension(string path)
        {
            return AfsPath.GetFileNameWithoutExtension(path);
        }

        public override string GetFullPath(string path)
        {
            return AfsPath.GetFullPath(path);
        }

        public override char[] GetInvalidFileNameChars()
        {
            return AfsPath.GetInvalidFileNameChars();
        }

        public override char[] GetInvalidPathChars()
        {
            return AfsPath.GetInvalidPathChars();
        }

        public override string GetPathRoot(string path)
        {
            return AfsPath.GetPathRoot(path);
        }

        public override string GetRandomFileName()
        {
            return AfsPath.GetRandomFileName();
        }

        public override string GetTempFileName()
        {
            return AfsPath.GetTempFileName();
        }

        public override string GetTempPath()
        {
            return AfsPath.GetTempPath();
        }

        public override bool HasExtension(string path)
        {
            return AfsPath.HasExtension(path);
        }

        public override bool IsPathRooted(string path)
        {
            return AfsPath.IsPathRooted(path);
        }
    }
}
