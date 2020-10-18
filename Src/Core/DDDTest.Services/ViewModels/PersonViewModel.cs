using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DDDTest.Services.ViewModels
{
   public class PersonViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="وارد کردن نام  الزامی است")]
        [MinLength(2)]
        [MaxLength(150)]
        [DisplayName("نام")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "وارد کردن نام خانوادگی الزامی است")]
        [MinLength(2)]
        [MaxLength(150)]
        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }
    }
}
