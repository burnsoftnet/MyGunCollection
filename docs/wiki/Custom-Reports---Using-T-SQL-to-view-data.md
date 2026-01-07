# Custom Reports - Using T SQL to view data

## Introduction

The Custom Reports has a quick and easy way to select what you want to filter out and print.  However there are times where you want more than what is available and this is were custom T-SQL comes in handy.

The Report Builder has always had a way to make your own SQL statement, it just was not in plain view.  In version 6.0 we made that an option from the start.
Here are some sample T-SQL statements that we make to find other data, just in case you might find use for them.

Just copy and Paste the SQL Statements into the SQL Editor to see the results

### Rounds Fired for 2017

If you use the maintenance ability by logging the rounds that you fired, you can use this to gather how many rounds you fired.
This one is for 2017

SQL Statement

```tsql
SELECT sum(cInt(RndFired)) as total FROM Maintance_Details where cdate(OpDate)  > cdate('1/1/2017') and cdate(OpDate) < cdate('1/1/2018')
```
### Rounds Fired for 2016

If you use the maintenance ability by logging the rounds that you fired, you can use this to gather how many rounds you fired.

This one is for 2016

**SQL Statement**

```tsql
SELECT sum(cInt(RndFired)) as total FROM Maintance_Details where cdate(OpDate)  > cdate('1/1/2016') and cdate(OpDate) < cdate('1/1/2017')
```
### Rounds Fired from 2012-2018

If you use the maintenance ability by logging the rounds that you fired, you can use this to gather how many rounds you fired.
This one shows the past 5 years of rounds fired per year.

**SQL Statement**
```tsql
SELECT sum(cInt(RndFired)) as 2018,(SELECT sum(cInt(RndFired)) as total FROM Maintance_Details where cdate(OpDate)  > cdate('1/1/2017') and cdate(OpDate) < cdate('1/1/2018')) as 2017,
(SELECT sum(cInt(RndFired)) as total FROM Maintance_Details where cdate(OpDate)  > cdate('1/1/2016') and cdate(OpDate) < cdate('1/1/2017')) as 2016,
`(SELECT sum(cInt(RndFired)) as total FROM Maintance_Details where cdate(OpDate)  > cdate('1/1/2015') and cdate(OpDate) < cdate('1/1/2016')) as 2015,`
`(SELECT sum(cInt(RndFired)) as total FROM Maintance_Details where cdate(OpDate)  > cdate('1/1/2014') and cdate(OpDate) < cdate('1/1/2015')) as 2014,`
`(SELECT sum(cInt(RndFired)) as total FROM Maintance_Details where cdate(OpDate)  > cdate('1/1/2013') and cdate(OpDate) < cdate('1/1/2014')) as 2013,`
`(SELECT sum(cInt(RndFired)) as total FROM Maintance_Details where cdate(OpDate)  > cdate('1/1/2012') and cdate(OpDate) < cdate('1/1/2013')) as 2012 `
`FROM Maintance_Details where cdate(OpDate)  > cdate('1/1/2018') and cdate(OpDate) < cdate('1/1/2019')
```

### List Firearms Missing Picture

List the full name of the firearm(s) that are missing a picture

**SQL Statement**

```tsql 
select g.FullName from Gun_Collection g where not exists  (select * from Gun_Collection_Pictures p where p.cid=g.id)
```

### Simple Firearm List by Origin

List the Full Name Caliber and Place of Origin of the firearm collection.

**SQL Statement**

```tsql 
SELECT FullName as [Full Name] ,Caliber ,gn.country as [Place of Origin]  from qryGunCollectionDetails g inner join Gun_Nationality gn on gn.id = g.NatID
```