This project is a Patient Management System application developed using C# (Windows Forms) and powered by a SQLite database.
The application performs essential CRUD operations, including adding, listing, updating, and deleting patient records.

The project is designed in accordance with layered architecture principles (Data Access Layer – DAL).
Database access logic is separated from the user interface to achieve a more readable, maintainable, and scalable structure.
This approach aligns with best practices commonly used in large-scale and enterprise-level software development.

Communication with the database is handled using ADO.NET. Upon the first launch of the application, the SQLite database and required tables are created automatically.
The National Identification Number (NationalId) is designed to be unique for each patient and is used as the primary identifier throughout the system.
Patient search, update, and delete operations are performed based on the NationalId.

For each patient, the system stores personal information including first name, last name, national identification number, phone number, gender, blood type, and date of birth.
The user interface is developed using Windows Forms, while the business logic and database operations are managed independently from the UI layer.

This project was developed to gain hands-on experience in database management, layered architecture design, and desktop application development,
and to establish a foundation aligned with corporate software development standards.

Technologies Used:
C#, Windows Forms, SQLite, ADO.NET, Data Access Layer (DAL)
