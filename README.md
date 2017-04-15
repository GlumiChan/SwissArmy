## [Download latest version](https://github.com/GlumiChan/SwissArmy/releases/download/1.0/SwissArmy.exe)
A modular based tool to help you out in your everyday life.

Concept:
This piece of software runs silently in the right corner of your taskbar, and contains every module that was programmed for it.

By right clicking the SwissArmy-Icon you open the Contextmenu of it.

Here you can choose any available module from the "Modules-List"

![image](http://fs5.directupload.net/images/170414/ay4vgg9b.jpg)


## Creating a new module

###  Creating the Module 
Create a new class into the "Modules"-Folder and use this template for it:

```
namespace SwissArmy.Modules
{
    public class YourModuleName
    {
        public static void Run()
        {

        }
    }
}
```

Your "Run()"-Method is the method that will be triggered while calling it.

**Also you can receive unlimited string parameters with your Run()-Method**


### Calling your new module
For calling your module just use this footage

```
Management<YourModuleName> modInit = Management<YourModuleName>.InitModule();
// Room for parameters inputs
modInit.RunModule();
```

For passing some parameters to your new module just use the following code before you call the "RunModule()"-Method.

```
//AddDialog(bool isRequired, string DialogTitle, string DialogPrompt, string DefaultText (optional)
modInit.AddDialog(true, "Base Mover", "Enter your basepath");
```
