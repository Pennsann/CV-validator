# CV Validator
A C# Windows Forms application for validating user form input and parsing CV content using Regular Expressions (Regex).

## team members
-Abdalrhman Ahmed Sayed | 221101047
-Youssef Mosbah Hagag | 221101068

## Features

### 1. Manual Form Entry
- User can enter:
  - Name
  - Email
  - Phone Number
  - Password
  - Address
  - Postal Code
- Each input is validated using Regex
- Feedback is shown in a message box

### 2. CV Text Parsing
- Paste or upload plain-text CV content
- Automatically extracts:
  - Full Name
  - Email Address
  - Phone Number
  - Skills (e.g., C#, Java, SQL)
  - Years of Experience (e.g., "3 years")
- Results are displayed in a message box

 ## Tech Stack

- C#
- .NET Windows Forms
- Regex (System.Text.RegularExpressions)
- 
 ## How to Use

1. Clone the repository
2. Open the solution in Visual Studio
3. Run the project
4. Test form validation and CV parsing

## Example CV Input
```
الاسم: أحمد العلي
البريد الإلكتروني: ahmed.alali@example.com
رقم الهاتف: +966500000000
المهارات: Python, Excel, Git
الخبرة: 5 سنوات
```
```
Name: Sarah Thompson
Email: sarah.thompson@example.com
Phone: +12345678901
Skills: Python, SQL, Excel
Experience: 3 years
```
