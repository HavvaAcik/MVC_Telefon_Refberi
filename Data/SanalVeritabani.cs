using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCRehberUyg.Models;

namespace MVCRehberUyg.Data
{
    public class SanalVeritabani
    {
        public List<Kisiler> Kisilers = new List<Kisiler>()
        {
          new Kisiler {KisiNo = 1001, Ad = "Ahmet", Soyad = "ÇOKÇALIŞIR",TelefonNo=05550000000, Resim = "ahmet.jpg"},
          new Kisiler {KisiNo = 1, Ad = "Hasan", Soyad = "YORULMAZ",TelefonNo=05555555555,Resim = "hasan.jpg"},
          new Kisiler {KisiNo = 2, Ad = "Ayşe", Soyad = "İŞYAPAR",TelefonNo=05554444444,Resim = "ayse.jpg"},
          new Kisiler {KisiNo = 3, Ad = "Hatice", Soyad = "İŞBİLİR",TelefonNo=05553333333, Resim = "hatice.jpg"},
          new Kisiler {KisiNo = 4, Ad = "Zeynep", Soyad = "HEPÇALIŞIR",TelefonNo=05556666666, Resim = "zeynep.jpg"},
          new Kisiler {KisiNo = 5, Ad = "Mehmet", Soyad = "HİÇDURMAZ",TelefonNo=05557777777, Resim = "mehmet.jpg"},
          new Kisiler {KisiNo = 6, Ad = "Hüseyin", Soyad = "KULAKASMAZ",TelefonNo=05558888888, Resim = "huseyin.jpg"},
          new Kisiler {KisiNo = 1008, Ad = "Fatma", Soyad = "DURAKBİLMEZ",TelefonNo=05559999999, Resim = "fatma.jpg"},
        };
    }
}