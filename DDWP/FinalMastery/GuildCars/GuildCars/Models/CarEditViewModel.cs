using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.Models
{
    public class CarEditViewModel
    {
        public IEnumerable<SelectListItem> Specials { get; set; }
        public Car Car { get; set; }
        public HttpPostedFileBase ImageUpload { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Car.Body))
            {
                errors.Add(new ValidationResult("A body type is required"));
            }

            if (string.IsNullOrEmpty(Car.ExColor))
            {
                errors.Add(new ValidationResult("An exterior color is required"));
            }

            if (string.IsNullOrEmpty(Car.IntColor))
            {
                errors.Add(new ValidationResult("An interior color is required"));
            }

            //    if (string.IsNullOrEmpty(Listing.ListingDescription))
            //    {
            //        errors.Add(new ValidationResult("Description is required"));
            //    }

            //    if (ImageUpload != null && ImageUpload.ContentLength > 0)
            //    {
            //        var extensions = new string[] { ".jpg", ".png", ".gif", ".jpeg" };

            //        var extension = Path.GetExtension(ImageUpload.FileName);

            //        if (!extensions.Contains(extension))
            //        {
            //            errors.Add(new ValidationResult("Image file must be a jpg, png, gif, or jpeg."));
            //        }
            //    }

            //    if (Listing.Rate <= 0)
            //    {
            //        errors.Add(new ValidationResult("Rate must be greater than 0"));
            //    }

            //    if (Listing.SquareFootage <= 0)
            //    {
            //        errors.Add(new ValidationResult("Square footage must be greater than 0"));
            //}

            return errors;
            }
}
}