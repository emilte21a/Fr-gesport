string[] acceptableAnswers = { "a", "b", "c", "d" };

string[] aksept = { "ja", "nej"};



Console.WriteLine("Hej och välkommen till Emils frågesport!");
Console.WriteLine("");
Console.WriteLine("Skriv ditt namn.");
string namn = Console.ReadLine();

if (namn.Length == 1)
    System.Console.WriteLine(char.ToUpper(namn[0]));

int totalpoäng = 0;


Console.WriteLine();
Console.WriteLine("Vill du börja spela? ");




string spela = ("");
    while (aksept.Contains(spela) == false)
    {
        Console.WriteLine("Skriv Ja eller Nej: ");
        spela = Console.ReadLine().ToLower();
    }


while (spela == "ja")
{

    Console.Clear();



    Console.WriteLine($"Hej {namn} du kommer att få svara på 3 frågor. Ett rätt svar ger ett poäng, ett fel svar ger inga poäng. Du kommer att få välja vilket ämne som frågorna ska handla om.");
    Console.WriteLine("");


    Console.WriteLine("Vill du att frågesporten ska handla om musik eller spel?");
    string val = Console.ReadLine();

    while (val != "musik" && val != "spel")
    {
        Console.WriteLine("Men seriöst, vad vill du att den ska handla om?");
        val = Console.ReadLine();
    }

    if (val == "musik")
    {
        Console.Clear();
        Console.WriteLine("Du har valt musikfrågor.");
        Console.WriteLine("");


        Console.WriteLine("Fråga 1.");
        Console.WriteLine("");
        Console.WriteLine("När skapades det första pianot?");
        Console.WriteLine("");
        Console.WriteLine("A) 1504");
        Console.WriteLine("B) 1709");
        Console.WriteLine("C) 1830");
        Console.WriteLine("D) 1832");

        Console.WriteLine("");

        string fragaett = "";
        while (acceptableAnswers.Contains(fragaett) == false)
        {
            Console.WriteLine("Skriv in ditt svar a, b ,c eller d: ");
            fragaett = Console.ReadLine().ToLower();
        }

        Console.WriteLine("");

        if (fragaett == "b")
        {

            totalpoäng = totalpoäng + 1;

            Console.WriteLine("Du fick ett poäng!");
            Console.WriteLine($"Antal poäng: {totalpoäng}");

        }

        else if (fragaett != "b")
        {
            Console.WriteLine("Du fick inga poäng!");
            Console.WriteLine($"antal poäng: {totalpoäng}");

        }
        Console.WriteLine("Tryck ENTER för att komma till fråga 2.");
        Console.ReadLine();
        Console.Clear();


        Console.WriteLine("Fråga 2.");
        Console.WriteLine("");
        Console.WriteLine("När släpptes låten 'Last Christmas' av bandet Wham!");
        Console.WriteLine("");
        Console.WriteLine("A) 1972");
        Console.WriteLine("B) 1990");
        Console.WriteLine("C) 1984");
        Console.WriteLine("D) 2001");

        Console.WriteLine("");

        string fragatva = "";
        while (acceptableAnswers.Contains(fragatva) == false)
        {
            Console.WriteLine("Skriv in ditt svar a, b ,c eller d: ");
            fragatva = Console.ReadLine().ToLower();
        }

        Console.WriteLine("");

        if (fragatva == "c")
        {

            totalpoäng = totalpoäng + 1;

            Console.WriteLine("Du fick ett poäng!");
            Console.WriteLine($"Antal poäng: {totalpoäng}");

        }

        else if (fragatva != "c")
        {
            Console.WriteLine("Du fick inga poäng!");
            Console.WriteLine($"antal poäng: {totalpoäng}");

        }

        Console.WriteLine("Tryck ENTER för att komma till fråga 3.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Fråga 3.");
        Console.WriteLine("");
        Console.WriteLine("Vart kommer artisten 'Yung Lean' ifrån?");
        Console.WriteLine("");
        Console.WriteLine("A) Sverige");
        Console.WriteLine("B) Norge");
        Console.WriteLine("C) USA");
        Console.WriteLine("D) Storbritannien");

        Console.WriteLine("");

        string fragatre = "";
        while (acceptableAnswers.Contains(fragatre) == false)
        {
            Console.WriteLine("Skriv in ditt svar a, b ,c eller d: ");
            fragatre = Console.ReadLine().ToLower();
        }


        Console.WriteLine("");

        if (fragatre == "a")
        {

            totalpoäng = totalpoäng + 1;

            Console.WriteLine("Du fick ett poäng!");
            Console.WriteLine($"Antal poäng: {totalpoäng}");

        }

        else if (fragatre != "a")
        {
            Console.WriteLine("Du fick inga poäng!");
            Console.WriteLine($"antal poäng: {totalpoäng}");

        }

        Console.WriteLine("Tryck ENTER för att komma vidare.");
        Console.ReadLine();
        Console.Clear();

        if (totalpoäng == 3)
        {
            Console.WriteLine($"Du fick {totalpoäng} poäng! Bra jobbat");

        }
        else if (totalpoäng == 2)
        {
            Console.WriteLine($"Du fick {totalpoäng} poäng! Nästan perfekt");

        }

        else if (totalpoäng == 1)
        {
            Console.WriteLine($"Du fick {totalpoäng} poäng! Äh bättre kan du..");

        }

        if (totalpoäng == 0)
        {
            Console.WriteLine($"Du fick {totalpoäng} poäng! Hur lyckas du vara så kass??");

        }

        Console.ReadLine();
        
    }

    if (val == "spel")
    {
        Console.Clear();
        Console.WriteLine("Du har valt spelfrågor.");
        Console.WriteLine("");


        Console.WriteLine("Fråga 1.");
        Console.WriteLine("");
        Console.WriteLine("När skapades det första spelet?");
        Console.WriteLine("");
        Console.WriteLine("A) 1941");
        Console.WriteLine("B) 1962");
        Console.WriteLine("C) 1966");
        Console.WriteLine("D) 1990");

        Console.WriteLine("");
        string fragaett = "";
        while (acceptableAnswers.Contains(fragaett) == false)
        {
            Console.WriteLine("Skriv in ditt svar a, b ,c eller d: ");
            fragaett = Console.ReadLine().ToLower();
        }

        Console.WriteLine("");

        if (fragaett == "b")
        {

            totalpoäng = totalpoäng + 1;

            Console.WriteLine("Du fick ett poäng!");
            Console.WriteLine($"Antal poäng: {totalpoäng}");

        }

        else if (fragaett != "b")
        {
            Console.WriteLine("Du fick inga poäng!");
            Console.WriteLine($"antal poäng: {totalpoäng}");

        }
        Console.WriteLine("Tryck ENTER för att komma till fråga 2.");
        Console.ReadLine();
        Console.Clear();


        Console.WriteLine("Fråga 2.");
        Console.WriteLine("");
        Console.WriteLine("När släpptes spelet 'Minecraft' av utvecklarföretaget Mojang?");
        Console.WriteLine("");
        Console.WriteLine("A) 2006");
        Console.WriteLine("B) 2008");
        Console.WriteLine("C) 2009");
        Console.WriteLine("D) 2013");

        Console.WriteLine("");
        string fragatva = "";
        while (acceptableAnswers.Contains(fragatva) == false)
        {
            Console.WriteLine("Skriv in ditt svar a, b ,c eller d: ");
            fragatva = Console.ReadLine().ToLower();
        }

        Console.WriteLine("");

        if (fragatva == "c")
        {

            totalpoäng = totalpoäng + 1;

            Console.WriteLine("Du fick ett poäng!");
            Console.WriteLine($"Antal poäng: {totalpoäng}");

        }

        else if (fragatva != "c")
        {
            Console.WriteLine("Du fick inga poäng!");
            Console.WriteLine($"antal poäng: {totalpoäng}");

        }

        Console.WriteLine("Tryck ENTER för att komma till fråga 3.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Fråga 3.");
        Console.WriteLine("");
        Console.WriteLine("Vart kommer spelet 'Terraria' ifrån?");
        Console.WriteLine("");
        Console.WriteLine("A) USA");
        Console.WriteLine("B) Ryssland");
        Console.WriteLine("C) Tyskland");
        Console.WriteLine("D) Storbritannien");

        Console.WriteLine("");
        string fragatre = "";
        while (acceptableAnswers.Contains(fragatre) == false)
        {
            Console.WriteLine("Skriv in ditt svar a, b ,c eller d: ");
            fragatre = Console.ReadLine().ToLower();
        }

        Console.WriteLine("");

        if (fragatre == "a")
        {

            totalpoäng = totalpoäng + 1;

            Console.WriteLine("Du fick ett poäng!");
            Console.WriteLine($"Antal poäng: {totalpoäng}");

        }

        else if (fragatre != "a")
        {
            Console.WriteLine("Du fick inga poäng!");
            Console.WriteLine($"antal poäng: {totalpoäng}");

        }

        Console.WriteLine("Tryck ENTER för att komma vidare.");
        Console.ReadLine();
        Console.Clear();

        if (totalpoäng == 3)
        {
            Console.WriteLine($"Du fick {totalpoäng} poäng! Bra jobbat");

        }
        else if (totalpoäng == 2)
        {
            Console.WriteLine($"Du fick {totalpoäng} poäng! Nästan perfekt");

        }

        else if (totalpoäng == 1)
        {
            Console.WriteLine($"Du fick {totalpoäng} poäng! Äh bättre kan du..");

        }

        if (totalpoäng == 0)
        {
            Console.WriteLine($"Du fick {totalpoäng} poäng! Hur lyckas du vara så kass??");

        }

        Console.ReadLine();
    
    }
    

    else if (spela == "nej")
    {
        Console.WriteLine("Tryck på ENTER för att avsluta");
    }
        
    
    

    Console.WriteLine ("Vill du spela igen?");

    spela = ("");
    while (aksept.Contains(spela) == false)
    {
        Console.WriteLine("Skriv Ja eller Nej: ");
        spela = Console.ReadLine().ToLower();
    }

    if (spela == "ja")
    {
        continue;
    }


    else if (spela == "nej")
    {
        Console.WriteLine("Tryck på ENTER för att avsluta");
    }


    
}



Console.ReadLine();