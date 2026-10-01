CREATE DATABASE recap;
/*Permet de crée la db*/

/*Permet de ciblé la db sur laquel on travaille*/
USE recap;


/*Crée une table recapitulatif avec les colonnes écrite en dessous, avec leurs type*/

CREATE TABLE section(
 section_id INT PRIMARY KEY,
 section_name VARCHAR(50),
 delegate_id INT,
);

/*creation table + CHECK + FOREIGN KEY + CONSTRAINT UNIQUE + DEFAULT*/
CREATE TABLE recapitulatif(
 
 first_name VARCHAR(50),
 last_name VARCHAR(50) DEFAULT 'Smith',
 birth_date DATETIME
 CONSTRAINT CheckBirthDate CHECK (YEAR(birth_date)<1900),
 section_id INT
 CONSTRAINT FK_section REFERENCES section(section_id),
 year_result char(5),
 course_id VARCHAR(6),
 CONSTRAINT Prenom_Nom_Ddn UNIQUE (first_name,last_name, birth_date),
);

/*Permet de rajouter une FOREIGN KEY (ou une autre contrainte) a une table existante, on modifie cette table*/
ALTER TABLE section 
ADD CONSTRAINT FK_delegate FOREIGN KEY(delegate_id) REFERENCES recapitulatif(student_id)

/*Permet de modifier le type d'une colonne*/
ALTER TABLE recapitulatif
ALTER COLUMN year_result INT 

/*Ajout et désactivation d'un contrainte*/
ALTER TABLE recapitulatif
ADD year_result INT CHECK (year_result BETWEEN 0 AND 20)
ALTER TABLE recapitulatif
NOCHECK CONSTRAINT year_result

/*Permet d'effacer une colonne*/
ALTER TABLE recapitulatif
DROP COLUMN course_id

/*Suppression d'une contrainte*/
ALTER TABLE recapitulatif 
DROP CONSTRAINT year_result

/*Supprimer toute les infos et l'index d'une table*/
TRUNCATE TABLE section

/*Supprimer toute la table*/
DROP TABLE section
 