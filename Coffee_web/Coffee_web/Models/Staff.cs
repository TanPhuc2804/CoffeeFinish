﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coffee_web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web.Services.Protocols;

    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.Orders = new HashSet<Order>();
        }
        [Required(ErrorMessage ="ID là bắt buộc")]
        public int id_staff { get; set; }

        [Required(ErrorMessage = "Tên là bắt buộc")]
        public string name_staff { get; set; }

        [Required(ErrorMessage = "Số đt là bắt buộc")]
        [RegularExpression("^[0-9]{1,10}$",ErrorMessage ="Sđt Không hợp lệ")]
        public int number_phone { get; set; }

        [Required(ErrorMessage = "Địa chỉ là bắt buộc")]
        public string address_live { get; set; }

        [Required(ErrorMessage = "Giới tính là bắt buộc")]
        public string gender { get; set; }

        public Nullable<int> id_area { get; set; }
        public string work_shift { get; set; }
  
        [Required(ErrorMessage = "Password là bắt buộc")]
        [StringLength(11, MinimumLength = 5, ErrorMessage = "Thấp nhất 5 ký tự nhiều nhất 11 ký tự")]
        [DataType("password")]
        public string password_staff { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Repassword là bắt buộc")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("password_staff", ErrorMessage = "Phải giống mật khẩu phía trên")]
        public string confirmPass { get; set; }
        public virtual Area Area { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
