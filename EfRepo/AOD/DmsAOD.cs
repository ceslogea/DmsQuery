using EfRepo.AOD.Interfaces;
using EfRepo.Context;
using EfRepo.Models;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace EfRepo.AOD
{
    public class DmsAOD : IDms
    {
        private string _nameOrConnectionString;
        private HiperContextCF _entities;

        public DmsAOD(HiperContextCF entities)
        {
            _entities = entities;
        }

        public DmsAOD(string nameOrConnectionString)
        {
            _nameOrConnectionString = nameOrConnectionString;
            _entities = new HiperContextCF(_nameOrConnectionString);
        }

        public List<Dms> Get()
        {
            var sql = @"select 
                        cast(floor(cast(getdate() as float)) as datetime) as 'DataCorte', 
                        cast(floor(cast(getdate() as float)) as datetime) as 'DataProcessamento', 
                        cast(floor(cast(getdate() as float)) as datetime) as DataVencimento, 
                        SUM(3360) as Quantidade, 
                        SUM(224) as Carga,
                        1213 as 'Diferença'";

            var dmss = ExecuteSql<Dms>(sql);

            return dmss;
        }

        public virtual List<T> ExecuteSql<T>(string sql)
        {
            return _entities.Database.SqlQuery<T>(sql).ToList();
        }
    }
}
