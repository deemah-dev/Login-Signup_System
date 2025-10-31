using Extentions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystemWinForm
{
    internal class LoginSystem
    {
        private static string path = "C:\\Users\\user\\source\\repos\\LoginSystemWinForm\\LoginSystemWinForm\\LoginFile.txt";

        public static void StoreUserInFile(string firstName, string lastName, string username, string password)
        {
            using (var sw = new StreamWriter(path, true))
            {
                sw.Write(firstName + "#//#");
                sw.Write(lastName + "#//#");
                sw.Write(username + "#//#");
                sw.Write(password.Encrypt());
                sw.WriteLine();
            }
        }

        public static bool FindUser(string username, string password)
        {
            string[] Lines = File.ReadAllLines(path);
            foreach (var line in Lines)
            {
                if (line.Contains(username))
                {
                    if (line.Contains(password.Encrypt()))
                        return true;
                }
            }
            return false;
        }
    }
}
