# Cyber JellyFish Library
A Library of useful Unity Extensions and other helpful scripts and tools.

## Cyber JellyFish Runtime
The Cyber JellyFish Runtime consists of Scripts that can be used during the Runtime of your project.

### General
#### MyColours
MyColours Script gives you additional colour variation other than the standard Unity Colours available 
from Color library.

##### Example
```c#
MyColours.TealAccent;
MyColours.Indigo;
MyColours.Tan;
MyColours.Gray;
MyColours.EveningBlue;
```
#### FPS Counter
The FPS Counter is a simple UI that displays your games current FPS Count.<br>
You only need to drag and drop the FPS prefab into the scene and import the TextMeshPro package 
and you are ready to go.

### Internal
#### Extensions
These are Extensions to various classes within Unity and C# Environment.

##### Examples
```c#
myList.Shuffle(); // Based on Fisher Yates Shuffle
myArray.Shuffle(); // Based on Fisher Yates Shuffle

someObject.IsNull();
someObject.IsNotNull();

someColor.ToRandomColor();
someColor.ToHtmlColor("#FFFF");
someColor.ChangeAlpha(a); // where a, is the alpha value between [0, 1]

someString.Combine(myArray, true, false, 1, 2.0, 3.0f); // Concat a number of values to a string
```

### Utilities
#### Colour Utility
The Colour Utility Allows you to Create Unity Color object from HTML Colour Tags or from the standard 255 colour range.

##### Examples
```c# 
Color color = ColourUtility.HtmlColor("#FFFFF");
ColourUtility.HtmlColor("#FFFFF", out Color color);
Color color = ColourUtility.Color255(r, g, b); // where r,g,b, is a value between [0, 255]
```

#### Math Utility
The Math Utility helps you find a percentage between a min and max for a given value or<br>
find a value between a min and max of a given percentage.

##### Examples
```c#
float value = MathUtility.GetValueFromPercentage(percentage, min, max); 
float percentage = MathUtility.GetPercentageFromValue(value, min, max);
```

## Addons
### Serializable ScriptableObject
The Serializable Scriptable Object is a custom ScriptableObject that comes with a Custom Editor.
The Custom Editor comes with a few "Buttons" and "Additional Options".

The Buttons include:
#### Assign
The Assign button Assigns the Scriptable Object to All fields in MonoBehaviours in the Scene.<br>
Note that the field needs to be public or have the [SerializableField] attribute if it private.

#### Save
The Save button Serializes the Scriptable Object into its Equivalent Json Representation.<br>
Internally this uses the built in JsonUtility provided by Unity. However, it can be replaced by any 
other json serializer for example Json.net

Note<br>
The json file is saved at either the Persistant Data, Streaming Assets or Data paths.<br>
This is changed using the SerializablePath Dropdown.

#### Load
The Load button Deserializes the Json File and overwrites the existing Scriptable Object.<br>

Note<br>
Any private fields not marked with the [SerializableField] attribute will remain initialized with
there default values.

#### Delete
The Delete button deletes the json file.

#### Show Folder
The Show Folder button opens the directory to where the json file has be saved.

<br>
The Options include:

#### Blank Toggle
The Blank Toggle if on, will show the Save Path of the json file, otherwise it will be hidden if the 
toggle is off.

#### Serializable Path
This is a dropdown of possible options to where the json data can be saved to.

#### Filename
The Filename Field allows you to give your json file a custom name of your choosing.

<br>

### Serializable Dictionary
The Serializable Dictionary allows a user to create MonoBehaviours and Scriptable Objects 
that use the Serializable Dictionary classes that are serializable within the Unity Editor.

Standalone Serializable Dictionary Classes can also be made.

The Addons requires the RotaryHeart Serialized Dictionary Lite Package that can be found
on the Unity Asset Store.

Note!<br>
I have moved around some of the Editor Scripts and re-tagged some of the Editor classes with

However, regardless of these minor changes, the Serializable Dictionary should work if the 
Rotary Heart Serialized Dictionary Lite source code is updated.


#### How to use Serializable Dictionary
By either using the Dictionary Menu tab or Right click in your project and navigate to 
"Create/Dictionary" and select on of the following options.

##### M Dictionary (MonoBehaviour Dictionary):
Opens an Editor Window that allows you to fill in the name of your MonoBehaviour and
Serializable Dictionary including the Key and Value Types of the Dictionary.

Once you are satisfied you just click "Create", and the file will save at the right click location 
or a save file panel will open allowing you to save your script.

##### SO Dictionary (Scriptable Object Dictionary):
Opens and Editor Window that allows you to fill in the name of your Scriptable Object and Serializable
Dictionary including Key and Value Types of the Dictionary.

Once you are satisfied you just click "Create", and the file will save at the right click location
or a save file panel will open allowing you to save your script.

##### S Dictionary (Serializable Dictionary):
Opens an Editor Window that allows you to create a Serializable Dictionary Class only. 
The editor has fields for Serializable Dictionary Class name as well as Key and Value types 
of the Dictionary.

Once you are satisfied you just click "Create", and the file will save at the right click location
or a save file panel will open allowing you to save your script.

## Cyber JellyFish Editor
### Archive
The Archive Tool allows a user to extract Archive files such as .zip, .rar, .7z, etc within the Unity Editor.
All you require is a valid archive within your Unity Project.

#### How to use the Archive Tool
To use the Archive tool, all you need to do is Right click and navigate to <br>
"Create/Archive/Extract To Folder". <br>
This will extract the archive to a folder with the same name as the archive.

### Material Maker
#### Coloured Material Maker
The Coloured Material Maker was designed to create a new material with a random colour. This tool works with
the Standard and URP graphics Pipelines.

#### Folder Material Maker
The Folder Material Maker was designed with the intention of creating materials from textures easier.
The Folder Material Maker will create a material from a set of textures within that folder. The textures 
require a few keywords such as "albido, occlusion, displacement, normal, etc". 

##### How To use Folder Material Maker
Right click on a folder that has a set of textures, and navigate to Create/Materials/From Folder.<br>
A new material should be created and it should have its occlusion, normal map, base map and metallic maps
filled with textures.

Note<br>
This will only work if the textures contain the relevant keywords such as "albido, normal map, base map, occlusion, etc". 
The Keywords are stored in a ScriptableObject called "texture-keywords". 
You can edit this scriptable object and add any additional keywords that you require.

If you require an example, check out the Textures folder in the Assets/Resources folder.

## Plugins
### 7Zip Dll
This is required to extract archive files (.zip, .rar, .7z, etc) within the Unity Editor.
