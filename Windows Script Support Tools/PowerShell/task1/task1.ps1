<# 
    Name: task1.ps1
    Task: powerShell 1
    Author: Batunin Maxim
    Group: 302
#>

Get-Process | Select-Object Name, CPU | Sort-Object CPU -Descending  | Select-Object -First 5 | ConvertTo-Html -As List | Out-File "result.html"
./result.html