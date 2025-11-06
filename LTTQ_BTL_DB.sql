CREATE DATABASE LTTQ_BTL_DB;
GO
USE LTTQ_BTL_DB;
GO

-- ==============================
-- Table: Role
-- ==============================
CREATE TABLE Role (
    name NVARCHAR(50) PRIMARY KEY
);
GO

-- ==============================
-- Table: User
-- ==============================
CREATE TABLE [User] (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    username NVARCHAR(100) NOT NULL UNIQUE,
    [password] VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),
    update_at DATETIME DEFAULT GETDATE(),
    role_name NVARCHAR(50) NOT NULL,
    FOREIGN KEY (role_name) REFERENCES Role(name)
);
GO

-- ==============================
-- Table: Student
-- ==============================
CREATE TABLE Student (
    id UNIQUEIDENTIFIER PRIMARY KEY,
    full_name NVARCHAR(100) NOT NULL,
    birth_date DATE,
    gender NVARCHAR(10),
    phone_number VARCHAR(20),
    email VARCHAR(100),
    address NVARCHAR(255),
    FOREIGN KEY (id) REFERENCES [User](id)
);
GO

-- ==============================
-- Table: Teacher
-- ==============================
CREATE TABLE Teacher (
    id UNIQUEIDENTIFIER PRIMARY KEY,
    full_name NVARCHAR(100) NOT NULL,
    specialization NVARCHAR(100),
    qualification NVARCHAR(100),
    phone_number VARCHAR(20),
    email VARCHAR(100),
    address NVARCHAR(255),
    start_date DATE,
    FOREIGN KEY (id) REFERENCES [User](id)
);
GO

-- ==============================
-- Table: Course
-- ==============================
CREATE TABLE Course (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    name NVARCHAR(100) NOT NULL,
    description NVARCHAR(255),
    number_of_lessons INT,
    fee DECIMAL(10,2)
);
GO

-- ==============================
-- Table: Class
-- ==============================
CREATE TABLE Class (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    course_id UNIQUEIDENTIFIER NOT NULL,
    name NVARCHAR(100),
    max_students INT,
    start_date DATE,
    teacher_id UNIQUEIDENTIFIER,
    FOREIGN KEY (course_id) REFERENCES Course(id),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(id)
);
GO

-- ==============================
-- Table: Enrollment
-- ==============================
CREATE TABLE Enrollment (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    student_id UNIQUEIDENTIFIER NOT NULL,
    course_id UNIQUEIDENTIFIER NOT NULL,
    enrollment_date DATE DEFAULT GETDATE(),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (course_id) REFERENCES Course(id)
);
GO

-- ==============================
-- Table: ClassAssignment
-- ==============================
CREATE TABLE ClassAssignment (
    student_id UNIQUEIDENTIFIER NOT NULL,
    class_id UNIQUEIDENTIFIER NOT NULL,
    assigned_date DATE DEFAULT GETDATE(),
    PRIMARY KEY (student_id, class_id),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (class_id) REFERENCES Class(id)
);
GO

-- ==============================
-- Table: Schedule
-- ==============================
CREATE TABLE Schedule (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    class_id UNIQUEIDENTIFIER NOT NULL,
    session_date DATE,
    start_time TIME,
    room NVARCHAR(50),
    FOREIGN KEY (class_id) REFERENCES Class(id)
);
GO

-- ==============================
-- Table: Attendance
-- ==============================
CREATE TABLE Attendance (
    student_id UNIQUEIDENTIFIER NOT NULL,
    schedule_id UNIQUEIDENTIFIER NOT NULL,
    status VARCHAR(20) CHECK (status IN ('present', 'absent', 'late', 'excused')),
    note NVARCHAR(255),
    PRIMARY KEY (student_id, schedule_id),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (schedule_id) REFERENCES Schedule(id)
);
GO

-- ==============================
-- Table: Payment
-- ==============================
CREATE TABLE Payment (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    enrollment_id UNIQUEIDENTIFIER NOT NULL,
    amount DECIMAL(10,2),
    payment_date DATE DEFAULT GETDATE(),
    method VARCHAR(20) CHECK (method IN ('none', 'cash', 'bank_transfer', 'credit_card')),
    status VARCHAR(20) CHECK (status IN ('paid', 'pending', 'failed')),
    FOREIGN KEY (enrollment_id) REFERENCES Enrollment(id)
);
GO

