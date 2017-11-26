/* 
    Name: task.js
    Task: wsh 4
    Author: Batunin Maxim
    Group: 302
*/

var WshShell = WScript.CreateObject("WScript.Shell");

var desctopPath = WshShell.SpecialFolders.Item("Desktop");

var fileSystemObject = WScript.CreateObject("Scripting.FileSystemObject"); 

var desctopFolder = fileSystemObject.GetFolder(desctopPath);

var desctopFiles = new Enumerator(desctopFolder.Files);

var resultString = "";

for (; !desctopFiles.atEnd(); desctopFiles.moveNext()) {
    resultString += desctopFiles.item().Name + '\n';
}

fileSystemObject.CreateTextFile("testfile.txt", true);

var file = fileSystemObject.GetFile("testfile.txt");

var stream = file.OpenAsTextStream(2, -2);

stream.write(resultString);

//WScript.Echo(resultString);
