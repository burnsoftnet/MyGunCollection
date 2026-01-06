# Stolen Firearm Custom Report

To create a Custom Report/List for Stolen Firearm 

goto **Reports** | **Custom Reports**

Select "Gun Collection" and click on "Next"

Click on **Show SQL**

Copy and Paste the line below into the text box field under the "Hide SQL" & "Get Data" buttons.

```tsql
SELECT FullName as [Full Name] ,ModelName as [Model Name] ,SerialNumber as [Serial Number] ,Type as [Firearm Type] ,Caliber ,dtSold as [Date Sold]  from qryGunCollectionDetails where ItemSold=2
```

Now Click on "Get Data"


Now you Have a List of firearms that were stolen

In the "Page heading" type in "Stolen Firearms"

Now in the Toolbar of the "View Custom Report" window, click on the disk icon,
This will save this report to the database.
So now if you wanted to pull it up again just go to Reports | Custom Reports
Select the "Stolen Firearms" from the "Load a Saved Report" drop down box and 
click on the "Load" and it will load that sql statement that you copied in
and now you can print the report if you wish.