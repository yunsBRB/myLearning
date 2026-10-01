SELECT *
FROM student

SELECT first_name, last_name, login
FROM student

SELECT first_name as Prénom
, last_name 'Nom de famille'
, section_id Section
, year_result as "Résultat annuel"
FROM student

SELECT first_name , year_result
, (year_result*100)/20 as [Nouveau Résultat]
FROM student


SELECT (login + CAST(student_id AS VARCHAR)) as PSEUDO
	FROM student

SELECT DISTINCT first_name, last_name
FROM student

SELECT GETDATE() as [Date du jour]
, 'FREE PALESTINE'

SELECT student_id, first_name, last_name, year_result
FROM student
WHERE year_result >= 10
ORDER BY year_result asc

SELECT student_id, first_name, last_name, year_result
FROM student
WHERE year_result BETWEEN 11 AND 18

SELECT student_id, first_name, last_name, year_result
FROM student
WHERE first_name IN ('Tom', 'Jennifer', 'Halle')

SELECT student_id, first_name, last_name, year_result
FROM student
WHERE first_name LIKE 'j%'

SELECT student_id, first_name, last_name, year_result
FROM student
WHERE last_name LIKE '%oo_'


SELECT student_id, first_name, last_name, year_result
FROM student
WHERE year_result NOT BETWEEN 0 AND 10

SELECT student_id, first_name, last_name, year_result
FROM student
WHERE last_name NOT LIKE '%e%'

SELECT section_id
, first_name + ' ' + last_name as 'Nom complet'
FROM student
ORDER BY section_id, 'Nom complet' DESC

SELECT CONVERT (varchar, birth_date, 110)
		as [Date de naissance]
	FROM student

SELECT GETDATE()
, CONVERT (varchar, GETDATE(),109)
, CONVERT (date, GETDATE())
, CONVERT (time, GETDATE())

SELECT AVG (year_result)
,AVG (DATEPART(yy, GETDATE()) - DATEPART (yy, birth_date))
FROM student

SELECT COALESCE(year_result, 42)
			AS 'année'
FROM student
ORDER BY year_result desc


SELECT section_id, AVG(year_result)
FROM student
WHERE LEFT (last_name, 1) IN ('A', 'B', 'C')
GROUP BY section_id
HAVING AVG (year_result) >=10

SELECT section_id, course_id, SUM(year_result) as 'somme'
FROM student
WHERE section_id IN (1010, 1020)
GROUP BY ROLLUP (section_id, course_id)

SELECT section_id, course_id, SUM(year_result) as 'somme'
FROM student
WHERE section_id IN (1010, 1020)
GROUP BY CUBE (section_id, course_id)

SELECT S.first_name, S.last_name, C.course_id, C.course_name
FROM student as S JOIN course  as C on C.course_id = C.course_id

SELECT P.professor_id, P.professor_name, SE.section_id, SE.section_name
FROM professor as S CROSS JOIN professor as P, section as SE

 
SELECT S.section_id, S.section_name, P.professor_name
FROM section S LEFT JOIN professor P
ON S.section_id = P.section_id

SELECT C.course_name, P.professor_name, S.section_name
FROM course C, professor P, section S
WHERE C.professor_id = P.professor_id
	AND P.section_id = S.section_id


SELECT professor_name, professor_surname
FROM professor
UNION
SELECT first_name, last_name
FROM student

SELECT first_name
FROM student
INTERSECT
SELECT professor_name
FROM professor

SELECT first_name
FROM student
EXCEPT
SELECT professor_name
FROM professor

SELECT last_name, year_result
FROM student
WHERE year_result >= (SELECT year_result FROM student
						WHERE last_name LIKE 'Bacon')

SELECT last_name, section_id, year_result
FROM student AS S
WHERE year_result > (SELECT AVG (year_result)
						FROM student
						WHERE section_id = S.section_id)

SELECT first_name, last_name
FROM student as ST
WHERE EXISTS (SELECT* FROM course as cours
				WHERE cours.course_id = ST.course_id
						AND cours.course_id = 'EING2234')