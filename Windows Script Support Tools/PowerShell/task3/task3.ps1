<# 
    Name: task3.ps1
    Task: powerShell 3
    Author: Batunin Maxim
    Group: 302
#>

$wordApplication = New-Object -com Word.Application

$document = $wordApplication.Documents.Add();

$wordApplication.Visible = $true;

$selection = $wordApplication.Selection;

$selection.Font.Size = 12

$selection.Font.Italic = $true

$selection.TypeText("Привет от PowerShell");

$document.SaveAs("test.doc");