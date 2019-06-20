using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharpExcercises {
    class Program {
        static void Main (string[] args) {
            // try {
            MyData myData = new MyData () {

                Age = 40,
                Name = "Daro",
                Surname = "Luczynski"
            };

            MyData myData1 = new MyData () {
                Age = 20,
                Name = "Daro",
                Surname = "Luczynski"
            };

            // } catch (System.Exception) {

            //     Console.WriteLine ("My catch");

            // }

            var context = new ValidationContext (myData, serviceProvider : null, items : null);
            var validationResults = new List<ValidationResult> ();
            bool isValid = Validator.TryValidateObject (myData, context, validationResults, true);

            
            // Validation Context
            // Any validation needs a context to give some information about what 
            // is being validated. This can include  various information such as 
            // he object to be validated, some properties, the name to display in the error message, etc.
      
            // ValidationContext vc = new ValidationContext (objectToValidate); // The simplest form of validation context. It contains only a reference to the object being validated.
            
            // Validate an Object and All of its Properties
      
            // ICollection<ValidationResult> results = new List<ValidationResult> (); // Will contain the results of the validation
            // bool isValid = Validator.TryValidateObject (objectToValidate, vc, results, true); // Validates the object and its properties using the previously created context.
            // The variable isValid will be true if everything is valid
            // The results variable contains the results of the validation

            // Validate a Property of an Object
      
            // ICollection<ValidationResult> results = new List<ValidationResult> (); // Will contain the results of the validation
            // bool isValid = Validator.TryValidatePropery (objectToValidate.PropertyToValidate, vc, results, true); // Validates the property using the previously created context.
            // The variable isValid will be true if everything is valid
            // The results variable contains the results of the validation

            Console.WriteLine ("Hello World!");
            System.Console.WriteLine (isValid);
        }
    }
}