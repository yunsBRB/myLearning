-- Création de la table T_MAINTENANCE_MTN
CREATE TABLE T_MAINTENANCE_MTN (
    MTN_ID          INT             NOT NULL IDENTITY(1,1),
    MTN_JOUR        VARCHAR(3)      NOT NULL,
    MTN_MACHINE     VARCHAR(50)     NOT NULL,
    MTN_NUMERO      INT             NOT NULL,
    MTN_VITESSE     INT             NULL,
    MTN_TEMPERATURE INT             NULL,
    MTN_HEURE       TIME            NOT NULL,
    MTN_EVENEMENT   VARCHAR(100)    NOT NULL,

    -- Clé primaire
    CONSTRAINT PK_MAINTENANCE PRIMARY KEY (MTN_ID),

    -- Contrainte d'unicité (machine + numéro + heure)
    CONSTRAINT UK_MAINTENANCE UNIQUE (MTN_MACHINE, MTN_NUMERO, MTN_HEURE),

    -- Contrainte CHECK sur le jour
    CONSTRAINT CK_MAINTENANCE_JOUR CHECK (MTN_JOUR IN ('Lun', 'Mar', 'Mer', 'Jeu', 'Ven', 'Sam', 'Dim')),

    -- Contrainte NOT NULL déjà dans la colonne mais on peut aussi l'écrire ainsi
    CONSTRAINT CK_MAINTENANCE_EVENEMENT CHECK (MTN_EVENEMENT <> '')
);