# HR-System

REFERENCE
The relational database structure came from this website: https://www.w3resource.com/sql-exercises/employee-database-exercise/index.php

Change Database configurations:
To access the code, go to the path: HR System (folder) > HR System (folder) > EmployeeDatabase.sln
To change database configuration from the code, go to the path: HR System (folder) > HR System (folder) > EmployeeDatabase (folder) > Form1.cs . You can change the database configuration from line 19 that contains the code 
'public static string connectDB = "datasource = localhost; username = root; password =''; database = employees database; SslMode = none";' You can use your own MySQL database server or you can use the one from the instructions below.
If you choose to use your own MySQL database server, you need to also paste the code from step 8 and 9 to insert the tables and rows from the instructions below.

My HR Application uses xampp as its local database, to setup do the following:
1. To download xampp go to the following link: https://www.apachefriends.org/download.html
2. Once you are able to open xampp application, click the Start button for the Modules for Apache and MySQL
3. Click the Admin button for the MySQL Module to access phpMyAdmin website which allows you to configure your local database
4. Click on 'User accounts' on the top navigation bar and check if the row with the following column values exist: 
	column 1: User name - root
	column 2: Host name - localhost
	column 3: Password - No
	column 4: Database name - employees database
5. To create database, click on 'Databases' on the top navigation bar, enter 'employees database' in the Database name input field and click the Create button
6. Click on the 'employees database' on the left navigation bar to access database
7. Click on 'SQL' on the top navigation bar which allows you to perform sql statements where you will need to copy and paste certain code given below
8. To create all the tables of the database copy and paste the following code:

    CREATE TABLE admin(
    admin_id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
    admin_fullname varchar(50),
    admin_username varchar(50),
    admin_password varchar(2500)
    );

    CREATE TABLE employees(
    emp_id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
    emp_name varchar(25),
    job_name varchar(25),
    manager_id int,
    hire_date date,
    salary decimal(10,2),
    commision decimal(7,2),
    dep_id int NOT NULL REFERENCES department(dep_id)
    );

    CREATE TABLE department(
    dep_id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
    dep_name varchar(20),
    dep_location varchar(15)
    );

    CREATE TABLE salary_grade(
    grade int NOT NULL PRIMARY KEY,
    min_salary int,
    max_salary int
    );

9. To insert all the values for each of the tables copy and paste the following code:

    INSERT INTO employees VALUES ('68319','KAYLING','PRESIDENT',NULL,'1991-11-18','6000.00',NULL,'1001'),
    ('66928','BLAZE','MANAGER','68319','1991-05-01','2750.00',NULL,'3001'),
    ('67832','CLARE','MANAGER','68319','1991-06-09','2550.00',NULL,'1001'),
    ('65646','JONAS','MANAGER','68319','1991-04-02','2957.00',NULL,'2001'),
    ('67858','SCARLET','ANALYST','65646','1997-04-19','3100.00',NULL,'2001'),
    ('69062','FRANK','ANALYST','65646','1991-12-03','3100.00',NULL,'2001'),
    ('63679','SANDRINE','CLERK','69062','1990-12-18','900.00',NULL,'2001'),
    ('64989','ADELYN','SALESMAN','66928','1991-02-20','1700.00','400.00','3001'),
    ('65271','WADE','SALESMAN','66928','1991-02-22','1350.00','600.00','3001'),
    ('66564','MADDEN','SALESMAN','66928','1991-09-28','1350.00','1500.00','3001'),
    ('68454','TUCKER','SALESMAN','66928','1991-09-08','1600.00','0.00','3001'),
    ('68736','ADNRES','CLERK','67858','1997-05-23','1200.00',NULL,'2001'),
    ('69000','JULIUS','CLERK','66928','1991-12-03','1050.00',NULL,'3001'),
    ('69324','MARKER','CLERK','67832','1992-01-23','1400.00',NULL,'1001');

    INSERT INTO salary_grade VALUES ('1','800','1300'),
    ('2','1301','1500'),
    ('3','1501','2100'),
    ('4','2101','3100'),
    ('5','3101','9999');

    INSERT INTO department VALUES ('1','Unallocated','Unallocated'),
    ('1001','FINANCE','SYDNEY'),
    ('2001','AUDIT','MELBOURNE'),
    ('3001','MARKETING','PERTH'),
    ('4001','PRODUCTION','BRISBANE');

