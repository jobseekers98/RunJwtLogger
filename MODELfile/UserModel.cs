﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MODELfile
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public DateTime Timestamp { get; set; }


    }
}