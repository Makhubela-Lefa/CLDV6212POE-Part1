# ABC Retailers - POE Part 1 (CLDV6212)

**Student:** Lefa Makhubela 
**Student Number:** ST10442096  
**Module:** CLDV6212  
**Part:** Part 1 - Azure Storage Solution

---

## Overview
This repository contains the web application and supporting code for **ABC Retailers** (Part 1 of the POE for CLDV6212). The app is an ASP.NET Core MVC application (.NET 9.0) that demonstrates integration with Azure Storage services: **Table Storage**, **Blob Storage**, **Queue Storage**, and **Azure File Shares**.

The project implements CRUD operations for Products, Customers and Orders, and demonstrates how to upload/display product images, queue messages for orders/stock updates, and store contract files.

---

## Features implemented
- Azure Table Storage for **Customers**, **Products**, and **Orders** (CRUD).  
- Azure Blob Storage for product images (`product-images` container).  
- Azure Queue Storage for order/inventory messages (e.g., `order-queue`, `inventory-queue`).  
- Azure File Share for dummy contracts (`contracts` file share).  
- Price formatting in South African Rand across the app.  
- Order status updates and stock decrement on order creation.  

---

## Project details & structure
/ABCRetailers
/Controllers
/Models
/Services 
/Views
/wwwroot
appsettings.json 
README.md

---

**Framework**: .NET 9.0  
**IDE**: Visual Studio 2022 

---

## Azure resources used 
- **Table Storage**
  - `Customers` table 
  - `Products` table 
  - `Orders` table 
- **Blob Storage**
  - Container: `product-images` 
- **Queue Storage**
  - Queues: `order-queue` and `inventory-queue` 
- **File Storage**
  - File share: `contracts` 
- **App Service**
  - Deployed web app URL: https://st10442096-hwgdgjfzdnewd3c5.canadacentral-01.azurewebsites.net/

---

## How to run locally (developer steps)
1. Install [.NET 9.0 SDK](https://dotnet.microsoft.com).  
2. Open the solution in Visual Studio.  
3. **DO NOT** keep production connection strings in `appsettings.json` committed to GitHub.  
   - Set your storage connection string locally in `appsettings.json` or via **User Secrets** or environment variables.
4. Restore NuGet packages and run the app (IIS Express or `dotnet run`).  
5. Use Azure Storage Explorer to verify tables/blobs/queues/files or add sample data.

**Important:** For production / pushed repo, remove or replace any real Azure keys - use Azure App Service Application Settings to provide the connection string when deployed.

---

## Author
Lefa Makhubela 
Module: CLDV6212 - POE Part 1

