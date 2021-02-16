**UNIVERSITY AMERICAN COLLEGE SKOPJE**

**SCHOOL OF COMPUTER SCIENCE AND INFORMATION TECHNOLOGY**

![](RackMultipart20210216-4-1gf5pd8_html_361e33aeeb0e28b1.png)

**Application for Support of a Logistics Company**

**Graduation Thesis**

![](RackMultipart20210216-4-1gf5pd8_html_242f7456cb9b2c6e.png)

**Author: Burak Alparslan**


**\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_**

**Acknowledgments**

As a matter of first importance, my family showed me material and profound help in my life. My instruction has been roused as of late for the hardest circumstances of both my investigations and my school life, and it has demonstrated to me the correct path for a wide range of troubles. They were forever my supporters. My family was with me constantly. Much thanks to you for giving a vastly improved future to me.

Also, I might want to thank my schoolmates and partners for their assistance. I wish them fortunes in their future business life.

At long last, I need to compose the most essential point here. I will always remember that the school organization, teachers and partners guaranteed us a decent future and gave us a decent instruction and demonstrated to us the correct path in our troublesome circumstances. I want to thank everybody who contributed.

**Burak Alparslan**

# Table of Contents

[Introduction 8](#_Toc494661710)

[Problem statement 8](#_Toc494661711)

[Outline of the thesis 9](#_Toc494661712)

[Overview of Technologies and Tools used in the thesis 11](#_Toc494661713)

[MS SQL Server Management Studio 2014 11](#_Toc494661714)

[Microsoft Visual Studio 2015 13](#_Toc494661715)

[Problem Solving 14](#_Toc494661716)

[Theoretical approach 14](#_Toc494661717)

[User Roles (Actor) 15](#_Toc494661718)

[Use-Case Diagram 16](#_Toc494661719)

[Description of Tables 17](#_Toc494661720)

[Description of Tables – Main Table 18](#_Toc494661721)

[Description of Tables – Products Table 19](#_Toc494661722)

[Description of Tables – Customers Table 19](#_Toc494661723)

[Description of Tables – Drivers Table 20](#_Toc494661724)

[Description of Tables – Type Table 20](#_Toc494661725)

[Description of Tables – Code Operation 21](#_Toc494661726)

[Description of Tables – Trucks Table 21](#_Toc494661727)

[Relations in Microsoft SQL Server Management 22](#_Toc494661728)

[Table Structure: 23](#_Toc494661729)

[ER Diagram 23](#_Toc494661730)

[Main Table 24](#_Toc494661731)

[Products Table 24](#_Toc494661732)

[Customers Table 25](#_Toc494661733)

[Drivers Table 25](#_Toc494661734)

[Type Table 26](#_Toc494661735)

[Code Operation Table 26](#_Toc494661736)

[Trucks Table 27](#_Toc494661737)

[Computer Application Description 28](#_Toc494661738)

[Main Page 28](#_Toc494661739)

[Driver Page 29](#_Toc494661740)

[Product Page 30](#_Toc494661741)

[Customer Page 31](#_Toc494661742)

[Operation Page 32](#_Toc494661743)

[Truck Page 33](#_Toc494661744)

[Type Page 34](#_Toc494661745)

[Conclusion 36](#_Toc494661746)

[References 37](#_Toc494661747)

**List of Figures**

[Figure 1.Net Technology 8](#_Toc494575191)

[Figure 2 Logos of technologies used 10](#_Toc494575192)

[Figure 3 SQL Server Studio Logo 12](#_Toc494575193)

[Figure 4 Microsoft Visual Studio Logo 13](#_Toc494575194)

[Figure 5 Use-Case Diagram 16](/C:%5CUsers%5CPUMPKIN%5CDesktop%5CTEZ.docx#_Toc494575195)

[Figure 6 Database Diagram 17](#_Toc494575196)

[Figure 7 Main Table 18](#_Toc494575197)

[Figure 8 Products Table 19](#_Toc494575198)

[Figure 9 Customers Table 19](#_Toc494575199)

[Figure 10 Driver Table 20](#_Toc494575200)

[Figure 11 Type Table 20](#_Toc494575201)

[Figure 12 Code Operation Table 21](#_Toc494575202)

[Figure 13 Trucks Tale 21](/C:%5CUsers%5CPUMPKIN%5CDesktop%5CTEZ.docx#_Toc494575203)

[Figure 14 Relationships in Database 22](#_Toc494575204)

[Figure 15 ER Diagram 23](#_Toc494575205)

[Figure 16 SQL Server Database of Main Table 24](#_Toc494575206)

[Figure 17 SQL Server Database of Products Table 24](#_Toc494575207)

[Figure 18 SQL Server Database of Customers Table 25](#_Toc494575208)

[Figure 19 SQL Server Database of Drivers Table 25](#_Toc494575209)

[Figure 20 SQL Server Database of Type Table 26](#_Toc494575210)

[Figure 21 SQL Server Database of Code Operation Table 26](#_Toc494575211)

[Figure 22 SQL Server Database of Trucks Table 27](#_Toc494575212)

[Figure 23 Main Page 28](#_Toc494575213)

[Figure 24 Driver Page 29](#_Toc494575214)

[Figure 25 Driver Excel Report 29](#_Toc494575215)

[Figure26ProductPage 30](#_Toc494575216)

[Figure 27 Product Excel Report 30](#_Toc494575217)

[Figure 28 Customer Page 31](#_Toc494575218)

[Figure 29 Customer Excel Report 31](#_Toc494575219)

[Figure 30 Operation Page 32](#_Toc494575220)

[Figure 31 Operation Excel Report 32](#_Toc494575221)

[Figure 32 Main Back Office Page 32](#_Toc494575222)

[Figure 33 Truck Page 33](#_Toc494575223)

[Figure 34 Type Page 34](#_Toc494575224)

# Introduction

## Problem statement

There are numerous improvements in the field of structural outline and programming advancement in the field of standards. Methods of insight and practice points of interest change when individuals lead the advancement of training. In this fabulous and here and there complex programming improvement world, there are dependable and genuine structural examples and programming advancement standards utilized by most programming engineers. In the meantime an application configuration ought to be able to swing to advancement as opposed to trade off with regular practices. The reason is that the product isn&#39;t sufficiently utilized in the part. The reason for the task is to control and write about the organization&#39;s business history. Application for Support Logistics Company stores item data, customer data, trucks data, transport sorts data, drivers data and realized operation data. Likewise, the application could embed news or refresh any information from them. Another component of the application is announcing for drivers, clients, items and completed operations.

![](RackMultipart20210216-4-1gf5pd8_html_3190248fced5036.png)

**Figure 1.Net Technology [1]**

## Outline of the thesis

Application for Support of a Logistics Company in this thesis was executed as a desktop application. In this product; there are two primary page. The initial one is for operational process and the other on is for back office process which is incorporated to the first page with the name Back Office. The tables can be chosen by the user and after that show on both of the primary pages. There are 3 common function as insert, update and report. Also, there is erase work on the operation page.

Main Page; the page is mother page for the application. It has operational processes pages and back office main page on its own

Main Back Office Page; the page is second primary page in the application. It has internal information pages as trucks and transport types.

Inserting;

- The function is common, the user is able to insert on every page.
- Stored procedures have been created in SQL Server for every tables.
- All created insert stored procedures were introduced to every class in the application.

Updating;

- The function is common, the user is able to insert on every page.
- Stored procedures have been created in SQL Server for every tables.
- All created update stored procedures were introduced to every class in the application

Reporting;

- The function is common, the user is able to insert on every page.
- Stored procedures have been created in SQL Server for every tables.
- All created report stored procedures were introduced to every class except back office classes in the application.

Deleting;

- The function is not common, the user is able to delete only on the operation page.
- Stored procedures have been created in SQL Server for every tables.
- All created deleting stored procedures were introduced to every class in the application.

![](RackMultipart20210216-4-1gf5pd8_html_bcd22f8b6ac2c842.jpg)

**Figure 2 Logos of technologies used [2]**

Microsoft SQL Server is used to build the application

# Overview of Technologies and Tools used in the thesis

There are propelled projects and programming that we use in these days. These projects and programming give us ease. In business life, we require programs in the life of training and instruction. In this project MS SQL Server Management Studio 2014 and MS Visual Studio 2015 were utilized.

## MS SQL Server Management Studio 2014

SQL Server 2014 was released to assembling on March 18, 2014, and release to the overall population on April 1, 2014 and the manufacture number was 12.0.2000.8 at release [3]. Until November 2013 there were two CTP (Community Technology Preview) corrections, CTP1 and CTP2 [4]. SQL Server 2014 gives another in-memory capacity for tables that can fit totally in memory (otherwise called Hekaton). While little tables might be completely occupant in memory in all renditions of SQL Server, they additionally may dwell on plate, so work is associated with holding RAM, composing ousted pages to circle, stacking new pages from circle, securing the pages RAM while they are being worked on, and numerous different errands. By regarding a table as ensured to be altogether inhabitant in memory a significant part of the &#39;pipes&#39; of plate based databases can be avoided.

For circle based SQL Server applications, it additionally gives the SSD Buffer Pool Extension, which can enhance execution by reserve amongst RAM and turning media.

SQL Server 2014 likewise upgrades the Always On (HADR) arrangement by expanding the comprehensible secondary check and maintaining read operations upon auxiliary essential detachments, and it gives new half and half calamity recuperation and reinforcement arrangements with Microsoft Azure, empowering clients to utilize existing aptitudes with the on-premises rendition of SQL Server to exploit Microsoft&#39;s worldwide datacenters. What&#39;s more, it exploits new Windows Server 2012 and Windows Server 2012 R2 capacities for database application adaptability in a physical or virtual condition.

Microsoft gives three forms of SQL Server 2014 for downloading: the one that keeps running on Microsoft Azure, the SQL Server 2014 CAB, and SQL Server 2014 ISO.

SQL Server 2014 SP1, comprising basically of bugfixes, was release on May 15, 2015 [5].

SQL Server 2014 is the keep going adaptation accessible on x86/IA32 engineering [6].

![](RackMultipart20210216-4-1gf5pd8_html_b6aff67ade0c6df8.png)

**Figure 3 SQL Server Studio Logo [7]**

## Microsoft Visual Studio 2015

At first alluded to as Visual Studio &quot;14&quot;, the primary Community Technology Preview (CTP) was released on 3 June 2014 [8] and the Release Candidate was released on 29 April 2015; Visual Studio 2015 was formally declared as the last name on 12 November 2014 [9].

Visual Studio 2015 RTM was released on 20 July 2015. Visual Studio 2015 Update 1 was released on 30 November 2015. Visual Studio 2015 Update 2 was released on 30 March 2016. Visual Studio 2015 Update 3 was released on 27 June 2016.

![](RackMultipart20210216-4-1gf5pd8_html_bba0717ec059a117.jpg)

**Figure 4 Microsoft Visual Studio Logo**

# Problem Solving

## Theoretical approach

A desktop application for the Application for Support of a Logistics Company was implemented. In this software, information will be shown from database. Available information could be updated or information that does not yet exist could be inserted. There are different functions and rules to each pages. Processes provided for each page

Main Page;

Driver Page;

- The page has 3 functions as reporting, updating and inserting.
- No cell could be null.

Product Page;

- The page has 3 functions as reporting, updating and inserting.
- No cell could be null.

Customer Page;

- The page has 3 functions as reporting, updating and inserting.
- No cell could be null.

Operation Page;

- The page has 4 functions as reporting, updating, deleting and inserting.
- Only the ID Driver can be null on the page, because a driver is not needed except for the land way transport type.

Back Office Page;

Truck Page;

- The page has 2 functions as updating and inserting.
- No cell could be null.

Type Page;

- The page has 2 functions as updating and inserting.
- No cell could be null

### User Roles (Actor)

- Insert/Update/Report/Delete Operations
- Insert/Update/Report Products
- Insert/Update/Report Customers
- Insert/Update/Report Drivers
- Insert/Update Types
- Insert/Update Drivers

### Use-Case Diagram

**Figure 5 Use-Case Diagram**

![](RackMultipart20210216-4-1gf5pd8_html_e5166e407693dc49.png)

## Description of Tables

The product was created with Microsoft SQL Server in which a database was made and speedier access way was given using .NET. The rest of this area contains tables and clarifications identified with venture:

![](RackMultipart20210216-4-1gf5pd8_html_182ed55d3288bc4c.png)

**Figure 6 Database Diagram**

As appeared on outline, there are relations between tables. All relations are one to many except from the connection which is between the main table and products table, because one product could be utilized just in one operation.

### Description of Tables – Main Table

The principle reason of the product is controlling transport operations. Since for that the table named as Main Table. All other table related with the table a no information might be embedded by the application aside from deliver destination. Likewise, framework of the table could be utilized for financial activities. The primary key of the table ID Operation and all others things are foreign key with the exception of that destination.

![](RackMultipart20210216-4-1gf5pd8_html_a4093113bf152d8e.png)

**Figure 7 Main Table**

### Description of Tables – Products Table

The product table keeps information about goods taken by customers. Customer id is foreign key in the table and it provides a relation between product table and customer table. No cell may be null on the table.

![](RackMultipart20210216-4-1gf5pd8_html_1732fce2d1e543b2.png)

**Figure 8 Products Table**

### Description of Tables – Customers Table

This table keeps information for customer. ID\_Customer is primary key and a bridge to the Products table. No cell can be null.

![](RackMultipart20210216-4-1gf5pd8_html_71c2e3bfd45f3e56.png)

**Figure 9 Customers Table**

### Description of **Tables – Drivers Table**

This table keeps information for drivers. ID\_Driver is the primary key and a bridge to the Main Table. The ID Driver provides a relation between this table and the Main Table. No cell can be null on the table.

![](RackMultipart20210216-4-1gf5pd8_html_821e148c91f22137.png)

**Figure 10 Driver Table**

### Description of Tables – Type Table

The table keeps type of transporting information. ID\_Type is the primary key for the table and it is a bridge to the Main Table. The foreign key is Code\_Type. The Code\_Type provides relation between the Code Type Table and this table. No cell can be null.

![](RackMultipart20210216-4-1gf5pd8_html_397ce1b695132ebb.png)

**Figure 11 Type Table**

### Description of Tables – Code Operation

This table keeps codes for operations. As shown on the table there are types of transporting and they are fixed. Therefore, the application has not access the table. This table connects the Trucks Table and the Type Table.

Code\_ID is a primary key for the table and it is a bridge to the Type Table. Foreign key is ID\_Truck on the table and it provides a relation between the Trucks Table and this table. ID\_Truck can be a null on the table because transporting types have no truck except land way transporting.

![](RackMultipart20210216-4-1gf5pd8_html_9363c676dd30099a.png)

**Figure 12 Code Operation Table**

### Description of Tables – Trucks Table

The table keeps trucks information. ID\_Truck is a primary key for the table and it provides a relation between the Code Operation Table and this table. No cell can be null.

**Figure 13 Trucks Tale**


 ![](RackMultipart20210216-4-1gf5pd8_html_91913f5260884af8.png)

## Relations in Microsoft SQL Server Management

All the obligatory data for the application are put away in these seven tables and clarified in the text. Each table has its own primary key and a portion of the tables have their own foreign key to give relations between tables.

![](RackMultipart20210216-4-1gf5pd8_html_e0621e6d71de5e57.png)

**Figure 14 Relations in the Database**

# Table Structure:

### ER Diagram

![](RackMultipart20210216-4-1gf5pd8_html_323248d409babb8.png)

**Figure 15 ER Diagram**

### Main Table

This table used for storing scheduled operation&#39;s information

![](RackMultipart20210216-4-1gf5pd8_html_73e6b82abaaff5da.png)

**Figure 16 SQL Server Database of Main Table**

### Products Table

This table used for storing received product&#39;s information

![](RackMultipart20210216-4-1gf5pd8_html_8ff6929a13d5b018.png)

**Figure 17 SQL Server Database of Products Table**

### Customers Table

This table used for storing registered customer&#39;s information

![](RackMultipart20210216-4-1gf5pd8_html_c269c7249885b0ae.png)

**Figure 18 SQL Server Database of Customers Table**

### Drivers Table

This table used for storing active or inactive driver&#39;s information

![](RackMultipart20210216-4-1gf5pd8_html_a1c44bbfe8ab44c1.png)

**Figure 19 SQL Server Database of Drivers Table**

### Type Table

The table used for storing fixed transporting types

![](RackMultipart20210216-4-1gf5pd8_html_61114f7b102ece1b.png)

**Figure 20 SQL Server Database of Type Table**

### Code Operation Table

The table used for storing fixed transport type&#39;s internal codes

![](RackMultipart20210216-4-1gf5pd8_html_983dd5bad3724443.png)

**Figure 21 SQL Server Database of Code Operation Table**

### Trucks Table

The table used for storing recorded truck&#39;s plate information

![](RackMultipart20210216-4-1gf5pd8_html_3a5cbc07d0d09caf.png)

**Figure 22 SQL Server Database of Trucks Table**

# Computer Application Description

The software is based on .Net and Microsoft SQL server has been used to support the software&#39;s database.

## Main Page

There is a Main Page at the entrance of the program. The page could be called mother control page of the software. Everything that the software has is working under the page. The page has access to other 5 pages. These are in turn; Driver Page, Product Page, Customer Page, Operation Page and Back Office. The first four pages are used for management operations, whereas the Back Office page is used for keeping the company&#39;s own data.

Technically, the page has five buttons and each button opens its respective page.

![](RackMultipart20210216-4-1gf5pd8_html_8c74f086457151db.png)

**Figure 23 Main Page**

## Driver Page

The page is used to managing drivers information. A new driver could be inserted, an inserted driver could be updated and all the driver information could be reported (converted) to excel format.

Technically, the page has a data\_grid\_view for showing saved information, four labels for naming values, three text boxes for inserting data, two radio buttons for denoting the driver&#39;s status, two buttons for running update and insert functions, a group box for keeping items steady and a context menu strip for selecting cells from the data\_grid\_view and reporting to excel.

![](RackMultipart20210216-4-1gf5pd8_html_598308e1709d71d6.jpg)

**Figure 24 Driver Page**

![](RackMultipart20210216-4-1gf5pd8_html_5a50d98772a3b041.png)

**Figure 25 Driver Excel Report**

For the Driver Status, TRUE is active and FALSE is inactive.

## Product Page

The page is used to managing products information. A new product could be inserted, an inserted one could be updated and all the product information could be reported to excel.

Technically, the page has a data\_grid\_view for showing saved information, four labels for naming values, six text boxes for insert data, two buttons for running update and insert functions, a group box for keeping items steady and a context menu strip for selecting cells from the data\_grid\_view and reporting to excel.

![](RackMultipart20210216-4-1gf5pd8_html_fffb15d71d6fc727.jpg)

**Figure 26 Product Page**

![](RackMultipart20210216-4-1gf5pd8_html_9ba816a86a4f5d7c.png)

**Figure 27 Product Excel Report**

## Customer Page

The page is used to managing customer information. A new customer could be inserted, an inserted customer could be updated and all the customer information could be reported to excel.

Technically, the page has a data\_grid\_view for showing saved information, three labels for naming values, three text boxes for inserting data, two buttons for running update and insert functions, a group box for keeping items steady and a context menu strip for selecting cells from the data\_grid\_view and reporting to excel.

![](RackMultipart20210216-4-1gf5pd8_html_1cac3559bd2a0bd0.png)

**Figure 28 Customer Page**

![](RackMultipart20210216-4-1gf5pd8_html_8e147b900e7825f3.png)

**Figure 29 Customer Excel Report**

## Operation Page

The page is used to managing operation information. A new operation could be inserted, an inserted operation could be updated or deleted and all operation information could be reported to excel.

Technically, the page has a data\_grid\_view for showing saved information, two date&amp;time picker for inserting date, six labels for naming values, four boxes for insert data, two buttons for running update and insert functions, a group box for keeping items steady and a context menu strip for selecting cells from the data\_grid\_view, for deleting a selected row and reporting to excel.

![](RackMultipart20210216-4-1gf5pd8_html_90e2929c8121d53.png)

**Figure 30 Operation Page**

![](RackMultipart20210216-4-1gf5pd8_html_e5c7e68e0babd0e6.png)

**Figure 31 Operation Excel Report**

**Main Back Office Page**

The page could be called secondary controlling panel in the software. Internal data are kept on the page. The page has access to two other pages, the Type Page and the Truck Page.

Technically, there are two buttons on the page and they open their own pages.

![](RackMultipart20210216-4-1gf5pd8_html_d4d6db5e7469fe7d.png)

**Figure 32 Main Back Office Page**

## Truck Page

The page is used to managing trucks information. A new truck could be inserted and an inserted truck could be updated.

Technically, the page has a data\_grid\_view for showing saved information two labels for naming values, two boxes for inserting data, two buttons for running update and insert functions, a group box for keeping items steady and a context menu strip for selecting cells from the data\_grid\_view.

![](RackMultipart20210216-4-1gf5pd8_html_a22daf865dcfc753.png)

**Figure 33 Truck Page**

## Type Page

The page is used to managing operation types information. A new type could be inserted and an inserted type could be updated.

Technically, the page has a data\_grid\_view for showing saved information two labels for naming values, two boxes for inserting data, two buttons for running update and insert functions, a group box for keeping items steady and a context menu strip for selecting cells from the data\_grid\_view.

![](RackMultipart20210216-4-1gf5pd8_html_83597b3de4436dac.png)

**Figure 34 Type Page**

# Conclusion

This project is the last project I completed in undergraduate education. During the course of the project, a lot of the information I learned during the courses was actively used. It can also be regarded as a first step towards the field of specialization. I think that engineering does not mean good coding, on the contrary it means producing projects and manage process of the project.

The idea of the project came on my mind while working in a logistics company. The company was not using any software to manage operations except Microsoft Office Packets. I thought that I need to produce a project and manage processes of the project. While my education duration, I used the idea for couple of courses projects. The idea came up my thesis project with time.

The software is created for easy use by users. Initialized operation information is showed clearly and data are easily accessed. On the other hand, the software has reporting function for the follow up affairs. In a nutshell, the software has every essential functions for support to a logistics company on its own.

As a result, this job taught me how to make a functional software. I learned how to manage the workflow, what problems can be solved with software, and how to manage a software development process.

# References

1. Reference Data, Figure 1,

[http://www.nilkanth.com/embrace-the-new-net-logo/](http://www.nilkanth.com/embrace-the-new-net-logo/)

[Last accessed on 01.10.2017]

1. Reference Data, Figure 2,

[https://www.youtube.com/watch?v=f\_nVh0U8zRI](https://www.youtube.com/watch?v=f_nVh0U8zRI)

[Last accessed on 01.10.2017]

1. Reference Data, Microsoft SQL Server Management Studio 2014, [http://www.faceofit.com/list-of-sql-server-versions-build-numbers-and-service-packs/](http://www.faceofit.com/list-of-sql-server-versions-build-numbers-and-service-packs/)

[Last accessed on 01.10.2017]

1. Reference Data, SQL Server 2014 ,

[http://www.faceofit.com/list-of-sql-server-versions-build-numbers-and-service-packs/](http://www.faceofit.com/list-of-sql-server-versions-build-numbers-and-service-packs/)

[Last accessed on 01.10.2017]

1. Reference Data,  [SQL Server 2014 Service Pack 1 release information](https://support.microsoft.com/en-us/kb/3058865),

[https://support.microsoft.com/en-us/help/3058865/sql-server-2014-service-pack-1-release-information](https://support.microsoft.com/en-us/help/3058865/sql-server-2014-service-pack-1-release-information)

[Last accessed on 01.10.2017]

1. Reference Data, [Visual Studio 15 CTP now available,](https://blogs.msdn.microsoft.com/visualstudio/2014/06/03/visual-studio-14-ctp-now-available/)

[https://blogs.msdn.microsoft.com/visualstudio/2014/06/03/visual-studio-14-ctp-now-available/](https://blogs.msdn.microsoft.com/visualstudio/2014/06/03/visual-studio-14-ctp-now-available/)

[Last accessed on 01.10.2017]

1. Reference Data, Figure 3,

[http://www.envercolakoglu.com/sql-server-2014-management-studio-download-linkleri/](http://www.envercolakoglu.com/sql-server-2014-management-studio-download-linkleri/)

[Last accessed on 01.10.2017]

1. Reference Data, [Visual Studio 2015 Preview](http://blogs.msdn.com/b/visualstudio/archive/2014/11/12/visual-studio-2015-preview-visual-studio-community-2013-visual-studio-2013-update-4-and-more.aspx),

[https://blogs.msdn.microsoft.com/visualstudio/2014/11/12/visual-studio-2015-preview-visual-studio-community-2013-visual-studio-2013-update-4-and-more/](https://blogs.msdn.microsoft.com/visualstudio/2014/11/12/visual-studio-2015-preview-visual-studio-community-2013-visual-studio-2013-update-4-and-more/)

[Last accessed on 01.10.2017]