-- ==============================
-- Table: Score
-- ==============================

CREATE TABLE Score (
    student_id UNIQUEIDENTIFIER NOT NULL,
    class_id UNIQUEIDENTIFIER NOT NULL,
    score DECIMAL(5,2) CHECK (score >= 0 AND score <= 10),
    created_date DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (class_id) REFERENCES Class(id)
);
GO

-- ==============================
-- Changes
-- ==============================

select * from [User]
-- ==============================
-- 1. Bảng Role
-- ==============================
INSERT INTO Role (name)
VALUES 
(N'admin'),
(N'teacher'),
(N'student');
GO

-- ==============================
-- 2. Bảng User
-- ==============================
INSERT INTO [User] (username, [password], role_name)
VALUES
(N'admin01', 'admin@123', N'admin'),
(N'teacher01', 'teach@123', N'teacher'),
(N'teacher02', 'teach@456', N'teacher'),
(N'student01', 'stud@123', N'student'),
(N'student02', 'stud@456', N'student'),
(N'student03', 'stud@789', N'student');
GO

INSERT INTO [User] (username, [password], role_name)
VALUES
(N'student04', 'stud@100', N'student'),
(N'student05', 'stud@101', N'student'),
(N'student06', 'stud@102', N'student'),
(N'student07', 'stud@103', N'student'),
(N'student08', 'stud@104', N'student'),
(N'student09', 'stud@105', N'student'),
(N'student10', 'stud@106', N'student'),
(N'student11', 'stud@107', N'student'),
(N'student12', 'stud@108', N'student'),
(N'student13', 'stud@109', N'student');
GO
-- ==============================
-- 3. Bảng Student
-- ==============================
INSERT INTO Student (id, full_name, birth_date, gender, phone_number, email, address)
SELECT id, 
    CASE username
        WHEN 'student01' THEN N'Nguyễn Văn A'
        WHEN 'student02' THEN N'Trần Thị B'
        WHEN 'student03' THEN N'Lê Văn C'
    END AS full_name,
    CASE username
        WHEN 'student01' THEN '2003-04-15'
        WHEN 'student02' THEN '2004-07-10'
        WHEN 'student03' THEN '2002-12-01'
    END AS birth_date,
    CASE username
        WHEN 'student01' THEN N'Nam'
        WHEN 'student02' THEN N'Nữ'
        WHEN 'student03' THEN N'Nam'
    END AS gender,
    CASE username
        WHEN 'student01' THEN '0901112222'
        WHEN 'student02' THEN '0903334444'
        WHEN 'student03' THEN '0905556666'
    END AS phone_number,
    username + '@gmail.com',
    N'Hà Nội'
FROM [User]
WHERE role_name = N'student';
GO
INSERT INTO Student (id, full_name, birth_date, gender, phone_number, email, address)
SELECT id, 
    CASE username
        WHEN 'student04' THEN N'Phạm Minh D'
        WHEN 'student05' THEN N'Hoàng Thị E'
        WHEN 'student06' THEN N'Nguyễn Văn F'
        WHEN 'student07' THEN N'Trần Thị G'
        WHEN 'student08' THEN N'Lê Minh H'
        WHEN 'student09' THEN N'Phan Thị I'
        WHEN 'student10' THEN N'Vũ Văn J'
        WHEN 'student11' THEN N'Đỗ Thị K'
        WHEN 'student12' THEN N'Ngô Văn L'
        WHEN 'student13' THEN N'Bùi Thị M'
    END AS full_name,
    CASE username
        WHEN 'student04' THEN '2004-01-10'
        WHEN 'student05' THEN '2003-03-22'
        WHEN 'student06' THEN '2004-05-15'
        WHEN 'student07' THEN '2002-11-05'
        WHEN 'student08' THEN '2003-08-19'
        WHEN 'student09' THEN '2004-09-01'
        WHEN 'student10' THEN '2002-12-20'
        WHEN 'student11' THEN '2003-06-12'
        WHEN 'student12' THEN '2004-07-25'
        WHEN 'student13' THEN '2003-10-30'
    END AS birth_date,
    CASE username
        WHEN 'student04' THEN N'Nam'
        WHEN 'student05' THEN N'Nữ'
        WHEN 'student06' THEN N'Nam'
        WHEN 'student07' THEN N'Nữ'
        WHEN 'student08' THEN N'Nam'
        WHEN 'student09' THEN N'Nữ'
        WHEN 'student10' THEN N'Nam'
        WHEN 'student11' THEN N'Nữ'
        WHEN 'student12' THEN N'Nam'
        WHEN 'student13' THEN N'Nữ'
    END AS gender,
    CASE username
        WHEN 'student04' THEN '0901000004'
        WHEN 'student05' THEN '0901000005'
        WHEN 'student06' THEN '0901000006'
        WHEN 'student07' THEN '0901000007'
        WHEN 'student08' THEN '0901000008'
        WHEN 'student09' THEN '0901000009'
        WHEN 'student10' THEN '0901000010'
        WHEN 'student11' THEN '0901000011'
        WHEN 'student12' THEN '0901000012'
        WHEN 'student13' THEN '0901000013'
    END AS phone_number,
    username + '@gmail.com',
    N'Hà Nội'
