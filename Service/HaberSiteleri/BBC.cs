using Entity.Abstract;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entity.Abstract.Enums;

namespace Service.HaberSiteleri
{
    public class BBC : IHaberSitesi
    {
        public IWebDriver driver { get; set; }
        public Enums.Kategoriler Kategori { get; set; }
        public BBC(IWebDriver driver, Kategoriler kategori)
        {
            this.Kategori = kategori;
            this.driver = driver;
        }
        public string GetBaslik()
        {
            var list = driver.JsRun(@$"return document.querySelector('#content').innerText; ") as string;
            if (list != null)
            {
                return list;
            }
            return null;
        }
        public string GetIcerik()
        {
            var icerikList = driver.JsRun($@"return document.querySelectorAll('[role=main] > div > p, [role=main] > div > h2');") as ReadOnlyCollection<IWebElement>;
            if (icerikList == null)
            {
                return null;
            }
            string icerik = "";
            foreach (var item in icerikList)
            {
                icerik += item.Text;
            }
            return icerik;
        }
        public string GetKaynak()
        {
            return "BBC";
        }
        public DateTime? GetTarih()
        {
            string tarih = driver.JsRun("return document.querySelectorAll('.bbc-1dafq0j.e1mklfmt0')[0].getAttribute('datetime');") as string;
            if (tarih == null) return null;
            DateTime time = DateTime.Parse(tarih);
            return time;
        }
    }
}
