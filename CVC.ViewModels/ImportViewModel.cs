using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.ViewModels
{
    public class ImportViewModel
    {
        public DataTable dtUploadedData { get; set; }

    }


    public class ColumnFieldMappingList
    {
        public string header { get; set; }

        public string row { get; set; }

        public int serialNumber { get; set; }

        public string formFieldText { get; set; }

        public int formFieldValue { get; set; }
        public string mappedFieldText { get; set; }
    }

    public class ColumnFieldMappingViewModel
    {

        public List<ColumnFieldMappingList> lstColumnFieldMappingList { get; set; }

        public List<ListViewModel> lstViewModel { get; set; }

        public string myname { get; set; }
    }
}
