


using Bank;

Account ac = new Account(12,"ahmad",122.3);

while (true)
{
    Console.WriteLine(  "1 wähle eine aktion aus kontostand anzeigen");
    Console.WriteLine("2 wähle eine aktion aus Einzahlung");

    Console.WriteLine("3 wähle eine aktion aus Auszahlung");
    String userEingabe= Console.ReadLine();
   
     if (userEingabe == "1")
    {
        Console.WriteLine(ac.Balance);
    }
    else if (userEingabe == "2")
    {
        Console.WriteLine(  " wie viel möchten Sie einzahlen");
        int betrag=int.Parse(Console.ReadLine());
        ac.makeDeposit(betrag);
        Console.WriteLine( ac.Balance);
    }

    else if (userEingabe == "3")
    {
        Console.WriteLine(" wie viel möchten Sie auszahlen");
        int betrag = int.Parse(Console.ReadLine());
        ac.makeWithdeow(betrag);
        Console.WriteLine(ac.Balance);
    }
    else
    {
        Console.WriteLine(  " falsche eingabe ");
        break;
    }




}