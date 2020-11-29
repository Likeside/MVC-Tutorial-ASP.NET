using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MVC_Tutorial.CustomAttributes;

namespace MVC_Tutorial.Models
{
    public class WebUser
    {
        [Required]
        [StringLength(25, ErrorMessage = "Никнейм не может быть длинее 25 символов")]
        [Display(Name = "Nickname")]
        public string NickName { get; set; }
        [Required(ErrorMessage = "Имя обязательно")]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [WebUserBirthdayValidation]
        public DateTime Birthday { get; set; }
        public int Id { get; }

        public WebUser()
        {
        
        }
        public WebUser(List<WebUser> listOfUsers = null)
        {
            if (listOfUsers != null)
            {
                listOfUsers?.Add(this);
                this.Id = listOfUsers.Count;
            }
        }
    }
}