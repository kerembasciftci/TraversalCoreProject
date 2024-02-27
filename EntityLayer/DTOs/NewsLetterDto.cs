using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs  
{
    public class NewsLetterDto
    {
        [Key]
        public int NewsLetterId { get; set; }
        public string Mail { get; set; }
    }
}
