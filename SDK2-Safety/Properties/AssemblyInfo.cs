using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;
using CorneliusCornbread.SDK2_Safety;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle(ModBuildInfo.Name)]
[assembly: AssemblyDescription(ModBuildInfo.Desc)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("CorneliusCornnbread")]
[assembly: AssemblyProduct(ModBuildInfo.Name)]
[assembly: AssemblyCopyright("Copyright ©  2021")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("D722D30B-F4EC-45C1-B5CE-D39933C412D1")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(ModBuildInfo.Version)]
[assembly: AssemblyFileVersion(ModBuildInfo.Version)]

[assembly: MelonInfo(
    typeof(SDK2_Safety),
    ModBuildInfo.Name, 
    ModBuildInfo.Version, 
    ModBuildInfo.Author, 
    ModBuildInfo.DownloadLink)]
[assembly: MelonGame(ModBuildInfo.Company, ModBuildInfo.Game)]