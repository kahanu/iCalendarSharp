using System;
using System.IO;
using System.Linq;

namespace iCalendarSharp.Helpers
{
    /// <summary>
    /// Save the file to the file system.
    /// </summary>
    class FileManager
    {
        /// <summary>
        /// Save the file to the file system.
        /// </summary>
        /// <param name="fileName">The full physical path to the .vcs file on the server.</param>
        /// <param name="calendarEvent">The complete message as a string.</param>
        public static void SaveFile(string fileName, string calendarEvent)
        {
            File.WriteAllText(fileName, calendarEvent);
        }
    }
}
