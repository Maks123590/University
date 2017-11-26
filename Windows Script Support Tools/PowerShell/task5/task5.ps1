<# 
    Name: task5.ps1
    Task: powerShell 5
    Author: Batunin Maxim
    Group: 302
#>

function Change-Format($distFile) 
{
    $fileStrings = Get-Content $distFile

    $oldFileNameParts = $distFile.Split('.')


    $newFileName = $oldFileNameParts[0] + "_transform." + $oldFileNameParts[1]
    
    if ((Test-Path $newFileName) -eq "true")
    {
        Remove-Item -Path $newFileName
    }
    

    foreach ($string in $fileStrings)
    {
        $matches = [regex]::Match($string,"([A-Я][а-я]*\s[A-Я][а-я]*\s[A-Я][а-я]*\s)(\d{2}\.\d{2}\.\d{4})")

        $resultSrting = $matches.Groups[2].value + " " +$matches.Groups[1].value

        $resultSrting | Out-File -Append $newFileName -Encoding Default
    }
}

Change-Format test.txt