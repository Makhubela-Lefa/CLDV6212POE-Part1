// Controllers / UploadController.cs
using System.Linq.Expressions;
using System.Reflection;
using ABCRetailers.Models;
using ABCRetailers.Services;
using Microsoft.AspNetCore.Mvc;

namespace ABCRetailers.Controllers
{
    public class UploadController : Controller
    {
        private readonly IAzureStorageService _storageService;
        public UploadController(IAzureStorageService storageService)
        {
            _storageService = storageService; //added underscored
        }
        public IActionResult Index()
        {
            return View(new FileUploadModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(FileUploadModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.ProofOfPayment != null && model.ProofOfPayment.Length > 0)
                    {
                        //Upload to blob storage
                        var fileName = await _storageService.UploadFileAsync(model.ProofOfPayment, "payment-proofs"); //added underscore

                        //Also upload file to share for contracts
                        await _storageService.UploadToFileShareAsync(model.ProofOfPayment, "contracts", "payments"); //added underscore

                        //clear the model for a fresh form
                        TempData["Success"] = $"File uploaded successfully! File name: {fileName}"; // added underscore

                        //clear the model for a fresh form
                        return View(new FileUploadModel());
                    }
                    else
                    {
                        ModelState.AddModelError("ProofOfPayment", "Please select a file to upload.");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"Error uploading file: {ex.Message}");
                }
            }

            return View(model);
        }
    }

}


