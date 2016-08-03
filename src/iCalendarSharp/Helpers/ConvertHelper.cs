using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCalendarSharp.Helpers
{
    public static class ConvertHelper
    {
        /// <summary>
        /// Converts a string to a stream.
        /// </summary>
        /// <param name="s">The string to convert.</param>
        /// <returns>The stream.</returns>
        public static Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
