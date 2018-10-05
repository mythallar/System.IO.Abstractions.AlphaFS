using AfsDriveInfo = Alphaleonis.Win32.Filesystem.DriveInfo;

namespace System.IO.Abstractions.AlphaFS
{
    [Serializable]
    internal class DriveInfoFactory : IDriveInfoFactory
    {
        private readonly IFileSystem fileSystem;

        public DriveInfoFactory(IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }

        public DriveInfoBase FromDriveName(string driveName)
        {
            var realDriveInfo = new AfsDriveInfo(driveName);
            return new DriveInfoWrapper(fileSystem, realDriveInfo);
        }

        /// <summary>
        /// Retrieves the drive names of all logical drives on a computer.
        /// </summary>
        /// <returns>An array of type <see cref="DriveInfoBase"/> that represents the logical drives on a computer.</returns>
        public DriveInfoBase[] GetDrives()
        {
            var driveInfos = AfsDriveInfo.GetDrives();
            var driveInfoWrappers = new DriveInfoBase[driveInfos.Length];
            for (int index = 0; index < driveInfos.Length; index++)
            {
                var driveInfo = driveInfos[index];
                driveInfoWrappers[index] = new DriveInfoWrapper(fileSystem, driveInfo);
            }

            return driveInfoWrappers;
        }
    }
}
