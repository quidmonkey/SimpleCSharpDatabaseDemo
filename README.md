SimpleC-DatabaseDemo
====================

A Simple C# Database Demo Using Windows Forms

This simple demo shows you how to open a connection and query a database using Visual C#. It will grab all the records from the Northwind database (the standard sample database that comes with all versions of SQL Server), and display them in a datagrid. You'll need a copy of [Visual C#](http://www.microsoft.com/visualstudio/en-us/products/2010-editions/visual-csharp-express) installed and [SQL Server Compact](http://www.microsoft.com/en-us/download/details.aspx?id=17876).

Start by creating a new Visual C# Windows Forms Project and name it "DatabaseDemo". Then create a form and add a dataGridView to it. Use the Form1.cs provided by this demo. Finally, add the Northwind database  by going to Data -> Add New Data Source... and following the wizards instructions. Additional information can be found [here](http://msdn.microsoft.com/en-us/library/bb384568.aspx). You may have to modify the GetConnectionString() method to properly point to where the database is stored on your computer.

And that's it!

Enjoy.