FROM [User]
WHERE role_name = N'student'
AND username IN (N'student04', N'student05', N'student06', N'student07', N'student08', 
                 N'student09', N'student10', N'student11', N'student12', N'student13');
GO

-- ==============================
-- 4. Bảng Teacher
-- ==============================
INSERT INTO Teacher (id, full_name, specialization, qualification, phone_number, email, address, start_date)
SELECT id,
    CASE username
        WHEN 'teacher01' THEN N'Phạm Thị D'
        WHEN 'teacher02' THEN N'Ngô Văn E'
    END AS full_name,
    CASE username
        WHEN 'teacher01' THEN N'Tiếng Anh'
        WHEN 'teacher02' THEN N'Tin học'
    END AS specialization,
    N'Thạc sĩ',
    '0911112222',
    username + '@gmail.com',
    N'Hà Nội',
    '2020-09-01'
FROM [User]
WHERE role_name = N'teacher';
GO

-- ==============================
-- 5. Bảng Course
-- ==============================
INSERT INTO Course (name, description, number_of_lessons, fee)
VALUES
(N'Khóa học Tiếng Anh giao tiếp', N'Dành cho người mới bắt đầu', 30, 1500000),
(N'Lập trình C# cơ bản', N'Học cách lập trình C# từ đầu', 40, 2000000),
(N'Tin học văn phòng', N'Sử dụng Word, Excel, PowerPoint', 25, 1200000);
GO

-- ==============================
-- 6. Bảng Class
-- ==============================
INSERT INTO Class (course_id, name, max_students, start_date, teacher_id)
SELECT TOP 1 c.id, N'Lớp TA01', 20, '2024-09-01', t.id
FROM Course c CROSS JOIN Teacher t
WHERE c.name = N'Khóa học Tiếng Anh giao tiếp' AND t.full_name = N'Phạm Thị D'
UNION ALL
SELECT TOP 1 c.id, N'Lớp CS01', 25, '2024-10-01', t.id
FROM Course c CROSS JOIN Teacher t
WHERE c.name = N'Lập trình C# cơ bản' AND t.full_name = N'Ngô Văn E'
UNION ALL
SELECT TOP 1 c.id, N'Lớp THVP01', 30, '2024-08-01', t.id
FROM Course c CROSS JOIN Teacher t
WHERE c.name = N'Tin học văn phòng' AND t.full_name = N'Phạm Thị D';
GO

-- ==============================
-- 7. Bảng Enrollment
-- ==============================
INSERT INTO Enrollment (student_id, course_id)
SELECT s.id, c.id
FROM Student s CROSS JOIN Course c
WHERE (s.full_name = N'Nguyễn Văn A' AND c.name = N'Khóa học Tiếng Anh giao tiếp')
   OR (s.full_name = N'Trần Thị B' AND c.name = N'Lập trình C# cơ bản')
   OR (s.full_name = N'Lê Văn C' AND c.name = N'Tin học văn phòng');
GO

-- ==============================
-- 8. Bảng ClassAssignment
-- ==============================
INSERT INTO ClassAssignment (student_id, class_id)
SELECT s.id, cl.id
FROM Student s CROSS JOIN Class cl
WHERE (s.full_name = N'Nguyễn Văn A' AND cl.name = N'Lớp TA01')
   OR (s.full_name = N'Trần Thị B' AND cl.name = N'Lớp CS01')
   OR (s.full_name = N'Lê Văn C' AND cl.name = N'Lớp THVP01');
GO

