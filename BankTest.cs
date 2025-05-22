using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void Wpłata_Zwiekszenie_stanu_konta()
        {
            var konto = new Bank(1, 200);
            var wynik = konto.wplata(100);
            Assert.IsTrue(wynik);
            Assert.AreEqual(300, konto.getStanKonta());
        }
        [TestMethod]
        public void Nieprawidlowy_stan_konta()
        {
            var konto = new Bank(1, 200);
            var wynik = konto.wplata(-50);
            Assert.IsFalse(wynik);
            Assert.AreEqual(200, konto.getStanKonta());
        }
        [TestMethod]
        public void Wyplata_Zmniejszenie_stan_konta()
        {
            var konto = new Bank(1, 200);
            var wynik = konto.wyplata(50);
            Assert.IsTrue(wynik);
            Assert.AreEqual(150, konto.getStanKonta());
        }
        [TestMethod]
        public void Wyplata_ZbytDuży_stan_konta()
        {
            var konto = new Bank(1, 100);
            var wynik = konto.wyplata(150);
            Assert.IsFalse(wynik);
            Assert.AreEqual(100, konto.getStanKonta());
        }
        [TestMethod]
        public void Wyplata_Nieprawidlowy_stan_konta()
        {
            var konto = new Bank(1, 100);
            var wynik = konto.wyplata(-10);
            Assert.IsFalse(wynik);
            Assert.AreEqual(100, konto.getStanKonta());
        }
    };
}
