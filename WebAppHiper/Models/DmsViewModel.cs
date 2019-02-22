using EfRepo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppHiper.Models
{
    public class DmsViewModel
    {
        private readonly Dms item;

        [JsonProperty("dataCorte", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DataCorte { get; set; }
        [JsonProperty("dataProcessamento", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DataProcessamento { get; set; }
        [JsonProperty("dataVencimento", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DataVencimento { get; set; }
        [JsonProperty("quantidade", NullValueHandling = NullValueHandling.Ignore)]
        public int Quantidade { get; set; }
        [JsonProperty("carga", NullValueHandling = NullValueHandling.Ignore)]
        public int Carga { get; set; }
        [JsonProperty("diferenca", NullValueHandling = NullValueHandling.Ignore)]
        public int Diferenca { get; set; }

        public DmsViewModel(Dms dms)
        {
            DataCorte = dms.DataCorte;
            DataProcessamento = dms.DataProcessamento;
            DataVencimento = dms.DataVencimento;
            Quantidade = dms.Quantidade;
            Carga = dms.Carga;
            Diferenca = dms.Diferenca;
        }

        internal static List<DmsViewModel> FromList(List<Dms> dmsAod)
        {
            var listDmsViewModel = new List<DmsViewModel>();
            foreach(var item in dmsAod ?? Enumerable.Empty<Dms>()) listDmsViewModel.Add(new DmsViewModel(item));
            return listDmsViewModel;
        }
    }
}