/* 
    Name: task.js
    Task: wsh 1
    Author: Batunin Maxim
    Group: 302
*/

var Archive = 32;

var args = WScript.Arguments;

if (args.length > 0) {
    var fileArg = args.Item(0);
       
    var fileSystemObject = WScript.CreateObject("Scripting.FileSystemObject"); 
    
    //WshShell = WScript.CreateObject("WScript.Shell");
    
    
    if (!fileSystemObject.FileExists(fileArg)) {
         WScript.Echo("Error! ", fileArg, " not found"); 
         WScript.Quit(1); 
    }   
    
    var file = fileSystemObject.GetFile(fileArg);
    
    if (file.Attributes && Archive) {
        file.Attributes = file.Attributes - Archive;
        WScript.Echo("Remove Archive attr"); 
    } else {
        file.Attributes = file.Attributes + Archive;
        WScript.Echo("Set Archive attr"); 
    }
} else {
    WScript.Echo("no file"); 
}
