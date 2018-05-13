using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AstonProject.Models
{
    public class Question
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Quest { get; set; }
        public string Answer { get; set; }
        public double Note { get; set; }
        public int NbNote { get; set; }
        public int NbUsing { get; set; }
        public int NbComment { get; set; }
    }
}