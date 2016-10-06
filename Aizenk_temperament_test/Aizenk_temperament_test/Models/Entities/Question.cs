
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aizenk_temperament_test.Models.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public bool Answer { get; set; }

    }
}