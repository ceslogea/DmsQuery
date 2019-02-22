using EfRepo.AOD;
using EfRepo.Context;
using EfRepo.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAppHiper.Controllers;

namespace WebAppHiper.Tests
{


    [TestClass]
    public class DmsTeste
    {
        private const object _dmsMockList = null;

        private DmsController _controller;
        private static DateTime _data = DateTime.Now;
        private Dms _dsmMock;
        //private const List<Dms> _dmsMockList = new List<Dms>() {
        //    new Dms()
        //    {
        //        DataCorte = DateTime.Now,
        //        DataProcessamento = DateTime.Now,
        //        DataVencimento = DateTime.Now,
        //        Quantidade = 21323,
        //        Carga = 333,
        //        Diferenca = 444
        //    }
        //};

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
            //_dmsMockList = new List<Dms>() { _dsmMock };
        }

        [TestMethod]
        [DataRow("0", moreData: new object[] { 1 })]
        [DataRow("1")]
        public void Get(string quantidadeElementos, object [] parans)
        {
            var dbMock = new Mock<HiperContextCF>();
            var serviceMock = new Mock<DmsAOD>(dbMock.Object);

            if (Convert.ToInt32(quantidadeElementos) == 0)
                serviceMock.Setup(r => r.ExecuteSql<Dms>(It.IsAny<string>())).Returns(new List<Dms>());
            //if (Convert.ToInt32(quantidadeElementos) == 1)
                //serviceMock.Setup(r => r.ExecuteSql<Dms>(It.IsAny<string>())).Returns(_dmsMockList);

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
