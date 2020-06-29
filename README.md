# Unity-VariationPackager

A Unity editor extension for creating multiple packages from JSON file.

## Requirements

- Unity 2018.3 or higher
- NuGet Packages
  - `Microsoft.Extensions.FileSystemGlobbing`
  - `Newtonsoft.Json`
- Additional External References
  - `System.IO.Compression`
  - `System.IO.Compression.FileSystem`

## JSON Schema

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
