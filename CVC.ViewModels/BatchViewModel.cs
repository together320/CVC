using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.ViewModels
{
    public class BatchViewModel
    {
        public string BatchNumber { get; set; }

        public string MachineName { get; set; }

        public List<BatchRunDataViewModel> LstBatchRunDataViewModels { get; set; }

    }

    public class BatchRunDataViewModel
    {
        public string ViewFieldName { get; set; }

        public string Value { get; set; }

    }
}
