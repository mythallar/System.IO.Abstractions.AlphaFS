using AfsDriveInfo = Alphaleonis.Win32.Filesystem.DriveInfo;

namespace System.IO.Abstractions.AlphaFS
{
    [Serializable]
    internal class DriveInfoFactory : IDriveInfoFactory
    {
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
                driveInfoWrappers[index] = new DriveInfoWrapper(driveInfo);
            }

            return driveInfoWrappers;
        }
    }
}
