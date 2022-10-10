using System.IO;
using System.Text;

namespace DB_project.Utils
{
    public static class FileUtils
    {
        public static void CreateAndWriteFile(string fileName, string content)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }

            File.WriteAllText(fileName, content.ToString(), Encoding.Default);
        }
    }
}