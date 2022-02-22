using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MODELfile
{
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }
        [Display(Name = "UID")]
        public virtual int UID { get; set; }

        [ForeignKey("UID")]
        public virtual UserModel User { get; set; }

        [Display(Name = "RoleID")]
        public virtual int RoleID { get; set; }

        [ForeignKey("RoleID")]
        public virtual Role RID { get; set; }
    }
}
