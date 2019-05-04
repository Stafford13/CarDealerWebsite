using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuildCars.Models
{
    public class ContactViewModel : IValidatableObject
    {
        public Customer Customer { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Customer.FirstName))
            {
                errors.Add(new ValidationResult("First Name is required"));
            }

            if (string.IsNullOrEmpty(Customer.LastName))
            {
                errors.Add(new ValidationResult("Last Name is required"));
            }

            if (string.IsNullOrEmpty(Customer.Email))
            {
                errors.Add(new ValidationResult("Email Address is required"));
            }
            //if (Customer.Email != fix this!!)
            //{
            //    errors.Add(new ValidationResult("A correct Email address is required"));
            //}

            if (string.IsNullOrEmpty(Customer.Phone))
            {
                errors.Add(new ValidationResult("Phone is required"));
            }
            //if (Customer.Phone != fix this!!)
            //{
            //    errors.Add(new ValidationResult("a correct phone number is required"));
            //}

            if (string.IsNullOrEmpty(Customer.Message))
            {
                errors.Add(new ValidationResult("Message is required"));
            }

            return errors;
        }
}