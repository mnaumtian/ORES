using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORES.ViewModels
{
    public class EvaluationViewModel
    {
        public Evaluation Evaluation { get; set; }
        public SelectList RevieweeList { get; set; }
        public SelectList GroupList { get; set; }
        public int SelectedReviewee { get; set; }
        public int SelectedGroup { get; set; }
    }
}