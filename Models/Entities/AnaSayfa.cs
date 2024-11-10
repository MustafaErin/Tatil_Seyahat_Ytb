﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Tatil_Seyahat_Ytb.Models.Entities
{
    public class AnaSayfa
    {
        [Key]
        public int Id { get; set; }
        public string Baslık { get; set; }
        public string Acıklama { get; set; }
    }
}