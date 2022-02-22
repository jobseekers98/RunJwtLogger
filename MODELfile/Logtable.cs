using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MODELfile
{
    public class Logtable
    {

        [Key]

        public int Id { get; set; }
        public string Application { get; set; }
        public string ErrorMessage { get; set; }

        public string ErrorDetails { get; set; }

        public string ExtraInformation { get; set; }





    }
}
