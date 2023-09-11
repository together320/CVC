using CVC.Data.EDMX;
using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.BusinessServices.Interface
{
   public interface ITerminalType
    {
        bool SaveTerminalType(TerminalTypeViewModel terminalTypeViewModel);
   }
}
