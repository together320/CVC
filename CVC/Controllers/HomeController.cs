using CVC.BusinessServices.Common;
using CVC.Configuration.Entities;
using CVC.Configuration.Repositories;
using CVC.License.Algorithms;
using CVC.OpcUaClient;
using Serenity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using static CVC.BusinessServices.Common.ClsEnum;

namespace CVC.Controllers
{
    [RoutePrefix("Home")]
    [Route("{action=index}")]
    public class HomeController : Controller
    {
        CommonServices objCommonServices = new CommonServices();


        public ActionResult Index()
        {

            ActivationManagement activationManagement = new ActivationManagement();

            Type t = activationManagement.GetType();

            MethodInfo[] mi = t.GetMethods();
            string name1 = MethodBase.GetCurrentMethod().Name;

            StringBuilder sb1 = new StringBuilder();
            foreach (MethodInfo m in mi)

            {
                sb1.Append(m.Name);
                sb1.AppendLine();
            }

            string path = AppDomain.CurrentDomain.BaseDirectory + "\\"+activationManagement;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = $"{AppDomain.CurrentDomain.BaseDirectory}\\{activationManagement}\\{activationManagement}.txt";

            // string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\BatchRunData\\BatchRunData_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!System.IO.File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter writer =System.IO.File.CreateText(filepath))
                {
                    writer.Write(sb1.ToString());
                    writer.Flush();
                    // sw.WriteLine(" At " + DateTime.Now.ToString() + " Section: " + Section + " Error: " + Message + " Value: " + Value);
                }
            }



            StringBuilder sb = new StringBuilder();
            foreach (var customString in DateTimeFormatInfo.CurrentInfo.GetAllDateTimePatterns('d'))
            {
                sb.Append(customString);
                sb.AppendLine();

            }
            var bb = sb.ToString();

            DateTime date = new DateTime(2019, 1,
                              30, 9, 49, 15);

            // getting format in string array 
            // using GetDateTimeFormats() method; 
            string[] valuesssss = date.GetDateTimeFormats();
            var sysFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            //Get the long date pattern of current culture
            string longdateformat = sysFormat.LongDatePattern.ToString();
            //Get the short date pattern of current culture
            string shotdateformat = sysFormat.ShortDatePattern.ToString();
            // Save the culture (to make the following code shorter).
            CultureInfo info = CultureInfo.InstalledUICulture;



            var iDateTimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            string dateString = "7/10/1974 7:10:24 AM";
            DateTime dateFromString =
    DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);

            // objCommonServices.GetEnumList(new RoleFormField());

            var formFieldList = objCommonServices.GetEnumList("role");

            var filterExpression = "(*)";
            ViewBag.MandatoryFormFieldsCount = formFieldList.Where(ffl => ffl.Text.Contains(filterExpression)).Count();
            IEnumerable<RoleFormField> values = Enum.GetValues(typeof(RoleFormField)).Cast<RoleFormField>();
            List<string> valuesWithSpaces = new List<string>(values.Select(v => v.ToString().Replace("_", " ")));

            foreach (RoleFormField enumElement in values)
            {
                Console.WriteLine($"Name: {enumElement}, Value: {(int)enumElement}");
            }
            Console.WriteLine();
            foreach (string stringRepresentation in valuesWithSpaces)
            {
                Console.WriteLine(stringRepresentation);
            }

            Array enumValueArray = Enum.GetValues(typeof(RoleFormField));
            foreach (int enumValue in enumValueArray)
            {
                var name = Enum.GetName(typeof(RoleFormField), enumValue);
                var value = enumValue;
                var description = RoleFormField.RoleName.GetEnumDescription();
                //MemberInfo property = typeof(RoleFormField).GetRuntimeField(name);
                //var dd = property.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute;   //Find Display Attribute
                Console.WriteLine("Name: " + Enum.GetName(typeof(RoleFormField), enumValue) + " , Value: " + enumValue);
            }
            //{
            //    IUni;
            //       CompanyRow companyRow = new CompanyRow
            //    {
            //        Address = ""
            //};
            //    return new CompanyRepository().Create(unitOfWork, companyRow);

            // ViewBag.Message = "Your contact page.";


            return View();
        }

        static List<string> GetClasses(string nameSpace)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            List<string> namespacelist = new List<string>();
            List<string> classlist = new List<string>();

            foreach (Type type in asm.GetTypes())
            {
                if (type.Namespace == nameSpace)
                    namespacelist.Add(type.Name);
            }

            foreach (string classname in namespacelist)
                classlist.Add(classname);

            return classlist;
        }


        private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return
              assembly.GetTypes()
                      .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                      .ToArray();
        }
    }
}