using CVC.Data.EDMX;
using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CVC.BusinessServices.DAL
{
    public class MessageMasterDAL
    {
        public List<MessageMasterViewModel> GetAll_MessageMaster(MessageMasterViewModel messageMasterViewModel)
        {
            var lstMessageMasterViewModel = new List<MessageMasterViewModel>();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var messageMaster = cvcEntities.MessageMasters.ToList();

                    lstMessageMasterViewModel = messageMaster.Select((item, index) => new MessageMasterViewModel
                    {
                        Index = index + 1,
                        MessageMasterId = item.MessageMasterId,
                        MessageText = item.MessageText,
                        MessageDescription = item.MessageDescription,
                        IsActive = item.IsActive,
                        MessageType=item.PickListValue.PickListValueName

                    }).ToList();
                }
                return lstMessageMasterViewModel;
            }
            catch (System.Exception ex)
            {
                return lstMessageMasterViewModel;
            }
        }

        public MessageMasterViewModel GetById_MessageMaster(MessageMasterViewModel messageMasterViewModel)
        {
            var messageMaster = new MessageMasterViewModel();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var message = cvcEntities.MessageMasters.FirstOrDefault(mm=>mm.MessageMasterId==messageMasterViewModel.MessageMasterId);

                    if(message!=null)
                    messageMaster= new MessageMasterViewModel
                    {
                        MessageMasterId = message.MessageMasterId,
                        MessageText = message.MessageText,
                        MessageDescription = message.MessageDescription,
                        IsActive = message.IsActive,
                        MessageType = message.PickListValue.PickListValueName,
                        PickListValueId=message.PickListValueId
                       

                    };
                }
                return messageMaster;
            }
            catch (System.Exception ex)
            {
                return messageMaster ;
            }
        }

        public object Create_MessageMaster(MessageMasterViewModel messageMasterViewModel)
        {
            try
            {
                using (var cVCEntities = new CVCEntities())
                {
                    var isExist = cVCEntities.MessageMasters.FirstOrDefault(tt => tt.MessageText.ToLower() == messageMasterViewModel.MessageText.ToLower());

                if (isExist != null)
                {
                    return new { status = false, message = "Message text already exist" };
                }
               
                var createMessageMaster = new MessageMaster();
               
                    createMessageMaster.MessageText = messageMasterViewModel.MessageText;
                    createMessageMaster.MessageDescription = messageMasterViewModel.MessageDescription;
                    createMessageMaster.IsActive = messageMasterViewModel.IsActive;
                    createMessageMaster.PickListValueId = messageMasterViewModel.PickListValueId;
                    cVCEntities.MessageMasters.Add(createMessageMaster);
                    cVCEntities.SaveChanges();
                }
                return new { status = true, message = "Data Saved Successfully" };


            }
            catch (System.Exception ex)
            {
                return new { status = false, message = "Error while saving data" };

            }
        }

        public object Update_MessageMaster(MessageMasterViewModel messageMasterViewModel)
        {
            try
            {

                using (var cVCEntities = new CVCEntities())
                {
                    var isExist = cVCEntities.MessageMasters.FirstOrDefault(mm=>mm.MessageText.ToLower() == messageMasterViewModel.MessageText.ToLower() && mm.MessageMasterId!=messageMasterViewModel.MessageMasterId );

                    if (isExist != null)
                    {
                        return new { status = false, message = "Message text already exist" };
                    }

                    var updateMessage = cVCEntities.MessageMasters.FirstOrDefault(mm => mm.MessageMasterId == messageMasterViewModel.MessageMasterId);

                    updateMessage.MessageText = messageMasterViewModel.MessageText;
                    updateMessage.MessageDescription = messageMasterViewModel.MessageDescription;
                    updateMessage.IsActive = messageMasterViewModel.IsActive;
                    updateMessage.PickListValueId = messageMasterViewModel.PickListValueId;

                    cVCEntities.SaveChanges();
                }
                return new { status = true, message = "Data Saved Successfully" };


            }
            catch (System.Exception ex)
            {
                return new { status = false, message = "Error while saving data" };

            }
        }

    }
}
