using System;

namespace Helpers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Helper
    {
        public static string ReadStringFromFile(string relativeFilePath) =>
            new StreamReader(Directory.GetCurrentDirectory() + relativeFilePath).ReadToEnd();

        public static List<string> ReadStringArrayFromFile(string relativeFilePath) =>
            ReadStringFromFile(relativeFilePath).Split('\n', '\r').Where(x => x != string.Empty).ToList();
    }
}
