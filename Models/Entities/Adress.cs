using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Ytb.Models.Entities
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }
        public string Baslık { get; set; }
        public string Acıklama { get; set; }
        public string adres { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }
    }
}