<# 
    Name: task4.ps1
    Task: powerShell 4
    Author: Batunin Maxim
    Group: 302
#>

function Show-Date_Info($Strings) 
{
    $Date = Get-Date
    
    Write-host "Today: " $Date
    
    $Url="http://numbersapi.com/" + '/'+ $Date.Month + '/' + $Date.Day
    
    For ($i=0; $i -le $Strings - 1; $i++)
    {
        $users = Invoke-WebRequest -URI $Url -Method Get
        
        Write-host $users.Content
    }

}