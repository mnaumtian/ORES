using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORES.ViewModels
{
    public class QuestionViewModel
    {
        public SelectList AnswerTypeList { get; set; }
        public int SelectedAnswerType { get; set; }
        public Question Question { get; set; }
    }
}