using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORES.ViewModels
{
    public class FormRightMatrix : BusinessObjectLayer.Form
    {
        public bool IsView;
        public bool IsAdd;
        public bool IsDeleteRight;
        public bool IsUpdate;
        
        private FormRightMatrix()
        { }

        public static IEnumerable<FormRightMatrix> GetFormRights()
        {
            BusinessLogicLayer.FormBLL formbll = new BusinessLogicLayer.FormBLL();
            IEnumerable<BusinessObjectLayer.Form> forms = formbll.GetAllForms();
            List<FormRightMatrix> rightsMatrix = new List<FormRightMatrix>();
            FormRightMatrix f = null;
            foreach(BusinessObjectLayer.Form frm in forms)
            {
                f = new FormRightMatrix();
                f.FormId = frm.FormId;
                f.FormName = frm.FormName;
                f.FormPath = frm.FormPath;
                f.CreatedBy = frm.CreatedBy;
                f.CreatedOn = frm.CreatedOn;
                f.IsAdd = false;
                f.IsUpdate = false;
                f.IsDeleteRight = false;
                f.IsView = false;
                f.IsDelete = frm.IsDelete;
                f.ModifiedBy = frm.ModifiedBy;
                f.ModifiedOn = frm.ModifiedOn;
                f.RolesRightsManagements = frm.RolesRightsManagements;
                rightsMatrix.Add(f);
            }
            return rightsMatrix.AsEnumerable();
        }
    }
}