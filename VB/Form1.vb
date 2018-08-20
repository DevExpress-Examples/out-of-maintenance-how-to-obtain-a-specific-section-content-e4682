Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditSectionContent
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            Dim path As String = System.IO.Directory.GetCurrentDirectory() & "\..\..\Template.rtf"

            richEditControl1.LoadDocument(path)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim document As Document = richEditControl1.Document

            Dim currentSection As Section = document.GetSection(document.CaretPosition)
            Dim currentParagraph As Paragraph = document.Paragraphs.Get(document.CaretPosition)

            For i As Integer = 0 To document.Sections.Count - 1
                If document.Sections(i).Equals(currentSection) Then
                    MessageBox.Show("Current Section Index: " & (i + 1).ToString())
                    Exit For
                End If
            Next i

            For i As Integer = 0 To currentSection.Paragraphs.Count - 1
                If currentSection.Paragraphs(i).Equals(currentParagraph) Then
                    MessageBox.Show("Current Paragraph In Section Index: " & (i + 1).ToString())
                    Exit For
                End If
            Next i

            Dim currentSectionStart As DocumentPosition = currentSection.Paragraphs(0).Range.Start
            Dim currentSectionEnd As DocumentPosition = currentSection.Paragraphs(currentSection.Paragraphs.Count - 1).Range.End

            Dim currentSetionText As String = document.GetText(document.CreateRange(currentSection.Range)

            MessageBox.Show("Current Setion Text (PlainText Format):" & ControlChars.CrLf & currentSetionText)
        End Sub
    End Class
End Namespace