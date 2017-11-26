/* 
    Name: task.js
    Task: wsh 2
    Author: Batunin Maxim
    Group: 302
*/

var fileSystemObject = WScript.CreateObject("Scripting.FileSystemObject");

fileSystemObject.CreateTextFile("testfile.txt", true);

var file = fileSystemObject.GetFile("testfile.txt");

var stream = file.OpenAsTextStream(2, -2);

stream.write("Date created: " + file.DateCreated + "\n");


var drives=new Enumerator(fileSystemObject.Drives);

for (; !drives.atEnd(); drives.moveNext()) {
    stream.write("____________________________________________________________\n");
    stream.write("DriveLetter: " + drives.item().DriveLetter + '\n');
    if (drives.item().IsReady) {
        stream.write("VolumeName: " + drives.item().VolumeName + '\n');
        stream.write("TotalSize: " + (drives.item().TotalSize / 1024 / 1024 / 1024).toFixed(2) + " gb\n");
        stream.write("FreeSpace: " + drives.item().FreeSpace / 1024 / 1024 / 1024 + " gb\n");
        stream.write("FilledSpace: " + ((drives.item().TotalSize - drives.item().FreeSpace) / 1024 / 1024 / 1024) + " gb\n");
    } else {
        stream.write("The Drive not ready\n");
    }
    
    stream.write("____________________________________________________________\n");
}

var WshShell = WScript.CreateObject("WScript.Shell");

WshShell.Run("notepad" + " " + file.Path);