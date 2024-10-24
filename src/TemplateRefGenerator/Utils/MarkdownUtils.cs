// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Text.RegularExpressions;

namespace TemplateRefGenerator;

public class MarkdownUtils
{
    public static string GetLink(string text, string destination)
        => $"[{text}]({destination})";

    public static string GetDocAnchor(string headingText)
        => "#" + Regex.Replace(headingText, "[^a-zA-Z0-9-]", "").ToLowerInvariant();

    public static string Ecsape(string input) => input
        .Replace("<br />", "\n")
        .Replace("<br/>", "\n")
        .Replace("<br>", "\n")
        .Replace("</br>", "\n")
        .Replace("<", "&lt;")
        .Replace(">", "&gt;")
        .Replace("\r", "")
        .Replace("\n", "<br />");
}