using EfRepo.AOD;
using System.Collections.Generic;

namespace HiperQueryDVA
{
    class Program
    {
        static void Main(string[] args)
        {
            var dmsAod = new DmsAOD();
            var result = dmsAod.Get();
            List<DmsViewModel> frontEndResult = DmsViewModel.FromList(result);
        }
    }
}
