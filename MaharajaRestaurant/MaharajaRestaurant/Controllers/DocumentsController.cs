using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using MaharajaRestaurant.DAL;

namespace ReservationController.Controllers
{
    [RoutePrefix("Documents")]
    [AllowAnonymous]
    public class DocumentsController : Controller
    {
        [Route("{title}")]
        public FileContentResult Index(string title)
        {
            byte[] data;
            string basedpath = Server.MapPath("/Documents/");
            string temp = title.Replace("-", "_");
            string displayfilename = temp + ".pdf";
            DocumentsType doctype = (DocumentsType)Enum.Parse(typeof(DocumentsType), temp);
            string filename = doctype == DocumentsType.Terms_and_Conditions ? "tc_16105D23-086E-4F61-B0C2-6E858C1C6D4F.pdf" : "pp_EEF86C55-0B07-430C-9A7F-D3C81D350B3A.pdf";

            try
            {
                FileStream stream = new FileStream(basedpath + @"\" + filename, FileMode.Open, FileAccess.Read);
                data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);
                string mimeType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "inline; filename=" + displayfilename);
                stream.Close();
                return File(data, mimeType);
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}