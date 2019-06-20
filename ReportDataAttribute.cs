using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpExcercises {
    public class ReportDataAttribute : ValidationAttribute {
        private readonly string _comparisonProperty;

        private readonly int tereshHoldAge;

        public ReportDataAttribute () {
        // public ReportDataAttribute (string comparisonProperty) {
            // _comparisonProperty = comparisonProperty;
        }

        protected override ValidationResult IsValid (object value, ValidationContext validationContext) {
            ErrorMessage = ErrorMessageString;
            var currentValue = (int) value;

            var property = validationContext.ObjectType.GetProperty (_comparisonProperty);

            if (property == null)
                throw new ArgumentException ("Property with this name not found");

            var comparisonValue = (int) property.GetValue (validationContext.ObjectInstance);

            if (currentValue < tereshHoldAge)
                return new ValidationResult (ErrorMessage);

            return ValidationResult.Success;
        }

    }
}