<# 
    Name: CheckLnk.ps1
    Task: powerShell 2
    Author: Batunin Maxim
    Group: 302
#>

$Shell = New-Object -com WScript.Shell
#$DesctopPath = $shell.SpecialFolders.Item("desktop")
#$BadLinksPath = $DesctopPath + "\BadLinks"

$DesctopPath = "C:\Users\maks\Desktop\"
$BadLinksPath = "C:\Users\maks\Desktop\BadLinks"

if((Test-Path $BadLinksPath) -ne "True") 
{
	New-Item -Path $BadLinksPath -ItemType "directory"
}

$FilesNames = Get-ChildItem $DesctopPath | Where-Object {$_.extension -eq ".lnk"} | Select-Object Name


foreach ($fileName in $FilesNames) {

    $shortcutPath = $DesctopPath+($name.Name)

	$Shortcut = $Shell.CreateShortcut($shortcutPath)

	if($Shortcut.TargetPath -eq $null -eq $null)
	{
		move-item -path ($shortcutPath) -destination $BadLinksPath
		Write-host "File not found"
	} 
	else 
	{
		if((Test-Path $Shortcut.TargetPath) -eq "True") 
		{
			Write-host "Path is valid"
		}
		else 
		{
			move-item -path ($shortcutPath) -destination $BadLinksPath
			Write-host "File not found"
		}
	}
}