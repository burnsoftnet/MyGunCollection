# Developer Notes

This is just some small notes that help with the development and support of this application.

## Branches

The *Main* Branch will contain the current release code.  Changes will be in the *develop* branch.  
For new Changes create a branch from the *develop* branch and make your changes.  Then Create a pull request
to merge into *develop*.  Once all the changes are ready for release, create a pull request to merge 
*develop* into *main*.  Once the release has been merged into main.  Create a new Branch from Main called
*release/vX.X.X* as a backup for the production release.

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