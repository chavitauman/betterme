//qdsad
//34
git branch -l -a﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [Table("T_DOMAIN_PROP")]
    public class DomainProp:BaseEntity 
    {
        [Key]
      public int Id { get; set; }
      public Domains DomainID { get; set; } 
 		[MaxLength(10)]
      public string PropName { get; set; }  
		[MaxLength(10)]
      public string PropDesc { get; set; }  		
      public string PropVal { get; set; }  		
      public bool PropUser { get; set; }  		
      public bool PropActive { get; set; }  		
    }
}
 //my comment
//333
//6666
//again
//4
//5
