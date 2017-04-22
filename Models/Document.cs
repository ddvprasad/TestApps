using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class Document
    {

        public int? RelatedToValue { get; set; }

        public int? RelatedTo { get; set; }

        public int? EmployeeID { get; set; }

        public int? CompanyID { get; set; }

        public int DocumentID { get; set; }

        public string DocumentName { get; set; }

        public string DocumentTypeName { get; set; }

        public int? DocumentType { get; set; }

        public string strFilePathDocument { get; set; }

        public string FileName { get; set; }

        public List<SelectListItem> lstDocumentTypes { get; set; }

        public bool NewEmployeeFlag { get; set; }

        public bool IsEditEmployeeflag { get; set; }
    }


    public class DocumentType
    {
        public int DocumentTypeID { get; set; }

        public string Name { get; set; }

        public int CompanyID { get; set; }

        public string ActiveFlag { get; set; }
    }

    public class PropertyDocumentType
    {
        public int PropertyDocumentTypeID { get; set; }

        public string Name { get; set; }

        public int CompanyID { get; set; }

        public string ActiveFlag { get; set; }
    }
}
