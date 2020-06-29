# Unity-VariationPackager

A Unity editor extension for creating multiple packages from Scene or JSON.

## Requirements

- Unity 2018.3 or higher

## Features

- Create a single or multiple packages (e.g. different editions) in a single operation
  - Only the difference between including and excluding assets is supported
- Support `package.json` like NPM (UPM)
- Support C# Script in current scene

## Package Configuration

You can choose from two configuration types.

### Scene

Attach `Mochizuki/VariationPackager/Package` to GameObject in your scene and configure it.

| Key                                         | Required | Description                                                                  |
| ------------------------------------------- | :------: | ---------------------------------------------------------------------------- |
| `Name`                                      |   Yes    | Package Name                                                                 |
| `Version`                                   |   Yes    | Package Version                                                              |
| `Describe.Output`                           |   Yes    | Destination directory path for the generated packages                        |
| `Describe.Variations.Name`                  |    No    | A unique name to distinguish between editions                                |
| `Describe.Variations.Archive.Name`          |    No    | The name of the zip archive                                                  |
| `Describe.Variations.Archive.BaseDir`       |    No    | The base directory to which the output will be placed, relative to this path |
| `Describe.Variations.Archive.Includes`      |    No    | Array of file paths (support glob) that including to package                 |
| `Describe.Variations.Archive.Excludes`      |    No    | Array of file paths (support glob) that excluding from package               |
| `Describe.Variations.UnityPackage.Name`     |    No    | The name of the UnityPackage                                                 |
| `Describe.Variations.UnityPackage.BaseDir`  |    No    | Unused in Unity Package. Ignored.                                            |
| `Describe.Variations.UnityPackage.Includes` |   Yes    | Array of file paths (support glob) that including to package                 |
| `Describe.Variations.UnityPackage.Excludes` |    No    | Array of file paths (support glob) that excluding from package               |

### JSON Schema

Create the following JSON file in your `Assets` directory that named as `package.json`.  
If this file exists, you can add it to the `moe.mochizuki.unity.packaging` entry.

```javascript
{
  "name": "Package Name",
  "version": "Version",
  "moe.mochizuki.unity.packaging": {
    // Destination directory path for the generated packages.
    "output": "Assets/Path/To/Packages/Destination",
    // Describe the configuration for each package.
    "variations": [
      {
        // A unique name to distinguish between types, spaces are allowed if it is unique.
        "name": "",
        // (Optional)
        // List the files you want to include or exclude to/from Zip Archive.
        // Files generated in the UnityPackage section are automatically included.
        // If omitted this section, the zip archive is not generated.
        "archive": {
          // (Optional)
          // The name of the zip archive. If omitted, `.name` will be used.
          // The name is automatically given `-VERSION` suffix.
          "name": "ZipArchiveName",
          // (Optional)
          // The base directory to which the output will be placed, relative to this path.
          "basedir": "Assets",
          "includes": [
            // (Optional)
            // Array of file paths (support glob) that including to package.
          ],
          "excludes": [
            // (Optional)
            // Array of file paths (support glob) that excluding from package.
          ]
        },
        // List the files you want to include or exclude to/from UnityPackage.
        "unitypackage": {
          // (Optional)
          // The name of the UnityPackage. If omitted, `.name` will be used.
          "name": "UnityPackageName",
          "includes": [
            // Array of file paths (support glob) that including to package.
          ],
          "excludes": [
            // (Optional)
            // Array of file paths (support glob) that excluding from package.
          ]
        }
      }
    ]
  }
}
```
