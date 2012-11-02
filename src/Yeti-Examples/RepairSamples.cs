using System.IO;
using yeti.wma.repair;

namespace Yeti_Examples
{
    /// <summary>
    /// If you play broken.wma in a media player it probably won't 
    /// display the time or allow you to thumb through the file.
    /// These methods will repair the files and allow you to see the 
    /// length of the file and return rough thumbing support as well 
    /// as convert the file to another format.
    /// </summary>
    public static class RepairSamples
    {
        public static void RepairWmaWithStrings()
        {
            const string newFileName = @"Output\fixedWmaWithStrings.wma";
            Directory.CreateDirectory("Output");
            File.Copy(Files.BrokenWma, newFileName);
            WmaRepair.Repair(newFileName, false);
        }

        public static void RepairWmaWithStreams()
        {
            const string newFileName = @"Output\fixedWmaWithStreams.wma";
            Directory.CreateDirectory("Output");
            File.Copy(Files.BrokenWma, newFileName);

            using (var stream = File.Open(newFileName, FileMode.Open, FileAccess.ReadWrite))
            {
                WmaRepair.Repair(stream, false);
            }
        }
    }
}