using System.Resources;
using MelonLoader;
using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("HP csc Plus")]
[assembly: AssemblyDescription("alternative way to create custom stories")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("Copyleft  ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("6851adad-84e6-4a8e-a9f0-d0ce533077ae")]

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
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

//MelonLoader relies on assembly info to get your mod description. We will have to setup them up.
//To do that, go to the Properties directory, and add these three lines to AssemblyInfo.cs
[assembly: MelonInfo(typeof(HPCSC.HPcscPlus), "HPcscPlus", "1.0.0", "CamelCaseName")]
[assembly: MelonGame("Eek", "House Party")]
//[assembly: VerifyLoaderVersion(0, 5, 0, true)]
[assembly: NeutralResourcesLanguage("en")]
