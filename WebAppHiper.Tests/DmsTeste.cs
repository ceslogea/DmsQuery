using EfRepo.AOD;
using EfRepo.Context;
using EfRepo.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using WebAppHiper.Controllers;
using WebAppHiper.Tests.Helpers;

namespace WebAppHiper.Tests
{


    [TestClass]
    public class DmsTeste
    {
        private DmsController _controller;
        private DateTime _data;
        private Dms _dsmMock;
        private List<Dms> _dmsMockList;

        public DmsTeste()
        {
            _controller = new DmsController();
            _data = DateTime.Now;
            _dsmMock = new Dms()
            {
                DataCorte = _data,
                DataProcessamento = _data,
                DataVencimento = _data,
                Quantidade = 21323,
                Carga = 333,
                Diferenca = 444
            };
            _dmsMockList = new List<Dms>() { _dsmMock };
        }

        /// <summary>
        /// Verirca integridade com 0 elementos e 1 elemento na lista.
        /// </summary>
        /// <param name="quantidadeElementos"></param>
        [TestMethod]
        [DataRow("0")]
        [DataRow("1")]
        public void OneElementInList(string quantidadeElementos)
        {
            var dbMock = new Mock<HiperContextCF>();
            var serviceMock = new Mock<DmsAOD>(dbMock.Object);

             if (Convert.ToInt32(quantidadeElementos) == 0)
                serviceMock.Setup(r => r.ExecuteSql<Dms>(It.IsAny<string>())).Returns(new List<Dms>());
            if (Convert.ToInt32(quantidadeElementos) == 0)
                serviceMock.Setup(r => r.ExecuteSql<Dms>(It.IsAny<string>())).Returns(new List<Dms>());
            if(Convert.ToInt32(quantidadeElementos) == 1)
                serviceMock.Setup(r => r.ExecuteSql<Dms>(It.IsAny<string>())).Returns(_dmsMockList);
            serviceMock.CallBase = true;

            var controller = new DmsController(serviceMock.Object);
            var result = controller.Get();

            serviceMock.Verify(r => r.ExecuteSql<Dms>(It.IsAny<string>()), Times.AtLeastOnce());

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() == Convert.ToInt32(quantidadeElementos));
            //Assert.IsTrue(result.Count() > 0);
        }

    
    }
}
