using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Tatil_Seyahat_Ytb.Models.Entities
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}