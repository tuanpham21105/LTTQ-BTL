
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
        avatar NVARCHAR(100),
        status VARCHAR(20) DEFAULT 'Active' CHECK (status IN ('Active', 'Inactive')),
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
        fee DECIMAL(10,2),
        status VARCHAR(20) DEFAULT 'Active' CHECK (status IN ('Active', 'Inactive')),
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
        FOREIGN KEY (teacher_id) REFERENCES Teacher(id),
        status VARCHAR(20) DEFAULT 'Active' CHECK (status IN ('Active', 'Inactive')),
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
        FOREIGN KEY (course_id) REFERENCES Course(id),
        status VARCHAR(20) DEFAULT 'Enrolled' CHECK (status IN ('Enrolled', 'Cancelled')),
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
        status VARCHAR(20) CHECK (status IN ('Present', 'Absent', 'Late', 'Excused')),
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
        enrollment_id UNIQUEIDENTIFIER,
        amount DECIMAL(10,2),
        payment_date DATE DEFAULT GETDATE(),
        method VARCHAR(20) CHECK (method IN ('None', 'Cash', 'Bank transfer', 'Credit card')),
        status VARCHAR(20) CHECK (status IN ('Paid', 'Pending', 'Cancelled')),
        fee_collector_id UNIQUEIDENTIFIER,
        payer_id UNIQUEIDENTIFIER,
        FOREIGN KEY (enrollment_id) REFERENCES Enrollment(id),
        FOREIGN KEY (fee_collector_id) REFERENCES [User](id),
        FOREIGN KEY (payer_id) REFERENCES [User](id),
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

    USE LTTQ_BTL_DB;
CREATE TABLE Role (
    name NVARCHAR(50) PRIMARY KEY
);
GO

----------------------------------------------------------
-- 2️⃣ BẢNG USER
----------------------------------------------------------
CREATE TABLE [User] (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    username NVARCHAR(100) NOT NULL UNIQUE,
    [password] VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),
    update_at DATETIME DEFAULT GETDATE(),
    role_name NVARCHAR(50) NOT NULL,
    avatar NVARCHAR(100),
    status VARCHAR(20) DEFAULT 'Active' CHECK (status IN ('Active', 'Inactive')),
    FOREIGN KEY (role_name) REFERENCES Role(name)
);
GO

----------------------------------------------------------
-- 3️⃣ BẢNG STUDENT
----------------------------------------------------------
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

----------------------------------------------------------
-- 4️⃣ BẢNG TEACHER
----------------------------------------------------------
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

----------------------------------------------------------
-- 5️⃣ BẢNG COURSE
----------------------------------------------------------
CREATE TABLE Course (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    name NVARCHAR(100) NOT NULL,
    description NVARCHAR(255),
    number_of_lessons INT,
    fee DECIMAL(10,2),
    status VARCHAR(20) DEFAULT 'Active' CHECK (status IN ('Active', 'Inactive'))
);
GO

----------------------------------------------------------
-- 6️⃣ BẢNG CLASS
----------------------------------------------------------
CREATE TABLE Class (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    course_id UNIQUEIDENTIFIER NOT NULL,
    name NVARCHAR(100),
    max_students INT,
    start_date DATE,
    teacher_id UNIQUEIDENTIFIER,
    status VARCHAR(20) DEFAULT 'Active' CHECK (status IN ('Active', 'Inactive')),
    FOREIGN KEY (course_id) REFERENCES Course(id),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(id)
);
GO

----------------------------------------------------------
-- 7️⃣ BẢNG ENROLLMENT
----------------------------------------------------------
CREATE TABLE Enrollment (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    student_id UNIQUEIDENTIFIER NOT NULL,
    course_id UNIQUEIDENTIFIER NOT NULL,
    enrollment_date DATE DEFAULT GETDATE(),
    status VARCHAR(20) DEFAULT 'Enrolled' CHECK (status IN ('Enrolled', 'Cancelled')),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (course_id) REFERENCES Course(id)
);
GO

