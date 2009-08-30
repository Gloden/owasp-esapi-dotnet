﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Owasp.Esapi.ValidationRules
{
    /// <summary>
    /// ESAPI builtint validation rules
    /// </summary>
    public static class BuiltinValidationRules
    {
        /// <summary>
        /// Printable validation rule
        /// </summary>
        public const string Printable = "Printable";
        /// <summary>
        /// Integer validation rule
        /// </summary>
        public const string Integer = "Integer";
        /// <summary>
        /// Double validation rule
        /// </summary>
        public const string Double = "Double";
        /// <summary>
        /// Date validation rule
        /// </summary>
        public const string Date= "Date";
        /// <summary>
        /// Regex validation rule
        /// </summary>
        public const string Regex = "Regex";
        /// <summary>
        /// Credit card validation rule
        /// </summary>
        public const string CreditCard = "CreditCard";
    }
}