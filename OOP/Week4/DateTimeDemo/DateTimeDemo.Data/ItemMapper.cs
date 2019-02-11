using System;
using DateTimeDemo.Models;

namespace DateTimeDemo.Tests
{
    public class ItemMapper 
    {
        public static string ToStringCsv(Item obj)
        {
            return $"{obj.Id}::{obj.CharacterId}::{obj.Name}::{obj.Description}::{obj.Cost:F}";
        }

        public static Item ToObject(string row)
        {
            string[] fields = row.Split(new string[] { "::" }, StringSplitOptions.None);

            Item result = new Item()
            {
                Id = int.Parse(fields[0]),
                Name = fields[2],
                Description = fields[3],
                Cost = decimal.Parse(fields[4])
            };
            if (fields[1] != "")
            {
                result.CharacterId = int.Parse(fields[1]);
            }
            return result;
        }
    }

   
}