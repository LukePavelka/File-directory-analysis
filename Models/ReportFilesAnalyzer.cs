using PUXdesign.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUXdesign.Models
{
    public class ReportFilesAnalyzer
    {
        public string RequiredPath { get; set; }
        public List<Files> Added { get; set; }
        public List<Files> Changed { get; set; }
        public List<Files> Removed { get; set; }

        public bool CheckForFolder(List<Files> data) 
        {
            foreach (var item in data)
            {
                if (item.Type == DataType.Folder)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckForDataFile(List<Files> data)
        {
            foreach (var item in data)
            {
                if (item.Type == DataType.DataFile)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckForSameReq(List<Files> data, RequestAndReportSingle model) 
        {
            foreach (var item in data)
            {
                if (item.RequiredPath == model.Request.Path)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
