﻿using System.Linq;
using System.Web.Http;
using System.Web.OData;
using WebAppODataV4.Database;

namespace WebAppODataV4.Controllers
{
    public class BusinessEntityController : ODataController
    {
        readonly DomainModel _db = new DomainModel();

        [EnableQuery(PageSize = 20)]
        public IHttpActionResult Get()
        {
            return Ok(_db.BusinessEntity.AsQueryable());
        }

        [EnableQuery(PageSize = 20)]
        public IHttpActionResult Get([FromODataUri] int key)
        {
            return Ok(_db.BusinessEntity.Find(key));
        }
        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
