# Megabonk Custom Character Maker
These files are used to simplify the process of making custom characters in Megabonk.
They are used in conjunction with my Megabonk Custom Character Loader plugin (https://github.com/PeterMoras/MEGABONK_CustomCharacterLoader) in order to fully add custom characters.


## Installation
1. Ensure you have Unity 2023.2.20f1 downloaded, as this is Megabonk's Unity version, and is needed specifically to generate valid AssetBundles.
2. Create a new Unity project with the 2023.2.20f1 version, make it obvious that this is for Megabonk mods.
	Use the 3D built-in render pipeline, though it doesn't matter what setup you start with.
3. Extract or move all files into the Assets directory of the new Unity project.
	After compiling finishes, clear the console and you should still see a few errors mentioning 'Newtonsoft'.
4. Install Newtonsoft.JSON by opening the Unity Package Manager (Window > Package Manager), click the + icon in the top left, and add package by name.
	the package name is: 'com.unity.nuget.newtonsoft-json', and version doesn't matter
	
If you have followed these instructions, you should now have a Unity project with no Errors. You can ignore the 999+ warnings.
I would **HIGHLY** recommend immediately building your character (Section found below) to ensure that everything was setup correctly, and that you can see the character in Megabonk.

## Creating a Character
Everything you need to help create a character can be found in the EXPORT folder. 
The SourceCode and CustomScripts folders only contain code to help facilitate the creation of custom characters, and SHOULD NOT BE MODIFIED.

### Features
TODO


## Building Your Character
Once you are happy with your custom character, you can build your character by finding the Build option (Build > Build Custom Character) on the menu bar at the top.
After a few seconds of compilation, you should see a new 'AssetBundles' folder created withj your bundled character files inside.
The files will be named after your CharacterDataSO object's 'Asset Bundle Name' field in all lowercase, of which you should see 3. One with no extension, once with a .json extension, and one with .manifest. (There will also be files named 'AssetBundles' but you can ignore those)
Copy the one with no extension and .json extension into your BepInEx/plugins/CustomCharacters folder. if the CustomCharacters folder does not exist, create it.
When you start the game, you should see your character loaded 





## Issues
If you have any issues with creating your character, or find certain options don't exist, or want more features, please greate a github issue with the request.
If there are any issues involving the loading of your custom character, please put the issue on my other repository, linekd at the top.