----------------------------------------------------------
-- 8️⃣ BẢNG CLASSASSIGNMENT
----------------------------------------------------------
CREATE TABLE ClassAssignment (
    student_id UNIQUEIDENTIFIER NOT NULL,
    class_id UNIQUEIDENTIFIER NOT NULL,
    assigned_date DATE DEFAULT GETDATE(),
    PRIMARY KEY (student_id, class_id),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (class_id) REFERENCES Class(id)
);
GO

----------------------------------------------------------
-- 9️⃣ BẢNG SCHEDULE
----------------------------------------------------------
CREATE TABLE Schedule (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    class_id UNIQUEIDENTIFIER NOT NULL,
    session_date DATE,
    start_time TIME,
    room NVARCHAR(50),
    FOREIGN KEY (class_id) REFERENCES Class(id)
);
GO

----------------------------------------------------------
-- 🔟 BẢNG ATTENDANCE
----------------------------------------------------------
CREATE TABLE Attendance (
    student_id UNIQUEIDENTIFIER NOT NULL,
    schedule_id UNIQUEIDENTIFIER NOT NULL,
    status VARCHAR(20) CHECK (status IN ('Present', 'Absent', 'Late', 'Excused')),
    note NVARCHAR(255),
    PRIMARY KEY (student_id, schedule_id),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (schedule_id) REFERENCES Schedule(id)
);
GO

----------------------------------------------------------
-- 1️⃣1️⃣ BẢNG PAYMENT
----------------------------------------------------------
CREATE TABLE Payment (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    enrollment_id UNIQUEIDENTIFIER,
    amount DECIMAL(10,2),
    payment_date DATE DEFAULT GETDATE(),
    method VARCHAR(20) CHECK (method IN ('None', 'Cash', 'Bank transfer', 'Credit card')),
    status VARCHAR(20) CHECK (status IN ('Paid', 'Pending', 'Cancelled')),
    fee_collector_id UNIQUEIDENTIFIER,
    payer_id UNIQUEIDENTIFIER,
    FOREIGN KEY (enrollment_id) REFERENCES Enrollment(id),
    FOREIGN KEY (fee_collector_id) REFERENCES [User](id),
    FOREIGN KEY (payer_id) REFERENCES [User](id)
);
GO

----------------------------------------------------------
-- 1️⃣2️⃣ BẢNG SCORE
----------------------------------------------------------
CREATE TABLE Score (
    student_id UNIQUEIDENTIFIER NOT NULL,
    class_id UNIQUEIDENTIFIER NOT NULL,
    score DECIMAL(5,2) CHECK (score >= 0 AND score <= 10),
    created_date DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (class_id) REFERENCES Class(id)
);
GO

