using EfRepo.AOD;
using System;
using System.Collections.Generic;
using System.Web.Http;
using WebAppHiper.Models;

namespace WebAppHiper.Controllers
{
    public class DmsController : ApiController
    {
        private DmsAOD _dmsAod;

        public DmsController()
        {
            _dmsAod = new DmsAOD("Name=HiperContextCF");
        }

        public DmsController(DmsAOD service)
        {
            _dmsAod = service;
        }

        // GET: api/Dms
        public IEnumerable<DmsViewModel> Get()
        {
            return DmsViewModel.FromList(_dmsAod.Get());
        }

        // GET: api/Dms/5
        public DmsViewModel Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Dms
        public DmsViewModel Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Dms/5
        public DmsViewModel Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Dms/5
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
