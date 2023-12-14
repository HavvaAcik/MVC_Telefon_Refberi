using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace MVCRehberUyg.Models
{
    public class Kisiler
    {
        [Key]
        public int? KisiNo {get; set;}
        public string? Ad {get; set;}
        public string? Soyad {get; set;}
        public long? TelefonNo {get; set;}
        public string? Resim {get; set;}
        // bos bırakılabilir bir alan olması için ? ekledik.
    }
}