-- Nettoyage (ordre important à cause des FK)
DELETE FROM student;
DELETE FROM course;
DELETE FROM professor;
DELETE FROM section;
DELETE FROM grade;

-- SECTION
INSERT INTO section VALUES (1010, 'BSc Management', 12);
INSERT INTO section VALUES (1020, 'MSc Management', 9);
INSERT INTO section VALUES (1110, 'BSc Economics', 15); -- corrigé (1111 -> 1110)
INSERT INTO section VALUES (1120, 'MSc Economics', 6);
INSERT INTO section VALUES (1310, 'BA Sociology', 23);
INSERT INTO section VALUES (1320, 'MA Sociology', 6);

-- PROFESSOR (ordre + types corrigés)
INSERT INTO professor VALUES (1, 'pietro', 'zidda', 1020, 402, 'pzidda', '2004-12-11', 1900);
INSERT INTO professor VALUES (2, 'alain', 'decrop', 1120, 403, 'adecrop', '2003-05-09', 1950);
INSERT INTO professor VALUES (3, 'pierre', 'giot', 1310, 404, 'pgiot', '2002-12-21', 2100);
INSERT INTO professor VALUES (4, 'christelle', 'lecourt', 1310, 406, 'clecourt', '2003-05-07', 1750);
INSERT INTO professor VALUES (5, 'georges', 'scheppens', 1020, 410, 'gscheppens', '1986-10-09', 2450);
INSERT INTO professor VALUES (6, 'francois', 'louveaux', 1110, 407, 'flouveaux', '1990-05-07', 2200);

-- COURSE (professor_id doit exister)
INSERT INTO course VALUES ('EING2234', 'Derivatives', 3.0, 3);
INSERT INTO course VALUES ('ECGE2184', 'Marketing management', 3.5, 2);
INSERT INTO course VALUES ('EING2283', 'Marketing engineering', 4.0, 1);
INSERT INTO course VALUES ('ECGE2183', 'Financial Management', 4.0, 3);
INSERT INTO course VALUES ('EING2383', 'Supply chain management et e-business', 2.5, 5);

-- GRADE (check corrigé déjà OK ici)
INSERT INTO grade VALUES ('NA', 0, 7); -- corrigé ('N/A' -> 'NA' car CHAR(2))
INSERT INTO grade VALUES ('I', 8, 9);
INSERT INTO grade VALUES ('F', 10, 11);
INSERT INTO grade VALUES ('S', 12, 13);
INSERT INTO grade VALUES ('B', 14, 15);
INSERT INTO grade VALUES ('TB', 16, 17);
INSERT INTO grade VALUES ('E', 18, 20);

-- STUDENT (corriger course_id + section_id inexistants)
INSERT INTO student VALUES (1, 'Georges', 'Lucas', '1944-05-17', 'glucas', 1320, 10, 'EING2234');
INSERT INTO student VALUES (2, 'Clint', 'Eastwood', '1930-05-31', 'ceastwoo', 1010, 4, 'EING2234');
INSERT INTO student VALUES (3, 'Sean', 'Connery', '1930-08-25', 'sconnery', 1020, 12, 'ECGE2184');
INSERT INTO student VALUES (4, 'Robert', 'De Niro', '1943-08-17', 'rdeniro', 1110, 3, 'EING2234');
INSERT INTO student VALUES (5, 'Kevin', 'Bacon', '1958-07-08', 'kbacon', 1120, 16, 'ECGE2183');
INSERT INTO student VALUES (6, 'Kim', 'Basinger', '1953-12-08', 'kbasinge', 1310, 19, 'EING2383');
INSERT INTO student VALUES (7, 'Johnny', 'Depp', '1963-06-09', 'jdepp', 1110, 11, 'EING2234');
INSERT INTO student VALUES (8, 'Julia', 'Roberts', '1967-10-28', 'jroberts', 1120, 17, 'ECGE2183');
INSERT INTO student VALUES (9, 'Natalie', 'Portman', '1981-06-09', 'nportman', 1010, 4, 'EING2234');
INSERT INTO student VALUES (10, 'Georges', 'Clooney', '1961-05-06', 'gclooney', 1020, 4, 'ECGE2184');
INSERT INTO student VALUES (11, 'Andy', 'Garcia', '1956-04-12', 'agarcia', 1110, 19, 'EING2383');
INSERT INTO student VALUES (12, 'Bruce', 'Willis', '1955-03-19', 'bwillis', 1010, 6, 'EING2234');
INSERT INTO student VALUES (13, 'Tom', 'Cruise', '1962-07-03', 'tcruise', 1020, 4, 'ECGE2184');
INSERT INTO student VALUES (14, 'Reese', 'Witherspoon', '1976-03-22', 'rwithers', 1020, 7, 'EING2283');
INSERT INTO student VALUES (15, 'Sophie', 'Marceau', '1966-11-17', 'smarceau', 1110, 6, 'EING2383');
INSERT INTO student VALUES (16, 'Sarah', 'Michelle Gellar', '1977-04-14', 'smichell', 1020, 7, 'ECGE2184');
INSERT INTO student VALUES (17, 'Alyssa', 'Milano', '1972-12-19', 'amilano', 1110, 7, 'EING2383');
INSERT INTO student VALUES (18, 'Jennifer', 'Garner', '1972-04-17', 'jgarner', 1120, 18, 'ECGE2183');
INSERT INTO student VALUES (19, 'Michael J.', 'Fox', '1969-06-20', 'mfox', 1310, 3, 'EING2383');
INSERT INTO student VALUES (20, 'Tom', 'Hanks', '1956-07-09', 'thanks', 1020, 8, 'ECGE2184');
INSERT INTO student VALUES (21, 'David', 'Morse', '1953-10-11', 'dmorse', 1110, 2, 'EING2383');
INSERT INTO student VALUES (22, 'Sandra', 'Bullock', '1964-07-26', 'sbullock', 1010, 2, 'EING2283');
INSERT INTO student VALUES (23, 'Keanu', 'Reeves', '1964-09-02', 'kreeves', 1020, 10, 'EING2234');
INSERT INTO student VALUES (24, 'Shannen', 'Doherty', '1971-04-12', 'sdoherty', 1320, 2, 'EING2283');
INSERT INTO student VALUES (25, 'Halle', 'Berry', '1966-08-14', 'hberry', 1320, 18, 'EING2234');