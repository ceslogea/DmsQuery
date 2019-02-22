using EfRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfRepo.AOD.Interfaces
{
    public interface IDms
    {
        List<Dms> Get();
    }

}
