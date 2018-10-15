using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using FileValidationAndMapping.Validation;
using FileValidationAndMapping.Validation.Validators;

namespace ConversionTest
{
    [TestClass]
    public class ValidationTests
    {

        public void IsNumber_WithDecimalWorks()
        {
            var numVal = new NumberValidator();

            var result = numVal.IsValid("1234.12", "Temp");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_WithIntegerWorks()
        {
            var numVal = new NumberValidator();

            var result = numVal.IsValid("123", "Temp");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNumber_WithLettersFails()
        {
            var numVal = new NumberValidator();

            var result = numVal.IsValid("1a234.12", "Temp");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsRequiredTest_Empty()
        {
            var isReq = new IsRequired();
            var result = isReq.IsValid("", "Temp");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsRequiredTest_WithValue()
        {
            var isReq = new IsRequired();
            var result = isReq.IsValid("This has a value", "Temp");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidGenderTest_Fail()
        {
            var isReq = new GenderValidator();
            var result = isReq.IsValid("x", "Gender");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidGenderTest_HappyPath()
        {
            var validator = new GenderValidator();
            validator.CompareList = "M,F,Male,Female,sire,dam,heifer,steer".Split(',').ToList();
            var result = validator.IsValid("m", "Gender");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HeaderValidation_HappyPath()
        {
            var valProc = new ValidationProcessor(new List<ValidatorDef>());

            var expectedHeaders = new List<string>() { "h1", "h2", "h3", "h4" };
            var actualHeaders = new List<string>() { "h1", "h2", "h3", "h4" };

            var result = valProc.HeaderValidation(expectedHeaders, actualHeaders);

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void HeaderValidation_MissingColumns()
        {
            var valProc = new ValidationProcessor(new List<ValidatorDef>());

            var expectedHeaders = new List<string>() { "h1", "h2", "h3", "h4" };
            var actualHeaders = new List<string>() { "h1", "h2", "h3" };

            var result = valProc.HeaderValidation(expectedHeaders, actualHeaders);

            Assert.IsFalse(result, valProc.ErrorMessages.ToString());
            Console.WriteLine(valProc.ErrorMessages.ToString());
        }
    }
}