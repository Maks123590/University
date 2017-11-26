/* 
    Name: task.js
    Task: wsh 3
    Author: Batunin Maxim
    Group: 302
*/

var wordApplication = WScript.CreateObject("Word.Application");

var document = wordApplication.Documents.Add();

wordApplication.Visible = true;

var selection = wordApplication.Selection;

var fileSystemObject = WScript.CreateObject("Scripting.FileSystemObject");

var currentDate = new Date();

selection.TypeText("Date created: " + currentDate + "\n");

var drives = new Enumerator(fileSystemObject.Drives);

for (; !drives.atEnd(); drives.moveNext()) {
    selection.TypeText("____________________________________________________________\n");
    selection.TypeText("DriveLetter: " + drives.item().DriveLetter + '\n');
    if (drives.item().IsReady) {
        selection.TypeText("VolumeName: " + drives.item().VolumeName + '\n');
        selection.TypeText("TotalSize: " + drives.item().TotalSize / 1024 / 1024 / 1024 + " gb\n");
        selection.TypeText("FreeSpace: " + drives.item().FreeSpace / 1024 / 1024 / 1024 + " gb\n");
        selection.TypeText("FilledSpace: " + ((drives.item().TotalSize - drives.item().FreeSpace) / 1024 / 1024 / 1024) + " gb\n");
    } else {
        selection.TypeText("The Drive not ready\n");
    }
    
    selection.TypeText("____________________________________________________________\n");
}

document.SaveAs("test.doc");