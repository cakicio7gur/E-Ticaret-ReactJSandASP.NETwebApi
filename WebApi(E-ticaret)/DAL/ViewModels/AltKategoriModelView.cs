﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class AltKategoriModelView
    {
        public int altkategoriId { get; set; }
        [Required(ErrorMessage ="Lütfen alt kategori adı giriniz")]
        public string altkategori { get; set; }

        public int kategoriID { get; set; }
    }
}
