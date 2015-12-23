using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORES.ViewModels
{
    public class EvaluationManagementViewModel
    {
        public SelectList QuestionList { get; set; }
        public IEnumerable<EvaluationManagement> EvaluationMangementList { get; set; }
        public EvaluationManagement EvaluationMangement { get; set; }
        [Required(ErrorMessage = "Please Select a Question...")]
        public int SelectedQuestion { get; set; }
        public int EvaluationId { get; set; }
    }
}