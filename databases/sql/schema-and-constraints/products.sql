-- Création de la table T_PRODUIT_PDT
CREATE TABLE T_PRODUIT_PDT (
    PDT_ID          INT             NOT NULL IDENTITY(1,1),
    PDT_REF_MAGASIN VARCHAR(50)     NOT NULL,
    PDT_REF_FABRICANT VARCHAR(50)   NOT NULL,
    PDT_EAN13       CHAR(13)        NOT NULL,
    PDT_PRIX_VENTE  DECIMAL(10,2)   NOT NULL,

    -- clés étrangères
    FBQ_ID          INT             NOT NULL,
    TVA_ID          INT             NOT NULL,
    RYN_ID          INT             NOT NULL,

    -- clé primaire
    CONSTRAINT PK_PRODUIT PRIMARY KEY (PDT_ID),

    -- unicité sur le code EAN13
    CONSTRAINT UK_PRODUIT_EAN13 UNIQUE (PDT_EAN13),

    -- vérification du prix (pas négatif)
    CONSTRAINT CK_PRODUIT_PRIX CHECK (PDT_PRIX_VENTE >= 0),

    -- vérification EAN13 = toujours 13 caractères
    CONSTRAINT CK_PRODUIT_EAN13 CHECK (LEN(PDT_EAN13) = 13),

    -- lien vers la table fabricant
    CONSTRAINT FK_PRODUIT_FABRICANT FOREIGN KEY (FBQ_ID)
        REFERENCES T_FABRIQUANT_FBQ (FBQ_ID),

    -- lien vers la table taux TVA
    CONSTRAINT FK_PRODUIT_TVA FOREIGN KEY (TVA_ID)
        REFERENCES T_TAUX_TVA (TVA_ID),

    -- lien vers la table rayon
    CONSTRAINT FK_PRODUIT_RAYON FOREIGN KEY (RYN_ID)
        REFERENCES T_RAYON_RYN (RYN_ID)
);