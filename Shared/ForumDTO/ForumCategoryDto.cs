﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SharpScape.Shared.Dto
{
    public class ForumCategoryDto 
    {
       
        public int Id { get; set; }

        public string Name{ get; set; }
        public string Description { get; set; }

     
    }
}
