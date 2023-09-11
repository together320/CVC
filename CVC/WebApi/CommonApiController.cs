using CVC.Data.EDMX;
using CVC.Modules.Common.CommonServices;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CVC.WebApi
{
    public class CommonApiController : ApiController
    {
        CommonServices objCommonServices = new CommonServices();

        [HttpGet]
        [ActionName("GetProtocolID")]
        public HttpResponseMessage GetProtocolID(int id)
        {
            return this.Request.CreateResponse<int>(HttpStatusCode.OK, objCommonServices.GetProtocolTypeIdID(id));
        }

        [HttpGet]
        [ActionName("GetAuthorization")]
        public HttpResponseMessage GetAuthorization(string PermissionKey)
        {
            return this.Request.CreateResponse<bool>(HttpStatusCode.OK, objCommonServices.GetAuthorization(PermissionKey));
        }
    }
}