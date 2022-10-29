using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entity.Abstract.Enums;

namespace Entity.Abstract
{
    public interface IHaberSitesi
    {
        Kategoriler Kategori { get; set; }
        IWebDriver driver { get; set; }
        public string GetBaslik();
        public string GetKaynak();
        public DateTime? GetTarih();
        public string GetIcerik();

    }
}
