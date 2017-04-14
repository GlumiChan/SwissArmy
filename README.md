# SwissArmy
A modular based tool to help you out in your everyday life :)



## Creating your own module

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
** Also you can receive unlimited string parameters with your Run()-Method **


### Calling your new module
For calling your module just use this footage

```
Management<YourModuleName> modInit = Management<YourModuleName>.InitModule();
// Room for parameters inputs
modInit.RunModule();
```

For passing some parameters to your new module just use the following code before you call the "RunModule()"-Method.

```
//AddDialog(bool required, string DialogTitle, string DialogPrompt, string DefaultText (optional)
modInit.AddDialog(true, "Base Mover", "Enter your basepath");
```
