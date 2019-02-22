using System;
using System.Collections.Generic;
using EfRepo.Models;
using Newtonsoft.Json;

namespace HiperQueryDVA
{
    public class DmsViewModel
    {
        private Dms item;

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

        public DmsViewModel(Dms item)
        {
            this.item = item;
        }

        internal static List<DmsViewModel> FromList(List<Dms> dmsAod)
        {
            var listDmsViewModel = new List<DmsViewModel>();
            foreach (var item in dmsAod) listDmsViewModel.Add(new DmsViewModel(item));
            return listDmsViewModel;
        }
    }
}
