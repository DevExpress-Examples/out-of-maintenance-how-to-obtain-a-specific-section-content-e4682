<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128610891/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4682)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to obtain a specific section content


<p>This example illustrates how to obtain the content of a <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditAPINativeSectiontopic">Section</a> which the caret position belongs to. There is no direct method to obtain the section range. However, you can construct this range based on section paragraphs:</p><p></p>

```cs
    ...
    DocumentPosition currentSectionStart = currentSection.Paragraphs[0].Range.Start;
    DocumentPosition currentSectionEnd = currentSection.Paragraphs[currentSection.Paragraphs.Count - 1].Range.End;
    ...
```

<p></p><p>After that you can use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSubDocument_GetTexttopic1005">SubDocument.GetText Method</a> to obtain the section content.</p><p></p><p>In addition, we illustrate how to calculate the current section and paragraph index.</p><p></p><p><strong>See Also:</strong></p><p><a href="https://www.devexpress.com/Support/Center/p/E2265">SubDocument essentials - simple examples</a></p><p><a href="https://www.devexpress.com/Support/Center/p/E3491">How to reset page numbering on a specific page</a></p><p><a href="https://www.devexpress.com/Support/Center/p/E3492">How to apply different headers/footers to different pages</a></p><p><a href="https://www.devexpress.com/Support/Center/p/E4404">How to merge documents with headers and footers into a single document</a></p>

<br/>


