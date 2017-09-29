using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasksProgram.Models
{
    public class Task
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        [MaxLength(20)]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполненым")]
        [MaxLength(100)]
        [Display(Name = "Текст")]
        public string Record { get; set; }
    }
}