-- ==============================
-- 9. Bảng Schedule
-- ==============================
INSERT INTO Schedule (class_id, session_date, start_time, room)
SELECT cl.id, '2024-09-10', '08:00', N'Phòng 101'
FROM Class cl WHERE cl.name = N'Lớp TA01'
UNION ALL
SELECT cl.id, '2024-10-15', '09:00', N'Phòng 202'
FROM Class cl WHERE cl.name = N'Lớp CS01'
UNION ALL
SELECT cl.id, '2024-08-20', '08:30', N'Phòng 303'
FROM Class cl WHERE cl.name = N'Lớp THVP01';
GO

-- ==============================
-- 10. Bảng Attendance
-- ==============================
INSERT INTO Attendance (student_id, schedule_id, status, note)
SELECT s.id, sch.id, 'present', N'Học tốt'
FROM Student s, Schedule sch
WHERE (s.full_name = N'Nguyễn Văn A' AND sch.room = N'Phòng 101')
   OR (s.full_name = N'Trần Thị B' AND sch.room = N'Phòng 202')
   OR (s.full_name = N'Lê Văn C' AND sch.room = N'Phòng 303');
GO

-- ==============================
-- 11. Bảng Payment
-- ==============================
INSERT INTO Payment (enrollment_id, amount, method, status)
SELECT e.id, c.fee, 'bank_transfer', 'paid'
FROM Enrollment e
JOIN Course c ON e.course_id = c.id;
INSERT INTO Payment (enrollment_id, amount, method, status)
SELECT e.id, c.fee, 'bank_transfer', 'pending'
FROM Enrollment e
JOIN Course c ON e.course_id = c.id;
GO

-- ==============================
-- 12. Bảng Score
-- ==============================
INSERT INTO Score (student_id, class_id, score)
SELECT s.id, cl.id, 
    CASE s.full_name
        WHEN N'Nguyễn Văn A' THEN 8.5
        WHEN N'Trần Thị B' THEN 9.0
        WHEN N'Lê Văn C' THEN 7.5
    END AS score
FROM Student s
JOIN ClassAssignment ca ON s.id = ca.student_id
JOIN Class cl ON ca.class_id = cl.id;
GO

 SELECT full_name, birth_date, gender, phone_number, email, address
 FROM Student
 ORDER BY full_name
 select * from Teacher
 select * from [User]
 select * from Student

 select * from Course
 select * from [User] 
 join Teacher on [User].id = Teacher.id
 select * from [User]
 select * from Class join Teacher on Class.teacher_id = Teacher.id join [User] on [User].id = Teacher.id
SELECT id, username, r.name as role from [User] u join [Role] r on u.role_name = r.name WHERE username = 'admin01' AND [password] = 'admin@123'

SELECT 
    *
FROM [User] u
LEFT JOIN Student s ON u.id = s.id AND u.role_name = N'student'
LEFT JOIN Teacher t ON u.id = t.id AND u.role_name = N'teacher'
ORDER BY u.role_name, u.username;

select * from [User] join Teacher on [User].id = Teacher.id

SELECT 
    u.id,
    u.username,
    u.role_name,
    ISNULL(s.full_name, t.full_name) AS full_name,
    ISNULL(s.email, t.email) AS email,
    ISNULL(s.phone_number, t.phone_number) AS phone_number,
    ISNULL(s.address, t.address) AS address,
    s.birth_date,
    s.gender,
    t.specialization,
    t.qualification,
    t.start_date
FROM [User] u
LEFT JOIN Student s ON u.id = s.id AND u.role_name = N'student'
LEFT JOIN Teacher t ON u.id = t.id AND u.role_name = N'teacher'
ORDER BY u.username
OFFSET 1 ROWS
FETCH NEXT 10 ROWS ONLY

SELECT * 
FROM [User]
ORDER BY username
OFFSET 1 ROWS
FETCH NEXT 10 ROWS ONLY

select * from Student 
select * from [User]
SELECT COUNT(*) AS TotalCourses FROM Course
SELECT ISNULL(SUM(P.amount), 0) AS TotalRevenue
FROM Payment P

select * from Enrollment

SELECT COUNT(*) AS TotalEnrollments
FROM Enrollment
WHERE YEAR(enrollment_date) = 2024

