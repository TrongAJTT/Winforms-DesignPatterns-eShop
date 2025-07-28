[Tiếng Việt](README.md)  |  English
---
3S eShop is a project for the Design Patterns course, including a Winforms software to manage electronic component sales integrated with design patterns.

The project is for academic purposes and internal non-commercial use. For commercial use, please ensure full compliance with copyright for images used and citations in the project.

---
# Team Member Information:

| Member Name                                       | Student ID | Note |
| -----------------                                 | ---------- | ---- |
| TrongAJTT                                         | Censored   | PM   |
| [TDEV](https://github.com/TDeV-VN/)               | Censored   |      |
| [lizNguyen235](https://github.com/lizNguyen235)   | Censored   |      |

---
# Screenshots

<div align="center">
    <div>
        <img src="https://github.com/user-attachments/assets/31bb9150-f3bb-4134-8a40-c5ba4e48ed7c" width="45%" />
        <img src="https://github.com/user-attachments/assets/8e6230c6-0f4c-4c97-9ed2-7a863efb5f63" width="45%" />
        <img src="https://github.com/user-attachments/assets/387815f5-faf9-43de-9d9d-c776387372ba" width="45%" />
        <img src="https://github.com/user-attachments/assets/582754a4-814f-4b90-819d-f7564b319c08" width="45%" />
        <img src="https://github.com/user-attachments/assets/68813c1a-3b4f-4ade-8722-4f2d7d337e4c" width="45%" />
        <img src="https://github.com/user-attachments/assets/ef6f9fae-796c-4fdc-a972-b9aa5f58c297" width="45%" />
        <img src="https://github.com/user-attachments/assets/12e4600c-b1da-4bd0-b1a2-fc2fbfbdfdfc" width="45%" />
        <img src="https://github.com/user-attachments/assets/dd2d4cae-7fd0-4d8c-bf95-d910f81ec83e" width="45%" />
    </div>
</div>

---
# Brief Product Information:

- The group's initial product is software to support managing electronic component sales. However, the admin can add categories as desired.
- The main goal of the project is to integrate at least 10 design patterns into the software.
- Features include:
  - Login and register accounts.
  - Custom product search with filters.
  - View product information and place orders without an account.
  - Chat with Customer Service (basic use case is admin account replying).
  - Account management functions (unfinished), category, manufacturer, product management (unfinished), admin order management (not available).
  - Support multiple databases: MySQL, SQL Server (not fully stable yet).
- Technologies applied:
  - Google Cloud API.
  - MySQL database.
  - Distributed Redis database.
  - Simple one-way AES-256 encryption (in production, this would be implemented on the backend).
- The group decided to build a product of moderate scale to apply design patterns, focusing on product workflow. Therefore, the architecture only has the client-side connecting directly to the database and data storage, without a server. The group acknowledges this architecture is extremely insecure because the client needs the secret to operate (by standard, the secret MUST be on the server). However, the product's purpose is to apply operational processes, so this is acceptable for internal use only. For product expansion and production deployment, a separate backend should be built to handle data-related logic.

---
# Design Patterns Applied in the Project:

| No. | Name             | Purpose                                                                                                                                                                                                                                                             |
| --- | ---------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 1   | Singleton        | - Logging to file.<br>- Provide a single instance to access the database.                                                                                                                                                                                           |
| 2   | Strategy         | Validate the content of a TextBox by creating a Custom TextBox.                                                                                                                                                                                                     |
| 3   | Command          | Enable and disable system buttons.                                                                                                                                                                                                                                 |
| 4   | Simple Factory   | Create User Controls for the MainForm.                                                                                                                                                                                                                              |
| 5   | Abstract Factory | Provide multi-database connection functionality for the software (MySQL, SQL Server).                                                                                                                                                                               |
| 6   | Observer         | Update the system's OTP countdown status and monitor the progress of product creation/update.                                                                                                                                                                        |
| 7   | Decorator        | Filter data displayed to the user.                                                                                                                                                                                                                                  |
| 8   | Facade           | Encapsulate common behaviors such as add, delete, and edit into a single class; complexity is managed by the Facade class.                                                                                                                                           |
| 9   | Builder          | Separate the object initialization process from the class structure, making the code easier to read and maintain, and avoiding the need to write many constructors or complex initialization methods.                                                             |
| 10  | Template Method  | Reduce code duplication when operations share the same logic flow, increase maintainability by requiring changes to the common process to be made only in one place, fulfilling the Open/Closed Principle in SOLID.                                                   |
| 11  | Flyweight        | Optimize memory usage and speed up loading when displaying many duplicate images on the screen.                                                                                                                                                                      |
| 12  | State            | Manage the state of a confirmation button that requires being pressed twice.                                                                                                                                                                                        |

---
# Instructions to run and continue development:

1. Create a Google Console project:
    - Create an OAuth Client for Desktop applications.
    - Enable DriveAPI.
    - Download `GDriveCredentials.json` and `GOathCredentials.json` files and move them into the `secret_data` folder, overwriting the existing json files.
    - Access the Drive service with the account managed by the Google Console project, create a folder to store the current application's data, copy the folder ID and fill it into the `GDRIVE_FOLDER_ID` key in the `.env` file (inside the `secret_data` folder).
2. Create a MySQL database on any platform (local or hosting):
    - Create schema `3S_eShopDb`.
    - Restore data using the `3S-eShop-MySql-dump.sql` file.
        - Note: This dump file contains some data but excludes image data stored on Google.
    - Fill in the database connection info in the `.env` file:
        - `DB_HOST`: database server address.
        - `DB_PORT`: database port number.
        - `DB_USER`: database user with access rights.
        - `DB_PASS`: database password.
        - `DB_NAME`: database schema name.
        - `DB_CONN`: connection string with structure: `Server=DB_HOST;Port=DB_PORT;Database=DB_NAME;Uid=DB_USER;Pwd=DB_PASS;`
        - `DB_TYPE`: keep as `mysql`.
    - Note: You may switch to SQL Server but compatibility is not fully guaranteed (then set `DB_TYPE` to `sqlserver`).
3. Create a Redis database on any platform, then fill in the access info in the `.env` file:
    - `REDIS_HOST`: Redis server address.
    - `REDIS_PORT`: Redis port number.
    - `REDIS_USER`: Redis access user.
    - `REDIS_PASS`: Redis access password.
4. Set up the email sending service:
	- Configure an endpoint to send emails with the sender's email and password.
	- Example with Gmail:
		- Access an existing Gmail account (or create a new one), enable two-factor authentication to allow sending emails via SMTP protocol.
		- Go to [App Passwords](https://myaccount.google.com/apppasswords), create a new App name, click 'Create', and get the App password for sending emails. Note that this password is not your email account password, but is used by third-party apps to access Google's email sending service.
	- Open the `EmailService.cs` file in the Utilities folder and enter the information for SmtpHost, SenderEmail, and SenderPassword.
5. Open the project in Microsoft Visual Studio and run in Debug or Release mode; the program will automatically load necessary data from the `secret_data` folder to connect to the database and Google Cloud API.

---
# Accounts

Default admin account provided in the database:

- admin@admin.com
- 123123

Note: Many other pre-created accounts in the database also have the password 123123.

---
# Project folder structure:

```
3S eShop/
 │
 ├── BLL/                         Business logic layer.
 │   ├── DTOs/                    Folder containing data attribute storage classes.
 │   │   ├── BaseDTO.cs           Basic interface for data object classes, which must implement this interface.
 │   │   └── *DTO.cs              Data attribute storage classes used for data transfer.
 │   └── *BLL.cs                  Classes containing business logic, called by UI layer. Acts as intermediary between UI and data access layers.
 ├── CustomControls/              Folder containing custom controls.
 │   └── *.cs                     Custom control classes.
 ├── DAL/                         Data access layer.
 │   ├── DAOs/                    Folder containing abstract classes for data access from the database.
 │   │   ├── ICrusRepository.cs   Interface defining minimum required methods for different data objects.
 │   │   └── *DAO.cs              Data access classes interacting directly with database connection classes, implementing the above interface.
 │   └── Database/                Folder containing classes to create database connections and basic data handling functions.
 │       └── *.cs                 Classes for connecting to databases (MySQL, SQL Server, Redis).
 ├── GUI/                         User interface layer.
 │   └── *                        UI classes and files.
 ├── Other/                       Folder for classes and files of unclear classification (if any).
 │   └── *                        Miscellaneous classes and files.
 ├── PatternDistinctive/          Folder containing distinctive classes for design patterns.
 │   └── */*                      Design pattern-specific classes stored in folders named after the pattern.
 ├── Resources/                   Folder containing software resources.
 │   └── *                        Static resource files.
 ├── Utilities/                   Folder containing utility classes.
 │   └── *.cs                     Utility files and classes.
 └── *                            Other files and folders.
```

---
# Credits & Author Contributions

## 1. Resource Images, Icons

- [Author Attributes](Resources/Author%20Attributes.md)

## 2. Packages used

| Package Name                               | Version | Purpose                                                               | License     |
| ------------------------------------------ | ------- | --------------------------------------------------------------------- | ----------- |
| BouncyCastle.Crypto                        | 2.3.1   | Encryption library providing security algorithms                      | MIT License |
| Microsoft.NETCore.Platforms                | 3.1.0   | .NET Core platform support, hardware architecture info                | MIT License |
| Microsoft.Win32.Registry                   | 4.3.0   | Access and manipulate Windows Registry                                | MIT License |
| Microsoft.Windows.Compatibility            | 6.0.0   | Compatibility for .NET Core apps on Windows                           | MIT License |
| Newtonsoft.Json                            | 9.0.1   | JSON processing, serialization and deserialization                    | MIT License |
| System.Data.SqlClient                      | 4.8.3   | Connect and operate with SQL Server                                   | MIT License |
| System.Security.Cryptography.ProtectedData | 4.3.0   | Encrypt and decrypt data based on Windows Data Protection API (DPAPI) | MIT License |
| System.ValueTuple                          | 4.0.3   | Support for tuple data types                                          | MIT License |

## 3. References

- Custom Toast Message:
    - https://laptrinhvb.net/bai-viet/devexpress/---Csharp----Hien-thi-thi-thong-bao-Toast-Message-trong-lap-trinh-Winform/956187c4983d410c.html
- Custom Controls by RJ Code Advance:
    - https://www.youtube.com/watch?v=m7Iv6xfjnuw&list=PLwG-AtjFaHdMQtyReCzPdEe6fZ57TqJUs