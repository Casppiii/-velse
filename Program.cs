// See https://aka.ms/new-console-template for more information
void Main()
{
    string førsteSpørgsmål = "Er ballondor rigged?";
    
    while (true)
    {
    Console.WriteLine("Velkommen til quiz game");
    Console.WriteLine("Spørgsmål " + førsteSpørgsmål);
    string svar = Console.ReadLine();
    tjekSvarFørsteSpørgsmål(svar);
    Andetspørgesmål();
    svar = Console.ReadLine();
    tjekandetspørgesmål(svar);
    Tredjespørgesmål();
    svar =Console.ReadLine();
    tjektredjespørgesmål(svar);


    }




}
void tjekSvarFørsteSpørgsmål(string svaret)
{
    string førsteSpørgsmål = "Er ballondor rigged?";

    bool fuck = true;
    if(svaret == "Ja")
    {
        Console.WriteLine("korrekt");
    }
    else 
    {
        Console.WriteLine("du tar fejl");
        
        while (fuck)
        {
            Console.WriteLine("Spørgsmål " + førsteSpørgsmål);
            string svar = Console.ReadLine();
            if (svar == "Ja")
            {
                Console.WriteLine("korrekt");
                fuck = false;
            }
        }

    }
    
}
void Andetspørgesmål()
{
    string Andetspørgesmål = "hvor mange søer er der i viborg";
    Console.WriteLine(Andetspørgesmål);
    
}
void tjekandetspørgesmål(string svaret)
{

    if (svaret == "4")
    {
        Console.WriteLine("korrekt");
    }
    else
    {
        Console.WriteLine("du ta fejl idiot");

    }
}
void Tredjespørgesmål ()
{ 
    string tredjespørgesmål = "hvad er adressen til mercantec hca";
    Console.WriteLine(tredjespørgesmål);
}
void tjektredjespørgesmål(string svaret)
{
    if (svaret == "hcandersensvej 7") 
    {
        Console.WriteLine("korrekt");
    }
    else
    {
        Console.WriteLine("du så dum at du nok også har svarret forkert på de to andre");
    }
}



Main();