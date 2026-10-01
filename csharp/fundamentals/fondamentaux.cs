
//////////#region
//////////string prenom = "YUNS";
//////////string lechoixdeYuns = "café";

//////////Console.WriteLine("ce message va s'autodétruire");
//////////Thread.Sleep(5000);
//////////Console.Clear();
//////////Console.WriteLine($"Bonjour {prenom} un {lechoixdeYuns}");
//////////#endregion

//////////const string nom = "Berebia"
//////////#endregion

//////////#region
//////////Console.WriteLine("Bonjour c'est moi");
//////////\end
//////////#endregion

//////////#region
//////////var v1 = 5;
//////////var v2 = 7;
//////////var v3 = 3.14;
//////////var v4 = "Test";

//////////Console.WriteLine(v1);
//////////v1.GetType();
//////////    Console.ReadLine();
//////////#endregion

////////using System.Runtime.CompilerServices;
////////using System.Text;

//////////Console.WriteLine("\\\\c:\\\\user");
//////////Console.WriteLine(@"\\c:\\user");
//////////Console.WriteLine("\\c:\\user");
//////////Console.WriteLine(@"\c:\user");

//////////Console.WriteLine("Bonjour il fait \"beau\"");

//////////Console.WriteLine("Bonjour Yuns");
//////////Console.WriteLine("Bientot la pause");
//////////Console.WriteLine("café fort \n");


//////////using System.Text
//////////string prenom = "YUNS"
//////////StringBuilder sb = new StringBuilder();
//////////sb.AppendLine($"Bonjour Yuns {prenom}");
//////////string pause = Console.ReadLine();
//////////sb.AppendLine(pause);
//////////sb.AppendLine("on y go");
//////////Console.WriteLine(sb);

//////////int i = 5;
//////////int i = 42;
//////////double pi = 3.14;
//////////bool b = false;

//////////string s_i = i.ToString();
//////////string s_pi = pi.ToString();
//////////string s_b = b.ToString();

//////////Console.WriteLine (s_i.GetType());
//////////Console.WriteLine (s_pi.GetType());
//////////Console.WriteLine (s_b.GetType());

//////////Console.ReadLine();

//////////string s1 = "5";
//////////string s2 = "42";
//////////string s3 = "3.14";
//////////float f;

//////////bool b = float.TryParse (s1, out f);
//////////Console.WriteLine(f.GetType());
//////////Console.WriteLine(s1.GetType());
//////////Console.ReadLine ();

//////////int total = 208;
//////////int unités = 104;

//////////int Pourcent = (int)(100F / total * unités);

//////////Console.WriteLine("les unités : {0}U ou {1}% du total", unités, Pourcent);
//////////Console.ReadLine();

//////////int i = 10;
//////////object o = i;
//////////int j = (int)o;

//////////Console.WriteLine(j);
//////////Console.ReadLine();


//////////Console.WriteLine("entrez votre age");
//////////bool condtion = int.TryParse(Console.ReadLine(), out int age);

//////////if (!condtion)
//////////{Console.WriteLine("veuillez entrer un nombre valide");}

//////////else if (age == 42)
//////////{Console.WriteLine("entrèe gratuite");}

//////////else if (age < 26)
//////////{Console.WriteLine("entrée refusée");}

//////////else
//////////{Console.WriteLine("entrée mais payante");}

//////////Console.WriteLine("Choisis une boisson :");
//////////Console.WriteLine("1. Coca");
//////////Console.WriteLine("2. Ice Tea");
//////////Console.WriteLine("3. Fanta");
//////////Console.WriteLine("4. Chaudfontaine");
//////////Console.WriteLine("5. Spa");
//////////Console.WriteLine("6. Perrier");

//////////bool succes = int.TryParse(Console.ReadLine(), out int choix);

//////////if (!succes)
//////////{
//////////    Console.WriteLine("Veuillez entrer un nombre valide.");
//////////}
//////////else
//////////{
//////////    switch (choix)
//////////    {
//////////        case 1:
//////////            Console.WriteLine("Vous avez choisi le Coca.");
//////////            break;
//////////        case 2:
//////////            Console.WriteLine("Vous avez choisi l'Ice Tea.");
//////////            break;
//////////        case 3:
//////////            Console.WriteLine("Vous avez choisi le Fanta.");
//////////            break;
//////////        case 4:
//////////        case 5:
//////////        case 6:
//////////            Console.WriteLine("Vous avez choisi de l'eau.");
//////////            break;
//////////        default:
//////////            Console.WriteLine("Choix invalide.");
//////////            break;
//////////    }
//////////}


//////////Console.WriteLine("Entrez votre prenom");
//////////string? prenom = Console.ReadLine();
//////////string? prenomNullable = prenom == "" ? null : prenom;
//////////Console.WriteLine("Entrez votre pseudo");
//////////string? pseudo = Console.ReadLine();
//////////string? pseudoNullable = pseudo == "" ? null : pseudo;

//////////string result = prenomNullable ?? pseudoNullable ?? "Anonyme";

//////////Console.WriteLine(result); 

//////////object o = 5;

//////////if (o is float)
//////////{ 
//////////    Console.WriteLine("oui c un long");
//////////}


//////////else
//////////{
//////////    Console.WriteLine("non");
//////////}

//////////int x = int.MaxValue;
//////////Console.WriteLine(x);

//////////string tst = "C'est bientôt l'heure de la pause et Younès a faim";
//////////int index = tst.IndexOf("pause");
//////////Console.WriteLine(tst.Substring(index, 6));



//////////long BBAN = 7336120800;

//////////long end = BBAN % 97;
//////////string BBANComplet = (BBAN.ToString() + end.ToString()); // ToString pour tout convertir en string
//////////Console.WriteLine("Compte bancaire BBAN : " + BBANComplet.Substring(0, 3) + "-" + BBANComplet.Substring(3, 7) + "-" + BBANComplet.Substring(10, 2));

