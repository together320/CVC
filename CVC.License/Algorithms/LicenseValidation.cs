using CVC.License.Algorithms.Forms.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
namespace CVC.License.Algorithms
{
    public class LicenseValidation
    {
        CommonData common = new CommonData();
        public bool ValidateLicenseType()
        {
            string ModeData = null;
            string ModeStartDate = null;
            string ModeEndDate = null;
            DateTime LicenseStartDate = new DateTime();
            DateTime LicenseEndDate = new DateTime();
            bool Flag = false;
            try
            {
                ModelLicenseTypeInfo modelLicenseTypeInfo = FetchLicenseType();
                if (modelLicenseTypeInfo != null)
                {
                    if (modelLicenseTypeInfo.mode != null)
                    {
                        ModeData = common.DecryptToJsonString(modelLicenseTypeInfo.mode, Properties.Settings.Default.AESKEY);
                        if (string.IsNullOrWhiteSpace(ModeData))
                        {
                            ModeData = null;
                        }
                    }
                    if (modelLicenseTypeInfo.modeA != null)
                    {
                        ModeStartDate = common.DecryptToJsonString(modelLicenseTypeInfo.modeA, Properties.Settings.Default.AESKEY);
                        if (string.IsNullOrWhiteSpace(ModeStartDate))
                        {
                            ModeStartDate = null;
                        }
                        else
                        {
                            // Logic
                            _ = DateTime.TryParse(ModeStartDate, out LicenseStartDate);
                        }
                    }
                    if (modelLicenseTypeInfo.modeB != null)
                    {
                        ModeEndDate = common.DecryptToJsonString(modelLicenseTypeInfo.modeB, Properties.Settings.Default.AESKEY);
                        if (string.IsNullOrWhiteSpace(ModeEndDate))
                        {
                            ModeEndDate = null;
                        }
                        else
                        {
                            // Logic
                            _ = DateTime.TryParse(ModeEndDate, out LicenseEndDate);
                        }
                    }
                    if (ModeData != null)
                    {
                        if (ModeData == "Demo")
                        {
                            //DateTime oDate = DateTime.Now;
                            int res = DateTime.Compare(LicenseEndDate, DateTime.Now);
                            //res = -1;
                            if (res >= 0)
                            {
                                Flag = true;
                                Logic.LTypeValue = GetLicenseExpiryDays(LicenseEndDate, DateTime.Now);
                            }
                            else
                            {
                                Logic.isLicenseFileValid = false;
                                Logic.isActivationValid = false;
                            }
                        }
                        else
                        {
                            Flag = true;
                            Logic.LTypeValue = GetLicenseExpiryDays(LicenseEndDate, DateTime.Now);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return Flag;
        }

        private int GetLicenseExpiryDays(DateTime EndDate, DateTime CurrentDate)
        {
            int count = 0;
            try
            {
                count = (EndDate - CurrentDate).Days;
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Counting License Expiry Date", ex);
            }
            return count;
        }

        public ModelLicenseTypeInfo FetchLicenseType()
        {
            DataTable dataTable;
            string ModeData = null;
            ModelLicenseTypeInfo modelLicenseTypeInfo = new ModelLicenseTypeInfo();
            try
            {
                dataTable = GetCurrentLicenseType();
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        ModeData = dataTable.Rows[0]["mode"].ToString();
                        if (string.IsNullOrWhiteSpace(ModeData))
                        {
                            ModeData = null;
                        }
                        modelLicenseTypeInfo.mode = ModeData;
                        ModeData = dataTable.Rows[0]["modea"].ToString();
                        if (string.IsNullOrWhiteSpace(ModeData))
                        {
                            ModeData = null;
                        }
                        modelLicenseTypeInfo.modeA = ModeData;
                        ModeData = dataTable.Rows[0]["modeb"].ToString();
                        if (string.IsNullOrWhiteSpace(ModeData))
                        {
                            ModeData = null;
                        }
                        modelLicenseTypeInfo.modeB = ModeData;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return modelLicenseTypeInfo;
        }

        private DataTable GetCurrentLicenseType()
        {
            //Check Here
            DataTable dt = null;
            try
            {
                CommonData commonData = new CommonData();
                dt = commonData.getCommonMethodBySPNAME("CS_SP_GET_UPDATED_LICENSE_DATA_Mode");
            }
            catch (Exception ex)
            {
                ErrorManagement errorManagement = new ErrorManagement();
                errorManagement.ErrorMessage(MethodBase.GetCurrentMethod().Name, "Licensed Expired for Action", ex);
            }
            return dt;
        }
    }
}