SELECT 
    YEAR(S.session_date) AS Year,
    COUNT(A.student_id) AS TotalStudents,
    SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) AS Present,
    SUM(CASE WHEN A.status = 'absent' THEN 1 ELSE 0 END) AS Absent,
    SUM(CASE WHEN A.status = 'late' THEN 1 ELSE 0 END) AS Late,
    SUM(CASE WHEN A.status = 'excused' THEN 1 ELSE 0 END) AS Excused
FROM Schedule S
LEFT JOIN Attendance A ON S.id = A.schedule_id
WHERE S.class_id = '8404521C-71C2-4797-B31C-E7FAE80DC135' AND YEAR(S.session_date) = 2024
GROUP BY YEAR(S.session_date)
select * from Class
select * from Schedule join Attendance on Schedule.id = Attendance.schedule_id
select * from Attendance

SELECT 
    C.name AS CourseName,
    COUNT(E.id) AS TotalEnrollments
FROM Enrollment E
JOIN Course C ON E.course_id = C.id
WHERE YEAR(E.enrollment_date) = 2025
GROUP BY C.name
ORDER BY TotalEnrollments DESC


SELECT 
    C.name AS CourseName,
    COUNT(E.id) AS TotalEnrollments
FROM Enrollment E
JOIN Course C ON E.course_id = C.id
WHERE YEAR(E.enrollment_date) = 2025
GROUP BY C.name
ORDER BY TotalEnrollments DESC

select * from Payment

SELECT ISNULL(SUM(P.amount), 0) AS TotalRevenue
FROM Payment P
WHERE CAST(P.payment_date AS DATE) = '2025-11-01' AND P.status = 'paid'

select * from Enrollment
SELECT 
    C.name AS CourseName,
    COUNT(E.id) AS TotalEnrollments
FROM Enrollment E
JOIN Course C ON E.course_id = C.id
WHERE CAST(E.enrollment_date AS DATE) = '2025-11-03'
GROUP BY C.name
ORDER BY TotalEnrollments DESC;
select * from Schedule
select * from Attendance

SELECT 
    S.session_date AS SessionDate,
    COUNT(A.student_id) AS TotalStudents,
    SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) AS Present,
    SUM(CASE WHEN A.status = 'absent' THEN 1 ELSE 0 END) AS Absent,
    SUM(CASE WHEN A.status = 'late' THEN 1 ELSE 0 END) AS Late,
    SUM(CASE WHEN A.status = 'excused' THEN 1 ELSE 0 END) AS Excused
FROM Schedule S
LEFT JOIN Attendance A ON S.id = A.schedule_id
WHERE S.class_id = '8404521C-71C2-4797-B31C-E7FAE80DC135' 
GROUP BY S.session_date;
SELECT 
    C.name AS ClassName,
    COUNT(A.student_id) AS TotalStudents,
    SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) AS Present,
    SUM(CASE WHEN A.status = 'absent' THEN 1 ELSE 0 END) AS Absent,
    SUM(CASE WHEN A.status = 'late' THEN 1 ELSE 0 END) AS Late,
    SUM(CASE WHEN A.status = 'excused' THEN 1 ELSE 0 END) AS Excused
FROM Schedule S
LEFT JOIN Attendance A ON S.id = A.schedule_id
left JOIN Class C ON S.class_id = C.id
WHERE CAST(S.session_date AS DATE) = '2024-09-10'
GROUP BY C.name
ORDER BY C.name

SELECT 
    C.name AS CourseName,
    COUNT(E.id) AS TotalEnrollments
FROM Enrollment E
left JOIN Course C ON E.course_id = C.id
WHERE YEAR(E.enrollment_date) = 2024
GROUP BY C.name
ORDER BY TotalEnrollments DESC

select * from Class
select * from Class
left join Schedule on Class.id = Schedule.class_id
WHERE CAST(session_date AS DATE) = '2024-09-10'
DECLARE @schedule_id UNIQUEIDENTIFIER;
SELECT @schedule_id = id FROM Schedule WHERE room = N'Phòng 101';

select * from Schedule
DECLARE @target_date DATE = '2024-09-10';

SELECT 
    C.name AS ClassName,
    @target_date AS TargetDate,
    COUNT(A.student_id) AS TotalStudents,
    SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) AS Present,
    SUM(CASE WHEN A.status = 'absent' THEN 1 ELSE 0 END) AS Absent,
    SUM(CASE WHEN A.status = 'late' THEN 1 ELSE 0 END) AS Late,
    SUM(CASE WHEN A.status = 'excused' THEN 1 ELSE 0 END) AS Excused
