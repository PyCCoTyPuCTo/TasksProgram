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
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        [AllowHtml]
        [MaxLength(20)]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Поле \"Текст\" пустое")]
        [MaxLength(100)]
        [Display(Name = "Текст")]
        public string Record { get; set; }
    }
}