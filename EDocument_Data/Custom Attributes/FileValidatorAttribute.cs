using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.Linq;

public class FileValidationAttribute : ValidationAttribute
{
    private readonly long _maxFileSize;
    private readonly string[] _allowedFileTypes;

    public FileValidationAttribute(long maxFileSize, params string[] allowedFileTypes)
    {
        _maxFileSize = maxFileSize;
        _allowedFileTypes = allowedFileTypes;
    }

    public FileValidationAttribute(long maxFileSize, bool allowMultipleFiles, params string[] allowedFileTypes)
        : this(maxFileSize, allowedFileTypes) =>  AllowMultipleFiles = allowMultipleFiles;
  

    public bool AllowMultipleFiles { get; set; } = false;


    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is IFormFile file)
        {
            return ValidateFile(file);
        }
        else if (value is IList<IFormFile> files && AllowMultipleFiles)
        {
            foreach (var item in files)
            {
                var validationResult = ValidateFile(item);
                if (validationResult != ValidationResult.Success)
                {
                    return validationResult;
                }
            }
        }
        else
        {
            return new ValidationResult("Invalid input type");
        }

        return ValidationResult.Success;
    }

    private ValidationResult ValidateFile(IFormFile file)
    {
        if (file.Length > _maxFileSize)
        {
            return new ValidationResult($"File size must be less than {_maxFileSize / 1024 / 1024} MB.");
        }

        var fileExtension = System.IO.Path.GetExtension(file.FileName).ToLower();

        if (!_allowedFileTypes.Contains(fileExtension))
        {
            return new ValidationResult($"Only the following file types are allowed: {string.Join(", ", _allowedFileTypes)}.");
        }

        return ValidationResult.Success;
    }
}
