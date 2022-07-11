using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class ImageUploadController : Controller
    {

        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly long maxSizeBytes = 8000000; // 8 MB
        private readonly string[] allowedFormats = {    "image/png",
                                                        "image/jpg", 
                                                        "image/jpeg"};
       
        public ActionResult Index()
        {

            return View();
        }

        public IActionResult Gallery()
        {
            List<string> images = Directory.GetFiles("wwwroot/uploaded_images").ToList();
            for (int i = 0; i < images.Count; i++)
            {
                images[i] = images[i].Split("/")[1];
            }

            return View(images);
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult New([FromForm] FileUploadModel model)
        {
            if (ModelState.IsValid)
            {
                string rejectionMsg = "";

                if (UploadIsLegal(model, out rejectionMsg))
                {
                    string uniqueFileName = UploadedFile(model);
                }

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        private bool UploadIsLegal(FileUploadModel model, out string rejectionMessage)
        {
            rejectionMessage = "No error detected";

            if (model == null)
            {
                rejectionMessage = "No file recieved";
                return false;
            }

            if (model.File.Length > maxSizeBytes)
            {
                rejectionMessage = $"File size exceeds maximum allowed ({maxSizeBytes} bytes)";
                return false;
            }

            bool legalFormatDetected = false;
            for (int i = 0; i < allowedFormats.Length; i++)
            {
                if (string.Equals(model.File.ContentType, allowedFormats[i], StringComparison.OrdinalIgnoreCase))
                {
                    legalFormatDetected = true;
                    break;
                }
            }

            if (legalFormatDetected == false)
            {
                rejectionMessage = "No legal file format detected, please use one of the following:";
                for (int i = 0; i < allowedFormats.Length; i++)
                {
                    rejectionMessage += " " + allowedFormats[i];
                }
                return false;
            }

            return true; 
        }

        private string UploadedFile(FileUploadModel model)
        {
            string uniqueFileName = null;

            if (model != null)
            {
                string uploadsFolder = "wwwroot/uploaded_images";
                string nameUnextended = model.File.FileName.Split(".")[0];
                string extension = model.File.FileName.Split(".")[1];
                uniqueFileName =nameUnextended + "_" + Guid.NewGuid().ToString() + "." + extension;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.File.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }


    }
}
