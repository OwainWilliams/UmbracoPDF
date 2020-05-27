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

namespace Umbraco.Web.PublishedModels
{
    public partial class PDfdownloadButton
    {

        public string ButtonLink
        {
            get
            {
                if (!string.IsNullOrEmpty(this.LinkText)) return this.LinkText;
                return this.LinkText;
            }
        }
        public string formData { get; set; }

    }
}
