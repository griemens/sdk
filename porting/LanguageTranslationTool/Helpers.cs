using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace GResxExtract
{
    internal class Helpers
    {
        public static string MakeRelativePath(string mainDirPath, string absoluteFilePath)
        {
            string[] mainTokens = mainDirPath.Trim(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar);
            string[] abslouteTokens = absoluteFilePath.Trim(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar);

            // Count all folders that are equal.
            int num = 0;
            for (int index = 0; index < Math.Min(mainTokens.Length, abslouteTokens.Length) && mainTokens[index].ToLower().Equals(abslouteTokens[index].ToLower()); ++index)
                ++num;
            if (num == 0)
                return absoluteFilePath; // all is same.

            // Build up the relative path.
            string str = "";
            for (int index = num; index < mainTokens.Length; ++index)
            {
                if (index > num)
                    str = str + Path.DirectorySeparatorChar;
                str = str + "..";
            }
            if (str.Length == 0)
                str = ".";
            // Add the remaining folders and file.
            for (int index = num; index < abslouteTokens.Length; ++index)
                str = str + Path.DirectorySeparatorChar + abslouteTokens[index];
            return str;
        }
    }
}