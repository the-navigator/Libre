# **Libre(Flexible Digital Library)**
***Check LearNAV Engine Repository for extended functions as the projects are linked to each other***

[LearNAV Engine Repository](https://github.com/the-navigator/LearNAV-Engine-MySQL)
## Basic Information 📚
### Flexible Digital Library
Libre's system consists of the following:
1. **Digital Learning Resource Library**
- Contains Most of the Curriculum-based ***Learning Modules*** from Philippine's **Department of Education(DepEd** and their online platform [*Deped Commons*](commons.deped.gov.ph)
- Contains Related Learning Resources from [**Archive.org**](archive.org)

2. **Straightforward and Powerful Search System**
- Libre's Search System allows the user to quickly search for the embedded resources in the database
### **SHELF**
An implementation of Libre where the resources come from the users.  Both acts as learning  resource manager and **Tag-Based Directory System** for User's Resources. 
## System and Usages 💻
###  Surface Informations
- **Design**
	- Libre consists of a very simple interface design for the interface following both Google's [*Material Design*](https://material.io) and Mozillas' [*Photon Design*](https://design.firefox.com).
	- It also uses open-source icons from [*Eva Design*](https://eva.design) and [*Feather Icon*](https://feathericons.com).
	- Design Process are done through Microsoft Office Powerpoint, Adobe PhotoShop, SAI 2 and Adobe Illustrator.
	
***Screenshots***



![Main Window/Dashboard](https://i.postimg.cc/J41fm4sk/main.png)
![Advanced Search](https://i.postimg.cc/dV3gkHmQ/advance-search.png)
![Libre SHELF(Under Development)](https://i.postimg.cc/5NnZtdzk/shelf.png)
***SHELF is currently under development***

- **Fonts**
	The Following Fonts were used:
	1. Fira Sans (Primary)
	2. Gelion Typeface
	3. Berlin Round
	4. Seoge UI
## Programming Libre 📃
This section is intended to those who wish to conribute to the project. Befor you do, kindly check [this out](https://github.com/the-navigator/Libre/blob/master/CONTRIBUTING.md) and License attached to this repository. *Cheers!*🎉
### Development
- Language Used: **C#**, .NET 4.7.2
- IDE : **Visual Studio**

Libre is primarily developed in Visual Studio. It utilizes the following resources and libraries:
1. DotNetZip
2. System.Data.SQLite
3. Material Design Framework for C#
### Database Management
The Developers utilize [**SQLite**](https://sqlite.org) Database Management System through the use of [**DB Browser**](https://sqlitebrowser.org) and [**SQLite Studio**](https://github.com/pawelsalawa/sqlitestudio/tree/master/SQLiteStudio3/coreSQLiteStudio).

Microsoft Excel and Notepad are also used for migrating data and information from one database system to another. (*We used to make the Database in MS ACCESS*)

#### There are two Database:
**1. Libre Main Database** - maintained by the developers.
**2. SHELF Database** - manages user inputs and Tag Systems.

## LearNAV Engine
### What is it?
LearNAV is the original title of the project. The Developers(team jar) developed a C# Dynamic Link Library(DLL) for communicating, managing and processing data between the **Libre** and its **Database**

Find more here:
[LearNAV Engine Repository](https://github.com/the-navigator/LearNAV-Engine-MySQL)

### Common Variables that are utilized in Libre and LearNAV Engine:

1. dt - DataTable that stores Data for filtering data from Database

	  It is created in LearNAV_Engine to store data used by the queries
  The Data are then transfered to the ListView containers in LearNAV to store data

2. Classes for *Advanced Searching*, *Filter* and *LogIn*

### Contact Devs
Email - <thenavigator.app15@gmail.com>



> Written with [StackEdit](https://stackedit.io/).


