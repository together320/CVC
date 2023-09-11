using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.BusinessServices.Interface
{
    interface IProtocolType
    {
          Task<DashBoardViewModel> Connection();
          Task<DashBoardViewModel> Read();
          Task<DashBoardViewModel> Write();

    }
}
