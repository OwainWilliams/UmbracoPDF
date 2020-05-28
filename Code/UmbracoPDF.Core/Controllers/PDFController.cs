using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;

namespace UmbracoPDF.Core.Controllers
{
    
    public class PDFController:SurfaceController
    {
        [HttpPost]
        public ActionResult GeneratePDF(PDfdownloadButton content)
        {


            string fileName = content.formData;
            
            var xpath = Umbraco.ContentSingleAtXPath("//pDFTemplate");

            // Added Umbraco.Core reference to allow to use IsNullOrWhiteSpace helper.
            if(fileName.IsNullOrWhiteSpace())
            {
                fileName = "OwainCodes.PDF";
            }
            

            return new Rotativa.UrlAsPdf("https://www.owain.codes")
            {
                FileName = fileName
            };

        }
    }
}