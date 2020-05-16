using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Web.Mvc;

namespace UmbracoPDF.Core.Controllers
{
    
    public class PDFController:SurfaceController
    {
        [System.Web.Http.HttpPost]
        public ActionResult GeneratePDF(string fileName)
        {

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