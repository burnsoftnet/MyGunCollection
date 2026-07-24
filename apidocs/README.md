# Developer Notes

This is just some small notes that help with the development and support of this application.

## Branches

The *Main* Branch will contain the current release code.  Changes will be in the *develop* branch.  
For new Changes create a branch from the *develop* branch and make your changes.  Then Create a pull request
to merge into *develop*.  Once all the changes are ready for release, create a pull request to merge 
*develop* into *main*.  Once the release has been merged into main.  Create a new Branch from Main called
*release/vX.X.X* as a backup for the production release.

## Local Support Librarys

Other than libraries that are taken from the nuget server. There are a few libraries in the local Github Repo that this
application uses.  You don't need to download and build the libraries, they have been Uploaded to the 
[Packages](https://github.com/burnsoftnet?tab=packages) Directory that you add to your nuget settings to download from github.

But if you wanted to check out the code that helps this application run.  The Repos are listed below

### Suppport Repos

* [BurnSoft.Applications.MGC](https://github.com/burnsoftnet/BurnSoft.Applications.MGC)
* [BurnSoft.Universal](https://github.com/burnsoftnet/BurnSoft.Universal)
* [BurnSoft.MsgBox](https://github.com/burnsoftnet/BurnSoft.MsgBox)
* [BurnSoft.Security.RegularEncryption](https://github.com/burnsoftnet/BurnSoft.Security.RegularEncryption)
* [DataGridViewAutoFilter](https://github.com/burnsoftnet/DataGridViewAutoFilter)
* [BurnSoftDBRestore](https://github.com/burnsoftnet/BurnSoftDBRestore)
* [BurnSoftDBBackup](https://github.com/burnsoftnet/BurnSoftDBBackup)

## Configs Files

Since the Restore and Backup applications have been created to be a nuget package, the config that is currently in the project will
probably get written over.  Below are the Backup settings of those config files, so if you hade to upgrade and lsot the config,
You can get it from what is listed below.

### DBBackup.exe.config 

```xml
<appSettings>
    <add key="AppName" value="DBBackup"/>
    <add key="MainAppName" value="My Gun Collection"/>
    <add key="DBName" value="MGC.mdb"/>
    <add key="RegKey" value="Software\BurnSoft\BSMGC\"/>
    <add key="CheckProcess" value="false"/>
    <add key="LogFilename" value="dbbackup.err.log"/>
    <add key="AppABV" value="MGC"/>
</appSettings>
```

### DBRestore.exe.config

```xml
<appSettings>
	<add key="AppName" value="DBRestore" />
	<add key="MainAppName" value="My Gun Collection" />
	<add key="MainAppNameEXE" value="BSMyGunCollection.exe" />
	<add key="DBName" value="MGC.mdb" />
	<add key="RegKey" value="Software\BurnSoft\BSMGC\" />
	<add key="CheckProcess" value="false" />
	<add key="LogFilename" value="dbrestore.err.log" />
	<add key="AppABV" value="MGC" />
</appSettings>
```

## GitHub Pages

Currently this is using the [leapday theme](https://github.com/pages-themes/leap-day)  
So any updates that is needed will need to be taken from that github repo.

### List of Customized items

Below is a list of customized items for the leapday theme that I modified for my use.
Things that will have to be backedup or updated if a newer lead day theme was used.
All located in the docs folder

* _includes/about_menu.html
* _includes/main_menu.html
* _includes/onlinehelp_menu.html
* _includes/wiki_menu.html
* _layouts/default.html
* _layouts/defaultAbout.html
* _layouts/defaultHelp.html
* _layouts/defaultWiki.html


## Things to Do Before Release

* Update the Change Log with Release Version and any additional information
* Update the Online Help with Any new Pages that are needed
* Build the Setup MSI Package
* Create the Release On Github with Change Log Details
* Update the Github Pages Main README with the Change Log Information.
* 

## Reporting

The Report Viewer is Currently running version 11.  Which the newer report viewer and Crystal Reports require the 
SQL Server Type library of version 14.0.314.76.  If the SQL Server Type library is upgraded to the latest version then, the reports will break
More Information on what needs to be upgraded to the latests if it comes down to it later