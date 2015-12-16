﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace NewFakeBookMarkIII.Helpers
{
    public class LocalFIleHandler
    {
        public List<string> GetFileNames()
        {
            var uploadDir = System.Web.HttpContext.Current.Server.MapPath("~/images");
            List<string> names = Directory.EnumerateFiles(uploadDir).ToList();

            return names;

        }

        public void Upload(HttpPostedFileBase file)
        {
            // code for saving in the local file system
            var uploadDir = "~/images";
            if (file.ContentLength > 0)
            {
                var fname = Path.GetFileName(file.FileName);
                var path = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(uploadDir), fname);
                try
                {
                    file.SaveAs(path);
                }
                catch (NotImplementedException e)
                {
                    string m = e.Message;
                }
            }

            //     var path = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(uploadDir), Path.GetFileName(file.FileName));
            //     var imageUrl = uploadDir + "/" + Path.GetFileName(file.FileName);
            //     file.SaveAs(path);
        }
    }
}