using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MODELfile
{
    public class Logdata
    {
        [Key]

        public int Id { get; set; }
        public string ErrorMessage { get; set; }

        public string ErrorDetails { get; set; }

        public string ExtraInformation { get; set; }


    }
}
