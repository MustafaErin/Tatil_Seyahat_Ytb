﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Ytb.Models.Entities
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Kullanıcı { get; set; }
        public string Sifre { get; set; }
    }
}