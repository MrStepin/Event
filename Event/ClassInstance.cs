using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Event
{
    class ClassInstance
    {
        public void Monitoring(string path)
        {
            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();

            fileSystemWatcher.Path = path;

            fileSystemWatcher.Created += FileSystemWatcherCreated;

            fileSystemWatcher.Renamed += FileSystemWatcherRenamed;

            fileSystemWatcher.Deleted += FileSystemWatcherDeleted;

            fileSystemWatcher.EnableRaisingEvents = true;
        }
        public void FileSystemWatcherCreated(object sender, FileSystemEventArgs eventArg)

        {
            Console.WriteLine("File created: {0}", eventArg.Name);
        }

        public void FileSystemWatcherRenamed(object sender, FileSystemEventArgs eventArg)

        {
            Console.WriteLine("File renamed: {0}", eventArg.Name);
        }

        public void FileSystemWatcherDeleted(object sender, FileSystemEventArgs eventArg)

        {
            Console.WriteLine("File deleted: {0}", eventArg.Name);
        }
    }
}
