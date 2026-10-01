#region exo 1 salutations
string prenom, nom;
Console.WriteLine("Entrez votre prénom :");
prenom = Console.ReadLine()!;
Console.WriteLine("Entrez votre nom :");
nom = Console.ReadLine()!;
Console.WriteLine("Bonjour " + prenom + " " + nom + " !");
#endregion

#region exo 2 calculatrice simple
int a, b;
Console.WriteLine("Entrez le premier nombre :");
a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Entrez le deuxième nombre :");
b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Addition : " + (a + b));
Console.WriteLine("Soustraction : " + (a - b));
Console.WriteLine("Multiplication : " + (a * b));
#endregion

#region exo 3 aire du rectangle
int longueur, largeur, aire;
Console.WriteLine("Entrez la longueur :");
longueur = int.Parse(Console.ReadLine()!);
Console.WriteLine("Entrez la largeur :");
largeur = int.Parse(Console.ReadLine()!);
aire = longueur * largeur;
Console.WriteLine("L'aire du rectangle est : " + aire);
#endregion

#region le swap
int a = 5, b = 10, temp;

// Avec variable temporaire
temp = a;
a = b;
b = temp;
Console.WriteLine("Avec temp -> A = " + a + " B = " + b);

// Remettre les valeurs initiales
a = 5;
b = 10;

// Sans variable temporaire
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine("Sans temp -> A = " + a + " B = " + b);
#endregion

#region exo 5 positif, négatif ou zéro
int nombre;
Console.WriteLine("Entrez un nombre :");
nombre = int.Parse(Console.ReadLine()!);
if (nombre > 0)
{
    Console.WriteLine("Positif");
}
else if (nombre < 0)
{
    Console.WriteLine("Négatif");
}
else
{
    Console.WriteLine("Zéro");
}
#endregion

#region exo 6 pair ou impair
int nombre;
Console.WriteLine("Entrez un nombre :");
nombre = int.Parse(Console.ReadLine()!);
if (nombre % 2 == 0)
{
    Console.WriteLine("Pair");
}
else
{
    Console.WriteLine("Impair");
}
#endregion

#region exo7 
int a, b;
Console.WriteLine("Entrer le premier nombre :");
a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Entrer le deuxième nombre :");
b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine("Le plus grand est : " + a);
}
else if (b > a)
{
    Console.WriteLine("Le plus grand est : " + b);
}
else
{
    Console.WriteLine("Les deux nombre sont égaux");
}
#endregion

#region exo 8 
int age;
Console.WriteLine("Entrez votre âge :");
age = int.Parse(Console.ReadLine()!);
if (age >= 18)
{
    Console.WriteLine("Accès autorisé");
}
else
{
    Console.WriteLine("Accès refusé");
}
#endregion 

#region exo 9 compter jusque dix
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
#endregion

#region exo 10 table de cinq
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("5 x " + i + " = " + (5 * i));
}
#endregion

#region exo 11 compte a rebours
int compteur = 10;
while (compteur > 0)
{
    Console.WriteLine(compteur);
    compteur = compteur - 1;
}
Console.WriteLine("Décollage !");
#endregion

#region exo 12 les jours de semaine
string[] jours = new string[7];
jours[0] = "Lundi";
jours[1] = "Mardi";
jours[2] = "Mercredi";
jours[3] = "Jeudi";
jours[4] = "Vendredi";
jours[5] = "Samedi";
jours[6] = "Dimanche";

for (int i = 0; i < jours.Length; i++)
{
    Console.WriteLine(jours[i]);
}
#endregion

#region exo 13 accès vip
int age;
string carteIdentite;
Console.WriteLine("Entrez votre âge :");
age = int.Parse(Console.ReadLine()!);
Console.WriteLine("Avez-vous votre carte d'identité ? (oui/non) :");
carteIdentite = Console.ReadLine()!;
if (age >= 18 && carteIdentite == "oui")
{
    Console.WriteLine("Accès VIP autorisé");
}
else
{
    Console.WriteLine("Accès refusé");
}
#endregion

#region exo 14 le bulletin
int note;
Console.WriteLine("Entrer votre note :");
note = int.Parse(Console.ReadLine()!);
if (note < 10)
{
    Console.WriteLine("recalé");
}
else if (note >= 10 && note < 16)
{
    Console.WriteLine("validé");
}
else
{
    Console.WriteLine("mention");
}

#endregion

