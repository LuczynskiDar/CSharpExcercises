using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpExcercises {
    public class ReportDataAttribute : ValidationAttribute {

        public bool My {get; set;}
        public  override bool IsValid(object value)
        {
            return  false;
        }

        // private readonly string _comparisonProperty;

        // private readonly int tereshHoldAge = 30;

        // public ReportDataAttribute () {
        // // public ReportDataAttribute (string comparisonProperty) {
        //     // _comparisonProperty = comparisonProperty;
        // System.Console.WriteLine("currentValue < tereshHoldAge");

        // }

        // protected override ValidationResult IsValid (object value, ValidationContext validationContext) {
        //     ErrorMessage = ErrorMessageString;
        //     var currentValue = (int) value;

        //     var property = validationContext.ObjectType.GetProperty (_comparisonProperty);

        //     if (property == null)
        //         throw new ArgumentException ("Property with this name not found");

        //     var comparisonValue = (int) property.GetValue (validationContext.ObjectInstance);

        //     System.Console.WriteLine("currentValue < tereshHoldAge");
        //     System.Console.WriteLine(currentValue < tereshHoldAge);
        //     if (currentValue < tereshHoldAge)
        //         return new ValidationResult (ErrorMessage);

        //     return ValidationResult.Success;
        // }

    }
}