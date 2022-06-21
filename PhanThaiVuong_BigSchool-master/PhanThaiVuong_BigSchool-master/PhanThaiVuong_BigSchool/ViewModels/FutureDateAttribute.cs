using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PhanThaiVuong_BigSchool.ViewModels
{
    internal class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/M/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None,
                out dateTime);


            return isValid && dateTime > DateTime.Now;

        }

       
    }
}