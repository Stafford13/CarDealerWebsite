using System;
using GuildCars.Models.Tables;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.Models
{
    public class CarAddViewModel
    {
        public IEnumerable<SelectListItem> Specials { get; set; }
        public Car Car { get; set; }
        public HttpPostedFileBase ImageUpload { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Car.Body))
            {
                errors.Add(new ValidationResult("Body is required"));
            }

            if (string.IsNullOrEmpty(Car.ExColor))
            {
                errors.Add(new ValidationResult("An exterior color is required"));
            }

            if (string.IsNullOrEmpty(Car.IntColor))
            {
                errors.Add(new ValidationResult("An interior color is required"));
            }

            if (string.IsNullOrEmpty(Car.Type))
            {
                errors.Add(new ValidationResult("Type is required"));
            }

            if (Car.MSRP < 0)
            {
                errors.Add(new ValidationResult("MSRP must be greater than or equal to 0"));
            }

            if (Car.Price < 0)
            {
                errors.Add(new ValidationResult("Price must be greater than or equal to 0"));
            }

            //if (string.IsNullOrEmpty(Car.MakeName))
            //{
            //    errors.Add(new ValidationResult("The make of the car is required"));
            //}

            //if (string.IsNullOrEmpty(Car.ModelName))
            //{
            //    errors.Add(new ValidationResult("The model of the car is required"));
            //}

            if (ImageUpload != null && ImageUpload.ContentLength > 0)
            {
                var extensions = new string[] { ".jpg", ".png", ".gif", ".jpeg" };

                var extension = Path.GetExtension(ImageUpload.FileName);

                if (!extensions.Contains(extension))
                {
                    errors.Add(new ValidationResult("Image file must be a jpg, png, gif, or jpeg."));
                }
            }
            else
            {
                errors.Add(new ValidationResult("Image file is required"));
            }

            if (Car.Year <= 2000 && Car.Year >= 2020)
            {
                errors.Add(new ValidationResult("Year must be between 2000 and 2020"));
            }

            if (Car.Mileage < 0)
            {
                errors.Add(new ValidationResult("Milage must be greater than or equal to 0"));
            }

            return errors;
        }
    }
}