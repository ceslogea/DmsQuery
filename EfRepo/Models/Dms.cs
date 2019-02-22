using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfRepo.Models
{
    public class Dms
    {
        public DateTime DataCorte { get; set; }
        public DateTime DataProcessamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public int Quantidade { get; set; }
        public int Carga { get; set; }
        public int Diferenca { get; set; }
    }
}
