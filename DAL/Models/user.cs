using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    [Table("user", Schema = "dbo")]
   public class user
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string user_username { get; set; }

        [Required]
        [Display(Name = "UserPassword")]
        public string user_password { get; set; }

        [Required]
        [Display(Name = "FirstName")]
        public string user_firstname { get; set; }

        [Required]
        [Display(Name = "UserLastName")]
        public string user_lastname { get; set; }

        [Required]
        [Display(Name = "UserGender")]
        public int user_gender { get; set; }

        [Required]
        [Display(Name = "UserEmail")]
        public string user_email { get; set; }

        [Required]
        [Display(Name = "UserPhone")]
        public string user_phone { get; set; }

        [Required]
        [Display(Name = "UserBirthday")]
        public DateTime user_birthday { get; set; }

        [Display(Name = "UserAvatar")]
        public string user_avatar { get; set; }

        [Required]
        [Display(Name = "UserStatus")]
        public int user_status { get; set; }

        [Required]
        [Display(Name = "UserCreatedBy")]
        public int user_created_by { get; set; }

        [Display(Name = "UserCreatedAt")]
        public DateTime? user_created_at { get; set; } = DateTime.Now;

        [Display(Name = "UserUpdatedBy")]
        public DateTime? user_updated_by { get; set; }

        [Required]
        [Display(Name = "IsDeleted")]
        public int user_isdeleted { get; set; } = 0;

        [Display(Name = "user_token")]
        public string user_token { get; set; }

    }
}
