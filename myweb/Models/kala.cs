using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace myweb.Models.DomainModel
{
[MetadataType(typeof(UserDto))]
    public partial class user
    {
        [Display(Name = "تکرار پسورد")]
        [Required(ErrorMessage = "لطفا  تکرار پسورد راوارد کنید")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="رمز عبور  یکسان نیست")]
        public string ConfirmPassword { get; set; }
    }
}
    
namespace myweb.Models
{



    internal class UserDto
    {
        public int Id { get; set; }
        [Display(Name ="نام")]
        [Required(ErrorMessage ="لطفا نام راوارد کنید")]
        [RegularExpression(@"^[آ-ی ء چ]+$", ErrorMessage ="حروف فارسی وارد کنید")]
        public string Name { get; set; }
        [Display(Name = " نام کاربری")]
        [Required(ErrorMessage = "لطفا نام خانوادگی راوارد کنید")]
        [RegularExpression(@"^[a-zA-Z].*@[a-zA-Z]+\.com")]
        public string UserName { get; set; }
        [Display(Name = "پسورد")]
        [Required(ErrorMessage = "لطفا پسورد راوارد کنید")]
       [MinLength(8,ErrorMessage ="حداکثر هشت کارکتر وارد کنید")]
       [RegularExpression(@"^[A-Za-z0-9_]+$")]
       [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "تاریخ تولد")]
       [DataType(DataType.Date)]
        public Nullable<System.DateTime> BrithDay { get; set; }
        [Display(Name = "موبایل")]
        [RegularExpression(@"09\d{9}",ErrorMessage ="09*********")]
        public string Mobile { get; set; }
        [Display(Name = "تلفن")]
       
        public string Tell { get; set; }
        [Display(Name = "جنسیت")]
        public bool Gender { get; set; }
        [Display(Name = "وضعیت")]
        public Nullable<byte> Status { get; set; }

    }
}