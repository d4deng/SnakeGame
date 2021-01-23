using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SnakeGame
{
    static class DataConnection
    {
        public static List<string> ReadData(this string filePath)
        {
            List<string> output = new List<string>();

            if (File.Exists(filePath))
            {
                output = File.ReadAllLines(filePath).ToList();
            }

            return output;
        }

        public static void WriteData(this List<string> data, string filePath)
        {

            // data should be in the form
            // ["1000, harry porter", "203, Wilson", "110, Kevin"
            // should be sorted by score

            File.WriteAllLines(filePath, data);
        }
    }
}
