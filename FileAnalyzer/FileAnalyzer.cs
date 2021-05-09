using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUXdesign.Models;

namespace PUXdesign.Analysis
{
    public class FileAnalyzer
    {
        public string RequiredPath { get; }
        public List<Files> Added { get; set; }
        public List<Files> Changed { get; set; }
        public List<Files> Removed { get; set; }
        public bool IsPathValid { get; set; }
        public FileAnalyzer(string RequiredPath)
        {
            this.RequiredPath = RequiredPath;
            this.PathTest();
        }

        private void PathTest()
        {
            if (Directory.Exists(RequiredPath))
            {
                IsPathValid = true;
            }
            else
            {
                IsPathValid = false;
            }
        }

        public void Run() 
        {
            List<Files> FilesListFromSave = TryLoadSave();
            List<Files> FilesList = Scan(RequiredPath);
            CheckSum(FilesList, out FilesList);
            if (FilesListFromSave != null)
            {
                FilesList = TryCompare(FilesList, FilesListFromSave);
            }
            else
            {
                FilesList = NewData(FilesList);
            }
            Save(FilesList);
        }

        public ReportFilesAnalyzer GetResult() 
        {
            var data = new ReportFilesAnalyzer();
            data.Added = Added;
            data.Changed = Changed;
            data.Removed = Removed;
            data.RequiredPath = RequiredPath;
            return data;
        }

        private List<Files> NewData(List<Files> filesList)
        {
            foreach (var newfile in filesList)
            {
                if (newfile.Type == DataType.DataFile)
                {
                    newfile.ActualVersion.identification = (float)1;
                    newfile.AllVersions.Add(newfile.ActualVersion);
                }
            }
            Added = filesList;
            return filesList;
        }

        private List<Files> TryCompare(List<Files> filesList, List<Files> filesListFromSave)
        {
            Added = filesList.Where(c => !filesListFromSave.Any(d => c.FullPath == d.FullPath && c.RequiredPath == d.RequiredPath)).ToList();
            foreach (var newFile in Added)
            {
                if (newFile.Type == DataType.DataFile)
                {
                    newFile.ActualVersion.identification = 1;
                    newFile.AllVersions.Add(newFile.ActualVersion);
                }
            }
            Changed = new List<Files>();
            Removed = filesListFromSave.Where(c => !filesList.Any(d => c.FullPath == d.FullPath && c.RequiredPath == d.RequiredPath)).ToList();
            foreach (var reqFile in filesList)
            {
                foreach (var jsonFile in filesListFromSave)
                {
                    if (reqFile.FullPath == jsonFile.FullPath && reqFile.Type == DataType.DataFile && jsonFile.Type == DataType.DataFile)
                    {
                        if (reqFile.ActualVersion.HashMD5 == jsonFile.ActualVersion.HashMD5)
                        {
                            reqFile.ActualVersion = jsonFile.ActualVersion;
                            reqFile.AllVersions = jsonFile.AllVersions;
                        }
                        else if (reqFile.ActualVersion.HashMD5 != jsonFile.ActualVersion.HashMD5)
                        {
                            if (jsonFile.AllVersions.Count != 0)
                            {
                                var tmpcheck = new List<bool>();
                                foreach (var verHistory in jsonFile.AllVersions.ToList())
                                {
                                    if (reqFile.ActualVersion.HashMD5 == verHistory.HashMD5)
                                    {
                                        reqFile.ActualVersion = verHistory;
                                        reqFile.AllVersions = jsonFile.AllVersions;
                                        tmpcheck.Add(true);
                                        Changed.Add(reqFile);
                                    }
                                    else
                                    {
                                        tmpcheck.Add(false);
                                    }
                                }
                                if (!tmpcheck.Contains(true))
                                {
                                    if (reqFile.Type == DataType.DataFile)
                                    {
                                        float latestVer = jsonFile.AllVersions.Max(t => t.identification);
                                        reqFile.ActualVersion.identification = latestVer + (float)1;
                                        jsonFile.AllVersions.Add(reqFile.ActualVersion);
                                        reqFile.AllVersions = jsonFile.AllVersions;
                                        Changed.Add(reqFile);
                                    }
                                }
                            }
                            else if (jsonFile.AllVersions.Count == 0)
                            {
                                reqFile.ActualVersion.identification = 1;
                                reqFile.AllVersions.Add(reqFile.ActualVersion);
                            }
                        }
                    }
                }
            }
            return filesList;
        }

        private List<Files> TryLoadSave()
        {
            try
            {
                var jsonString = File.ReadAllText("FileAnalysis.json");
                var BuildObjectFromJson = JsonSerializer.Deserialize<List<Files>>(jsonString);
                return BuildObjectFromJson;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void Save(List<Files> filesList)
        {
            //var jsonString = JsonSerializer.Serialize(filesList);
            var jsonString = JsonSerializer.Serialize<List<Files>>(filesList);
            File.WriteAllText("FileAnalysis.json", jsonString);
        }

        private void DebugAddVer(List<Files> filesListUnprocessed, out List<Files> filesList)
        {
            foreach (var files in filesListUnprocessed)
            {
                files.ActualVersion.identification = 1;
                files.AllVersions.Add(files.ActualVersion);
            }
            filesList = filesListUnprocessed;
        }

        private List<Files> Scan(string requiredPath)
        {
            var FilesList = new List<Files>();
            var PathFiles = Directory.EnumerateFiles(requiredPath, "*",SearchOption.AllDirectories);
            var PathFolders = Directory.EnumerateDirectories(requiredPath, "*", SearchOption.AllDirectories);
            foreach (var item in PathFiles)
            {
                var NewFile = new Files();
                NewFile.RequiredPath = RequiredPath;
                NewFile.FullPath = item;
                NewFile.Name = Path.GetFileName(item);
                NewFile.Type = DataType.DataFile;
                FilesList.Add(NewFile);
            }
            foreach (var item in PathFolders)
            {
                var NewFile = new Files();
                NewFile.RequiredPath = RequiredPath;
                NewFile.FullPath = item;
                NewFile.Name = Path.GetFileName(item);
                NewFile.Type = DataType.Folder;
                FilesList.Add(NewFile);
            }
            return FilesList;
        }
        private void CheckSum(List<Files> filesListUnprocessed, out List<Files> filesList)
        {
            foreach (var file in filesListUnprocessed)
            {
                if (file.Type == DataType.DataFile)
                {
                    using (var md5 = MD5.Create())
                    {
                        using (var stream = File.OpenRead(file.FullPath))
                        {
                            var NewVer = new Version();
                            var hash = md5.ComputeHash(stream);
                            NewVer.HashMD5 = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                            file.ActualVersion = NewVer;
                        }
                    }
                }
            }
            filesList = filesListUnprocessed;
        }
    }
}
