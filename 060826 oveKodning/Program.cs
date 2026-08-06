using _060826_oveKodning;

Customer customer = new Customer("Jytte", "KundeId1");
Customer custome2 = new Customer("Hanne", "KundeId2");
Customer custumer3 = new Customer("Lis", "KundeId3");
Customer custumer4 = new Customer("Jane", "KundeId4");

Equipment equipment = new Equipment("Bomuldstråd", "Universal Nål", "Symaskine");
Equipment equipment2 = new Equipment("Polyestertråd", "Overlock Nål", "Overlockmaskine");
Equipment equipment3 = new Equipment("Silketråd", "Broderinål", "Broderimaskine");
Equipment equipment4 = new Equipment("Elastiktråd", "Striknål", "Strikkemaskine");
Equipment equipment5 = new Equipment("Lædertråd", "Lædernål", "Lædermaskine");

Fabric fabric = new Fabric("Blå", "Prikket", "Bomuld", "Sommerkjole");
Fabric fabric2 = new Fabric("Rød", "Stribet", "Linned", "Sommerjakke");
Fabric fabric3 = new Fabric("Grøn", "Blomstret", "Silke", "Sommerbluse");
Fabric fabric4 = new Fabric("Gul", "Geometrisk", "Uld", "Vinterfrakke");

Location location = new Location("Nattergalevej", 1, 8600, "Silkeborg", "Danmark", 80123456, 100);
Location location2 = new Location("Bredhøjvej", 14, 8600, "Silkeborg", "Danmark", 90909010, 50);
Location location3 = new Location("Skovvej", 7, 8600, "Silkeborg", "Danmark", 70707070, 75);
Location location4 = new Location("Søndergade", 3, 8600, "Silkeborg", "Danmark", 60606060, 25);

Worker worker = new Worker("Nynne", "Medarbejder1", "Syerske", 2015, 2026);
Worker worker2 = new Worker("Susanne", "Medarbejder2", "Syerske", 2016, 2026);
Worker worker3 = new Worker("Tulle", "Medarbejder3", "Ejer", 2000, 2026);
Worker worker4 = new Worker("Mette", "Medarbejder4", "Syerske", 2018, 2025);

List<Fabric> MinListeAfStoffer = new List<Fabric> { fabric, fabric2, fabric3, fabric4 };
Console.WriteLine($"Antallet af stoffer på lageret: {MinListeAfStoffer.Count}");

List<Equipment> MinListeAfUdstyr = new List<Equipment> { equipment, equipment2, equipment3, equipment4 };
Console.WriteLine($"Antallet af udstyr på lageret: {MinListeAfUdstyr.Count}"); //Find ud af hvordan jeg automatisk tilføjer nyt udstyr til listen


