# CommerceProjectTask
Web api project using ABP framework.
It's an api for products & its catgeories, each product have one or more category & category contains more than one product. Then: The relation is many to many.
### Tables:
  Products, Categories, ProductCategories
### =============================================================

## ABP Framework
+ It's a framework which stands for Asp.Net Boilerplate.
+ Published as a group of NuGet & NPM packages and controlled through CLI.
+ Open source web application framework for ASP.Net core.

## Pre-Requisites for using ABP
+ Visual studio 2022 & setup .NET 8.0+
+ ABP tool
+ Yarn (installed with nodejs)
+ Redis (Used to support caching)

## Creating API Project With ABP framework
+ Install/Update CLI:    **dotnet tool (install / update) -g Volo.Abp.Cl**
+ Create your project
    1. With UI by angular:   **abp new (ProjectName) -u angular -csf**
    2. Without UI:   **abp new (ProjectName)  -u none -csf**

## Creating Database (Add Migration)
after writing your classes for databse creation
+ Make HttpApi.Host as startup project.
+ Make EntityFrameworkCore as startup project in NuGet package manager console.
###### Run in NuGet package manager console
+  Add-Migration (migrationName)
+  update-database

## Running your Api
###### For running migration or data seed if exists
Make DbMigrator as startup project  and run.

###### For running Api
Make HttpApi.Host as startup project which open Api using Swagger.