USE LTTQ_BTL_DB;
GO
select * from class
;WITH ExtraStudents AS (
    SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) + 20 AS rn,
           full_name, birth_date, gender, phone, email, address
    FROM (VALUES
        (N'Phan Quốc Huy','2004-06-21',N'Nam','0901111021','huy.phan@gmail.com',N'Hà Nội'),
        (N'Võ Ngọc Ánh','2005-07-30',N'Nữ','0901111022','anh.vo@gmail.com',N'Hồ Chí Minh'),
        (N'Đặng Tuấn Anh','2003-08-02',N'Nam','0901111023','anh.dang@gmail.com',N'Đà Nẵng'),
        (N'Nguyễn Mai Phương','2005-02-05',N'Nữ','0901111024','phuong.nguyen@gmail.com',N'Hà Nội'),
        (N'Trần Đình Duy','2004-03-27',N'Nam','0901111025','duy.tran@gmail.com',N'Hồ Chí Minh'),
        (N'Lưu Hoàng Lan','2004-09-19',N'Nữ','0901111026','lan.luu@gmail.com',N'Hà Nội'),
        (N'Ngô Minh Quân','2003-11-11',N'Nam','0901111027','quan.ngo@gmail.com',N'Cần Thơ'),
        (N'Phạm Ngọc Trâm','2005-01-24',N'Nữ','0901111028','tram.pham@gmail.com',N'Hà Nội'),
        (N'Đoàn Đức Thắng','2004-07-12',N'Nam','0901111029','thang.doan@gmail.com',N'Hà Nội'),
        (N'Hoàng Thị Yến','2005-05-09',N'Nữ','0901111030','yen.hoang@gmail.com',N'Hà Nội'),
        (N'Nguyễn Quốc Vinh','2003-10-10',N'Nam','0901111031','vinh.nguyen@gmail.com',N'Hà Nội'),
        (N'Đinh Ngọc Hà','2005-11-22',N'Nữ','0901111032','ha.dinh@gmail.com',N'Hà Nội'),
        (N'Phan Minh Khôi','2004-12-30',N'Nam','0901111033','khoi.phan@gmail.com',N'Hồ Chí Minh'),
        (N'Lê Thanh Tùng','2003-09-04',N'Nam','0901111034','tung.le@gmail.com',N'Hà Nội'),
        (N'Nguyễn Bảo Ngọc','2005-03-14',N'Nữ','0901111035','ngoc.nguyen@gmail.com',N'Đà Nẵng'),
        (N'Trần Văn Tài','2004-01-01',N'Nam','0901111036','tai.tran@gmail.com',N'Cần Thơ'),
        (N'Lương Thị Thanh','2005-08-20',N'Nữ','0901111037','thanh.luong@gmail.com',N'Hà Nội'),
        (N'Phạm Gia Bảo','2003-07-07',N'Nam','0901111038','bao.pham@gmail.com',N'Hà Nội'),
        (N'Trịnh Hồng Nhung','2005-02-09',N'Nữ','0901111039','nhung.trinh@gmail.com',N'Hà Nội'),
        (N'Đỗ Quang Minh','2004-11-25',N'Nam','0901111040','minh.do@gmail.com',N'Hà Nội'),
        (N'Vũ Thị Thu','2005-06-05',N'Nữ','0901111041','thu.vu@gmail.com',N'Hà Nội'),
        (N'Lê Hoàng Phúc','2004-12-18',N'Nam','0901111042','phuc.le@gmail.com',N'Hà Nội'),
        (N'Nguyễn Thị Thanh','2005-03-30',N'Nữ','0901111043','thanh.nguyen@gmail.com',N'Hà Nội'),
        (N'Bùi Đức Anh','2003-09-01',N'Nam','0901111044','anh.bui@gmail.com',N'Hà Nội'),
        (N'Trần Mỹ Linh','2005-07-12',N'Nữ','0901111045','linh.tran@gmail.com',N'Hồ Chí Minh'),
        (N'Phạm Duy Khánh','2003-10-15',N'Nam','0901111046','khanh.pham@gmail.com',N'Đà Nẵng'),
        (N'Đoàn Hoàng Quân','2004-04-10',N'Nam','0901111047','quan.doan@gmail.com',N'Hà Nội'),
        (N'Lý Thị Hồng','2005-08-23',N'Nữ','0901111048','hong.ly@gmail.com',N'Hà Nội'),
        (N'Nguyễn Thanh Tùng','2003-12-28',N'Nam','0901111049','tung.nguyen@gmail.com',N'Hà Nội'),
        (N'Trần Hồng Vân','2005-09-30',N'Nữ','0901111050','van.tran@gmail.com',N'Hà Nội')
    ) AS X(full_name,birth_date,gender,phone,email,address)
)
INSERT INTO Student (id, full_name, birth_date, gender, phone_number, email, address)
SELECT U.id, e.full_name, e.birth_date, e.gender, e.phone, e.email, e.address
FROM [User] U
JOIN ExtraStudents e ON e.rn = CAST(SUBSTRING(U.username, 9, 3) AS INT)
WHERE U.role_name = N'student' AND CAST(SUBSTRING(U.username, 9, 3) AS INT) BETWEEN 21 AND 50;
GO

PRINT N'✅ ĐÃ BỔ SUNG ĐỦ 50 HỌC VIÊN!';
GO