#region exo 15 la caisse
int montant, prixFinal;
Console.WriteLine("Entrer le montant de la facture :");
montant = int.Parse(Console.ReadLine()!);
if (montant > 100)
{
    prixFinal = montant - (montant * 20 / 100);
    Console.WriteLine("réduction de 20% : " + prixFinal);
}
else if (montant >= 50)
{
    prixFinal = montant - (montant * 10 / 100);
    Console.WriteLine("réductin de 10% : " + prixFinal);
}
else
{
    Console.WriteLine("aucune réduction : " + montant);
}
#endregion

#region exo 16 controle du temps
int heures, minutes;
Console.WriteLine("Entrez l'heure :");
heures = int.Parse(Console.ReadLine()!);
Console.WriteLine("Entrez les minutes :");
minutes = int.Parse(Console.ReadLine()!);
if (heures >= 0 && heures <= 23 && minutes >= 0 && minutes <= 59)
{
    Console.WriteLine("Heure valide");
}
else
{
    Console.WriteLine("Heure invalide");
}
#endregion

#region exo 17 saisie sans fin
int nombre, somme;
somme = 0;
Console.WriteLine("Entrez un nombre (0 pour arrêter) :");
nombre = int.Parse(Console.ReadLine()!);
while (nombre != 0)
{
    somme = somme + nombre;
    Console.WriteLine("Entrez un nombre (0 pour arrêter) :");
    nombre = int.Parse(Console.ReadLine()!);
}
Console.WriteLine("Somme totale : " + somme);
#endregion

#region exo 18 moyenne de la classe
int[] cotes = new int[5];
int somme, moyenne;
somme = 0;
for (int i = 0; i < cotes.Length; i++)
{
    Console.WriteLine("Entrez la cote " + (i + 1) + " :");
    cotes[i] = int.Parse(Console.ReadLine()!);
}
for (int i = 0; i < cotes.Length; i++)
{
    somme = somme + cotes[i];
}
moyenne = somme / cotes.Length;
Console.WriteLine("La moyenne est : " + moyenne);
#endregion

#region exo 19 la recherche des prénom
string[] prenoms = new string[5];
prenoms[0] = "Benjamin";
prenoms[1] = "Younes";
prenoms[2] = "Ismail";
prenoms[3] = "Tristan";
prenoms[4] = "Jordan";
string recherche;
bool trouve;
trouve = false;
Console.WriteLine("Entrez un prénom à rechercher :");
recherche = Console.ReadLine()!;
for (int i = 0; i < prenoms.Length; i++)
{
    if (prenoms[i] == recherche)
    {
        trouve = true;
    }
}
if (trouve)
{
    Console.WriteLine("Prénom trouvé !");
}
else
{
    Console.WriteLine("Ce prénom n'est pas dans la liste.");
}
#endregion

#region exo 20 procédure void
static void AfficherMenu()
{
    Console.WriteLine("1. Jouer | 2. Options | 3. Quitter");
}

AfficherMenu();
#endregion

#region exo 21 celcius en farenheit
static double ConvertirCelsiusEnFahrenheit(double celsius)
{
    return (celsius * 1.8) + 32;
}

double celsius;
Console.WriteLine("Entrez une température en Celsius :");
celsius = double.Parse(Console.ReadLine()!);
Console.WriteLine("En Fahrenheit : " + ConvertirCelsiusEnFahrenheit(celsius));
#endregion

#region exo 22 le juste prix
Random rnd = new Random();
int nb = rnd.Next(1, 101);
int essai, tentatives;
tentatives = 0;
do
{
    Console.WriteLine("Devinez le nombre (entre 1 et 100) :");
    essai = int.Parse(Console.ReadLine()!);
    tentatives = tentatives + 1;
    if (essai < nb)
    {
        Console.WriteLine("C'est plus !");
    }
    else if (essai > nb)
    {
        Console.WriteLine("C'est moins !");
    }
} while (essai != nb);
Console.WriteLine("Gagné ! Vous avez trouvé en " + tentatives + " tentatives.");
#endregion

#region exo 23 distributeur boisson
int choix;
double prix, montant, monnaie;
Console.WriteLine("1: Eau 1€ | 2: Soda 2€ | 3: Café 1.5€");
choix = int.Parse(Console.ReadLine()!);
switch (choix)
{
    case 1:
        prix = 1;
        Console.WriteLine("Vous avez choisi : Eau");
        break;
    case 2:
        prix = 2;
        Console.WriteLine("Vous avez choisi : Soda");
        break;
    case 3:
        prix = 1.5;
        Console.WriteLine("Vous avez choisi : Café");
        break;
    default:
        prix = 0;
        Console.WriteLine("Choix invalide");
        break;
}
if (prix > 0)
{
    montant = 0;
    while (montant < prix)
    {
        Console.WriteLine("Insérez de l'argent (il manque " + (prix - montant) + "€) :");
        montant = montant + double.Parse(Console.ReadLine()!);
    }
    monnaie = montant - prix;
    Console.WriteLine("Voici votre boisson !");
    if (monnaie > 0)
    {
        Console.WriteLine("Voici votre monnaie : " + monnaie + "€");
    }
}
#endregion

