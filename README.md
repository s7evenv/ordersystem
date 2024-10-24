
# Purchase Order PDF Upload and Viewer

## Overview

This project demonstrates a system where users can upload a PDF purchase order and view it before completing the order. It is implemented using **ASP.NET Core MVC** (C#), **HTML**, **JavaScript**, and **PDF.js** for rendering PDFs in the browser.

## Features

- **PDF Upload**: Users can upload a purchase order in PDF format.
- **PDF Preview**: Uploaded PDFs can be previewed directly in the browser.
- **File Storage**: Uploaded files are stored in the server’s `wwwroot/uploads` directory.
- **Secure Communication**: HTTPS is configured for secure communication.

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/s7evenv/ordersystem.git
   cd your-repo
   ```

2. **Restore dependencies**:
   Use Visual Studio or the .NET CLI:
   ```bash
   dotnet restore
   ```

3. **Run the project**:
   In Visual Studio, press `F5` to run the project or use the following CLI command:
   ```bash
   dotnet run
   ```

4. **Access the application**:
   Go to `https://localhost:7058/PurchaseOrder/Upload` to upload and view PDFs.

## Usage

1. **Upload a PDF**:
   - Use the file input to upload a PDF.
   - The PDF will be displayed below the upload form after submission.

## Project Structure

```
/Controllers
    PurchaseOrderController.cs   # Handles file uploads
/Models
    PurchaseOrderModel.cs        # Model for uploaded files
/Views
    /PurchaseOrder
        Upload.cshtml            # Upload form and PDF preview
/wwwroot
    /uploads                     # Stores uploaded PDFs
    /lib
        /pdfjs                   # PDF.js library for rendering PDFs
```

## License

This project is open for use, modification, and distribution.
