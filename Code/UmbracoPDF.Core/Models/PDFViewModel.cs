using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Core.Models.PublishedContent;
using System.Globalization;

namespace UmbracoPDF.Core.Models
{
    public class PDFViewModel : ContentModel  
    {
        public PDFViewModel(IPublishedContent content): base(content)  { }
        public string formData { get; set; }

        public Umbraco.Web.PublishedModels.PDfdownloadButton PDfdownloadButton { get; set; }
    }
}
