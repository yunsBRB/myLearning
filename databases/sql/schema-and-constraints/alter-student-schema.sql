ALTER TABLE student
ALTER COLUMN course_id VARCHAR (8)

ALTER TABLE student
ADD CONSTRAINT FK_student_course
FOREIGN KEY (course_id) REFERENCES course(course_id)

ALTER TABLE grade
DROP CONSTRAINT CK_grade

ALTER TABLE grade
ADD CONSTRAINT CK_grade
CHECK (grade IN('E','TB', 'B', 'S', 'F', 'I', 'IG', 'N/A'))

ALTER TABLE section
ALTER COLUMN delegate_id INT NULL

ALTER TABLE section
ADD CONSTRAINT FK_student_delegate
FOREIGN KEY (delegate_id) REFERENCES student(student_id);