FROM Class C
LEFT JOIN Schedule S 
    ON C.id = S.class_id AND CAST(S.session_date AS DATE) = @target_date
LEFT JOIN Attendance A 
    ON S.id = A.schedule_id
GROUP BY C.name
ORDER BY C.name;

SELECT 
    C.name AS ClassName,
    COUNT(A.student_id) AS TotalStudents,
    SUM(CASE WHEN A.status = 'present' THEN 1 ELSE 0 END) AS Present,
    SUM(CASE WHEN A.status = 'absent' THEN 1 ELSE 0 END) AS Absent,
    SUM(CASE WHEN A.status = 'late' THEN 1 ELSE 0 END) AS Late,
    SUM(CASE WHEN A.status = 'excused' THEN 1 ELSE 0 END) AS Excused
FROM Class C
LEFT JOIN Schedule S ON C.id = S.class_id AND YEAR(S.session_date) = 2024
LEFT JOIN Attendance A ON S.id = A.schedule_id
GROUP BY C.name
ORDER BY C.name

select * from Class left join Schedule ON Class.id = Schedule.class_id
-- Thêm nhiều học viên vào buổi học này
INSERT INTO Attendance (student_id, schedule_id, status, note)
SELECT s.id, @schedule_id, v.status, v.note
FROM Student s
JOIN (VALUES
    (N'Nguyễn Văn A', 'present', N'Đi học đúng giờ'),
    (N'Trần Thị B', 'absent',  N'Xin nghỉ có phép'),
    (N'Lê Văn C',    'late',   N'Đến muộn 10 phút'),
    (N'Phạm Minh D', 'excused',N'Nghỉ do ốm')
) AS v(full_name, status, note)
    ON s.full_name = v.full_name;

	select * from score

	 SELECT 
     id AS ClassId,
     name AS ClassName
 FROM Class
 ORDER BY name

  SELECT id, name FROM Class;


  SELECT 
    C.name AS ClassName,
    ISNULL(AVG(S.score), 0) AS AverageScore
FROM Class C
LEFT JOIN Score S ON C.id = S.class_id AND YEAR(S.created_date) =2025
GROUP BY C.name
ORDER BY C.name

SELECT 
    ISNULL(COUNT(*), 0) AS TotalScores,
    ISNULL(SUM(CASE WHEN score >= 9 THEN 1 ELSE 0 END), 0) AS N'Xuất sắc',
    ISNULL(SUM(CASE WHEN score >= 7 AND score < 9 THEN 1 ELSE 0 END), 0) AS N'Tốt',
    ISNULL(SUM(CASE WHEN score >= 5 AND score < 7 THEN 1 ELSE 0 END), 0) AS N'Trung bình',
    ISNULL(SUM(CASE WHEN score < 5 THEN 1 ELSE 0 END), 0) AS N'Yếu'
FROM Score
WHERE class_id = '{classId}' AND YEAR(created_date) = 2025

 SELECT 
     id AS ClassId,
     name AS ClassName
 FROM Class
 ORDER BY name

 select * from Payment
 join Enrollment on Enrollment.id = Payment.enrollment_id
 join Student on Student.id = Enrollment.student_id

 select * from Enrollment

 SELECT 
    S.full_name AS StudentName,
    C.name AS CourseName,
    P.payment_date AS PaymentDate,
    P.amount AS Amount,
    P.status AS Status
FROM Payment P
JOIN Enrollment E ON P.enrollment_id = E.id
JOIN Student S ON E.student_id = S.id
JOIN Course C ON E.course_id = C.id
WHERE YEAR(P.payment_date) = 2025
ORDER BY P.payment_date DESC

select * from Enrollment

select * from Attendance join Schedule on Schedule.id = Attendance.schedule_id 
select * from Class 
join Schedule on Schedule.class_id = Class.id


select * from Score join Student on Student.id = Score.student_id
select * from Score
SELECT 
    C.name AS ClassName,
    St.full_name AS StudentName,
    S.score AS ScoreValue,
    S.created_date AS ScoreDate
FROM Score S
JOIN Class C ON S.class_id = C.id
JOIN Student St ON S.student_id = St.id
WHERE YEAR(S.created_date) = 2025
ORDER BY C.name, St.full_name, S.created_date

select * from [User]