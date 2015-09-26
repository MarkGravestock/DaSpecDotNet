using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DaSpec
{
    public class FileSystemMarkdownCandidateStepSource : ICandidateStepSource
    {
        private string directoryPath;

        public FileSystemMarkdownCandidateStepSource(string directoryPath)
        {
            this.directoryPath = directoryPath;
        }

        public IEnumerable<string> GetCandidateSteps()
        {
            return GetFiles(directoryPath).Where(x => x.Extension == ".md").Select(y => File.ReadAllText(y.FullName));
        }

        static IEnumerable<System.IO.FileInfo> GetFiles(string path)
        {
            if (!System.IO.Directory.Exists(path))
                throw new System.IO.DirectoryNotFoundException();

            string[] fileNames = null;
            List<System.IO.FileInfo> files = new List<System.IO.FileInfo>();

            fileNames = System.IO.Directory.GetFiles(path, "*.*", System.IO.SearchOption.AllDirectories);
            foreach (string name in fileNames)
            {
                files.Add(new System.IO.FileInfo(name));
            }

            return files;
        }
    }
}
