using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TasksProgram.Models
{
    public class Task
    {
        public int ID { get; set; }
        [MaxLength(20)]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [MaxLength(100)]
        [Display(Name = "Текст")]
        public string Record { get; set; }
    }
}