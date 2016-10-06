using Aizenk_temperament_test.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aizenk_temperament_test.ViewModels
{
    public class QuestionViewModel
    {
        public QuestionViewModel()
        {

        }

        public QuestionViewModel(Question qusetion)
        {
            Question = qusetion;
        }
        public Question Question { get; set; }


        [Required(ErrorMessage = "Выберите вариант")]
        public bool? Answer { get; set; }

    }
}