#region exo 24 Tri à bulle
int[] tab = new int[5];
tab[0] = 5;
tab[1] = 2;
tab[2] = 8;
tab[3] = 1;
tab[4] = 9;
int temp;
for (int i = 0; i < tab.Length - 1; i++)
{
    for (int j = 0; j < tab.Length - 1 - i; j++)
    {
        if (tab[j] > tab[j + 1])
        {
            temp = tab[j];
            tab[j] = tab[j + 1];
            tab[j + 1] = temp;
        }
    }
}
for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine(tab[i]);
}
#endregion

#region exo 25 recherche de doublnos
int[] tab = new int[10];
for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine("Entrez le nombre " + (i + 1) + " :");
    tab[i] = int.Parse(Console.ReadLine()!);
}
for (int i = 0; i < tab.Length; i++)
{
    int compteur = 0;
    for (int j = 0; j < tab.Length; j++)
    {
        if (tab[i] == tab[j])
        {
            compteur = compteur + 1;
        }
    }
    if (compteur > 1)
    {
        Console.WriteLine("Le nombre " + tab[i] + " apparaît " + compteur + " fois.");
    }
}
#endregion

#region exo 26 inversion de tableau
int[] tab = new int[5];
int temp;
for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine("Entrez le nombre " + (i + 1) + " :");
    tab[i] = int.Parse(Console.ReadLine()!);
}
for (int i = 0; i < tab.Length / 2; i++)
{
    temp = tab[i];
    tab[i] = tab[tab.Length - 1 - i];
    tab[tab.Length - 1 - i] = temp;
}
for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine(tab[i]);
}
#endregion

#region exo 27 matrice
int[,] matrice = new int[3, 3];
int valeur = 1;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrice[i, j] = valeur;
        valeur = valeur + 1;
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrice[i, j] + " ");
    }
    Console.WriteLine();
}
#endregion

#region exo 28 somme diagonales
int[,] matrice = new int[3, 3];
int valeur = 1;
int sommeDiagonale = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrice[i, j] = valeur;
        valeur = valeur + 1;
    }
}
for (int i = 0; i < 3; i++)
{
    sommeDiagonale = sommeDiagonale + matrice[i, i];
}
Console.WriteLine("Somme de la diagonale : " + sommeDiagonale);
#endregion

#region exo 29 analyse texte
string phrase;
int nbCaracteres, nbVoyelles, nbMots;
nbCaracteres = 0;
nbVoyelles = 0;
nbMots = 0;
Console.WriteLine("Entrez une phrase :");
phrase = Console.ReadLine()!;
nbCaracteres = phrase.Length;
for (int i = 0; i < phrase.Length; i++)
{
    char c = phrase[i];
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
        c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
    {
        nbVoyelles = nbVoyelles + 1;
    }
    if (c == ' ')
    {
        nbMots = nbMots + 1;
    }
}
nbMots = nbMots + 1;
Console.WriteLine("Nombre de caractères : " + nbCaracteres);
Console.WriteLine("Nombre de voyelles : " + nbVoyelles);
Console.WriteLine("Nombre de mots : " + nbMots);
#endregion

#region exo 30 le pendu
char[] mot = new char[] { 'Y', 'O', 'U', 'N', 'E', 'S' };
char[] affichage = new char[] { '_', '_', '_', '_', '_', '_' };
int erreurs = 0;
bool gagne = false;
while (erreurs < 7 && !gagne)
{
    for (int i = 0; i < affichage.Length; i++)
    {
        Console.Write(affichage[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Erreurs : " + erreurs + "/7");
    Console.WriteLine("Proposez une lettre :");
    char lettre = Console.ReadLine()![0];
    bool bonne = false;
    for (int i = 0; i < mot.Length; i++)
    {
        if (mot[i] == lettre)
        {
            affichage[i] = lettre;
            bonne = true;
        }
    }
    if (!bonne)
    {
        erreurs = erreurs + 1;
    }
    gagne = true;
    for (int i = 0; i < affichage.Length; i++)
    {
        if (affichage[i] == '_')
        {
            gagne = false;
        }
    }
}
if (gagne)
{
    Console.WriteLine("Bravo vous avez trouvé le mot !");
}
else
{
    Console.WriteLine("Perdu ! Le mot était : YOUNES");
}
#endregion

