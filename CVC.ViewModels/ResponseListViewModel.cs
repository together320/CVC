using System;
using System.Collections.Generic;
using System.Text;

namespace CVC.ViewModels
{

    public class ResponseListViewModel<T> where T : class
    {

        public bool IsStatus { get; set; }

        public string StatusMessage { get; set; }

        public List<T> Data { get; set; }
    }

    public class ResponseViewModel<T> where T : class
    {

        public bool IsStatus { get; set; }

        public string StatusMessage { get; set; }

        public T Data { get; set; }
    }

}
