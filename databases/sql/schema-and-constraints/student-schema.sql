

CREATE TABLE section (
  section_id INT NOT NULL,
  section_name VARCHAR(50),
  delegate_id INT NOT NULL,
  CONSTRAINT PK_section PRIMARY KEY (section_id)
);

CREATE TABLE professor (
  professor_id INT NOT NULL,
  professor_name VARCHAR(30) NOT NULL,
  professor_surname VARCHAR(30) NOT NULL,
  section_id INT NOT NULL,
  professor_office INT NOT NULL,
  professor_email VARCHAR(30) NOT NULL,
  professor_hire_date DATETIME NOT NULL,
  professor_wage INT NOT NULL,
  CONSTRAINT PK_professor PRIMARY KEY (professor_id),
  CONSTRAINT FK_professor_section 
    FOREIGN KEY (section_id) REFERENCES section(section_id)
);

CREATE TABLE course (
  course_id VARCHAR(8) NOT NULL,
  course_name VARCHAR(200) NOT NULL,
  course_ects DECIMAL(3,1) NOT NULL,
  professor_id INT NOT NULL,
  CONSTRAINT PK_course PRIMARY KEY (course_id),
  CONSTRAINT FK_course_professor 
    FOREIGN KEY (professor_id) REFERENCES professor(professor_id)
);

CREATE TABLE student (
  student_id INT NOT NULL,
  first_name VARCHAR(50),
  last_name VARCHAR(50),
  birth_date DATETIME,
  login VARCHAR(50),
  section_id INT,
  year_result INT,
  course_id VARCHAR(8) NOT NULL,
  CONSTRAINT PK_student PRIMARY KEY (student_id),
  CONSTRAINT FK_student_section 
    FOREIGN KEY (section_id) REFERENCES section(section_id),
  CONSTRAINT FK_student_course
    FOREIGN KEY (course_id) REFERENCES course(course_id)
);

CREATE TABLE grade (
  grade CHAR(2) NOT NULL 
    CHECK (grade IN ('E','TB','B','S','F','I','IG')),
  lower_bound INT NOT NULL,
  upper_bound INT NOT NULL,
  CONSTRAINT PK_grade PRIMARY KEY (grade)
);