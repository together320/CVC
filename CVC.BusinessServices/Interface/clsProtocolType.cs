using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CVC.ViewModels;

namespace CVC.BusinessServices.Interface
{
    public class clsProtocolType : IProtocolType
    {

       public async Task<DashBoardViewModel> Connection()
        {
            
            return null;
        }

        public async Task<DashBoardViewModel> Read()
        {
            
            throw new NotImplementedException();
        }

        public async Task<DashBoardViewModel> Write()
        {
            throw new NotImplementedException();
        }
    }
}
