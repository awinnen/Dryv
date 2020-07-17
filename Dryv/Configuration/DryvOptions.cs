﻿using System;
using Dryv.Validation;

namespace Dryv.Configuration
{
    public class DryvOptions
    {
        public static readonly Type DefaultClientFunctionWriterType = typeof(DryvClientValidationFunctionWriter);
        public static readonly Type DefaultClientValidationSetWriterType = typeof(DryvClientValidationSetWriter);
        public Type ClientFunctionWriterType { get; internal set; } = DefaultClientFunctionWriterType;
        public Type ClientValidationSetWriterType { get; internal set; } = DefaultClientValidationSetWriterType;
        public bool DisableAutomaticValidation { get; set; }
        public Func<object, string> JsonConversion { get; set; }
        public TranslationErrorBehavior TranslationErrorBehavior { get; set; }
    }
}