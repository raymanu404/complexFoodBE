﻿using System.Text.RegularExpressions;

namespace Domain.ValueObjects;

public record struct Name
{
    private readonly Regex onlyLetters = new(@"^[a-zA-Z]|[A-Za-z]+$");

    public Name(string value)
    {
        if (value == null) throw new ArgumentNullException(nameof(value));
         Value = onlyLetters.IsMatch(value) ? value : "";
    }

    public string Value { get; set; }
}