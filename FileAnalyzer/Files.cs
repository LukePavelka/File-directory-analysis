using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PUXdesign.Analysis
{
    public class Files
    {
        public string RequiredPath { get; set; }
        public string FullPath { get; set; }
        public string Name { get; set; }
        public DataType Type { get; set; }
        public Version ActualVersion { get; set; }
        [JsonInclude]
        public List<Version> AllVersions = new List<Version>();
    }

    public class Version
    {
        public float identification { get; set; }
        public string HashMD5 { get; set; }
    }

    public enum DataType
    {
        DataFile,
        Folder
    }
}