//////////int check = (int)(98 - (BBAN % 97));
//////////string IBAN = $"BE{check}{BBANComplet}";
//////////Console.WriteLine("Compte IBAN : " + IBAN.Substring(0, 3) + "" + IBAN.Substring(3, 7) + "" + IBAN.Substring(8, 4) + "" + IBAN.Substring(12, 4));

//////////string BBAN = Console.ReadLine();
//////////long dixPremierBban = long.Parse(BBAN.Substring(0, 10));
//////////int checkBban = int.Parse(BBAN.Substring(10, 2));

//////////if (dixPremierBban % 97 == checkBban)
//////////{ Console.WriteLine{"ok"};
//////////}
//////////else
//////////{
//////////    Console.WriteLine {"non"};
//////////}


//////////for (int i = 1; i <= 10; i++)
//////////{
//////////    Console.WriteLine($"10 x {i} = {10 * i}");
//////////}


//////////long BBAN = 7336120800;

//////////long end = BBAN % 97;
//////////string BBANComplet = (BBAN.ToString() + end.ToString()); // ToString pour tout convertir en string
//////////Console.WriteLine("Compte bancaire BBAN : " + BBANComplet.Substring(0, 3) + "-" + BBANComplet.Substring(3, 7) + "-" + BBANComplet.Substring(10, 2));

//////////int check = (int)(98 - (BBAN % 97));
//////////string IBAN = $"BE{check}{BBANComplet}";
//////////Console.WriteLine("Compte IBAN : " + IBAN.Substring(0, 3) + "" + IBAN.Substring(3, 7) + "" + IBAN.Substring(8, 4) + "" + IBAN.Substring(12, 4));

//////////string BBAN = Console.ReadLine();
//////////long dixPremierBban = long.Parse(BBAN.Substring(0, 10));
//////////int checkBban = int.Parse(BBAN.Substring(10, 2));


//////////while (long BBAN != BBAN
//////////{
//////////    Console.WriteLine(BBAN); BBAN++;
//////////}

//////////

//////////int n = 25;
//////////int[] fibonaci = new int[n];

//////////fibonaci[0] = 0;
//////////fibonaci[1] = 1;

//////////for (int i = 2; i < n; i++)
//////////{
//////////    fibonaci[i] = fibonaci[i - 1] + fibonaci[i - 2];
//////////}

//////////for (int i = 0; i < n; i++)
//////////{
//////////    Console.WriteLine($"fibonaci[{i}] = {fibonaci[i]}");
//////////}

//////////Console.Write("entrez un nombre : ");
//////////int n = int.Parse(Console.ReadLine());

//////////int resultat = 1;

//////////for (int i = 1; i <= n; i++)
//////////{
//////////    resultat = resultat * i;
//////////}

//////////Console.WriteLine($"Le factorielle de {n} est {resultat}");


//////////


//////////Console.Write("Combien de nombres premiers ? ");
//////////int x = int.Parse(Console.ReadLine());

//////////int compte = 0;
//////////int nombre = 2;

//////////while (compte < x)
//////////{
//////////    bool estPremier = true;

//////////    for (int i = 2; i < nombre; i++)
//////////    {
//////////        if (nombre % i == 0)
//////////        {
//////////            estPremier = false;
//////////            break;
//////////        }
//////////    }

//////////    if (estPremier)
//////////    {
//////////        Console.WriteLine(nombre);
//////////        compte++;
//////////    }
//////////    nombre++;
//////////}

//////////


//////////for (int table = 1; table <= 5; table++)
//////////{
//////////    for (int i = 1; i <= 20; i++)
//////////    {
//////////        Console.Write($"{table}x{i} = {table * i} ; ");
//////////    }
//////////    Console.WriteLine();
//////////}


//////////int n = 25;
//////////int[] fibonaci = new int[n];

//////////fibonaci[0] = 0;
//////////fibonaci[1] = 1;

//////////for (int i = 2; i < n; i++)
//////////{
//////////    fibonaci[i] = fibonaci[i - 1] + fibonaci[i - 2];
//////////}

//////////for (int i = 0; i < n; i++)
//////////{
//////////    Console.WriteLine($"fibonaci[{i}] = {fibonaci[i]}");
//////////}

//////////Console.Write("entrez un nombre : ");
//////////int n = int.Parse(Console.ReadLine());

//////////int resultat = 1;

//////////    for (int i= 1; i <= n; i++)
//////////{
//////////    resultat = resultat * i;
//////////}

//////////Console.WriteLine($"le factorielle de {n} est {resultat}")

//////////int a = 0;
//////////int b = 1;
//////////int nbSuivant;

//////////for (int i = 0; i < 25; i++)
//////////{
//////////    Console.WriteLine(a);
//////////   nbSuivant = a + b;
//////////    a = b;
//////////    b = nbSuivant;

//////////}
//////////

////int a = 0;
////int b = 1;
////int nbSuivant = 1;

////for (int i = 0; i < 25; i++)
////{
////    Console.WriteLine(a);
////    nbSuivant = a + b;
////    a = b;
////    b = nbSuivant;
////}




Console.Write("entrez un nombre : ");
int n = int.Parse(Console.ReadLine());

int resultat = 1;

for (int i = 1; i <= n; i++)
{
    resultat = resultat * i;
}

Console.WriteLine($"le factorielle de {n} est {resultat}");

Console.Write("Entrez un nombre : ");
int n = int.Parse(Console.ReadLine());

int resultat = 1;

for (int i = 1; i <= n; i++)
{
    resultat = resultat * i;
}

Console.WriteLine($"Le factorielle de {n} est {resultat}");

