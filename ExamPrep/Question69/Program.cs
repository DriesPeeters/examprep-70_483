using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question69
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = new Worker();
            var ac = w.ProcessDirectory();
            ac.Invoke(new DirectoryInfo(Environment.CurrentDirectory)) ;
        }

        public class Worker
        {
            ConcurrentDictionary<string, int> _wordCounts = new ConcurrentDictionary<string, int>();

            public Action<DirectoryInfo> ProcessDirectory()
            {
                return (dirInfo =>
                {
                    var files = dirInfo.GetFiles("*.txt").AsParallel<FileInfo>();
                    files.ForAll<FileInfo>(fileInfo =>
                    {
                        var fileContent = File.ReadAllText(fileInfo.FullName);
                        var sb = new StringBuilder();
                        foreach (var val in fileContent)
                        {
                            sb.Append(char.IsLetter(val) ? val.ToString().ToLowerInvariant() : " ");
                        }
                        string[] wordsInFile = sb.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var word in wordsInFile)
                        {
                            _wordCounts.AddOrUpdate(word, 1, (s, n) => n + 1);
                        }
                    });
                });
            }
        }       
    }
}
