using _060826_oveKodning;

Customer costumer = new Customer("Jytte", "KundeId1");
Customer costumer2 = new Customer("Hanne", "KundeId2");
Customer costumer3 = new Customer("Lis", "KundeId3");
Customer costumer4 = new Customer("Jane", "KundeId4");
List<Customer> customerList = new List<Customer>();
customerList.Add(costumer);
customerList.Add(costumer2);
customerList.Add(costumer3);
customerList.Add(costumer4);

Equipment equipment = new Equipment("Bomuldstråd", "Universal Nål", "Symaskine");
Equipment equipment2 = new Equipment("Polyestertråd", "Overlock Nål", "Overlockmaskine");
Equipment equipment3 = new Equipment("Silketråd", "Broderinål", "Broderimaskine");
Equipment equipment4 = new Equipment("Elastiktråd", "Striknål", "Strikkemaskine");
Equipment equipment5 = new Equipment("Lædertråd", "Lædernål", "Lædermaskine");
List<Equipment> equipmentList = new List<Equipment>();
equipmentList.Add(equipment);
equipmentList.Add(equipment2);
equipmentList.Add(equipment3);
equipmentList.Add(equipment4);
equipmentList.Add(equipment5);

Fabric fabric = new Fabric("Blå", "Prikket", "Bomuld", "Sommerkjole");
Fabric fabric2 = new Fabric("Rød", "Stribet", "Linned", "Sommerjakke");
Fabric fabric3 = new Fabric("Grøn", "Blomstret", "Silke", "Sommerbluse");
Fabric fabric4 = new Fabric("Gul", "Geometrisk", "Uld", "Vinterfrakke");
List<Fabric> fabricList = new List<Fabric>();
fabricList.Add(fabric);
fabricList.Add(fabric2);
fabricList.Add(fabric3);
fabricList.Add(fabric4);

Location location = new Location("Nattergalevej", 1, 8600, "Silkeborg", "Danmark", 80123456, 100);
Location location2 = new Location("Bredhøjvej", 14, 8600, "Silkeborg", "Danmark", 90909010, 50);
Location location3 = new Location("Skovvej", 7, 8600, "Silkeborg", "Danmark", 70707070, 75);
Location location4 = new Location("Søndergade", 3, 8600, "Silkeborg", "Danmark", 60606060, 25);
List<Location> locationList = new List<Location>();
locationList.Add(location);
locationList.Add(location2);
locationList.Add(location3);
locationList.Add(location4);

Worker worker = new Worker("Nynne", "Medarbejder1", "Syerske", 2015, 2026);
Worker worker2 = new Worker("Susanne", "Medarbejder2", "Syerske", 2016, 2026);
Worker worker3 = new Worker("Tulle", "Medarbejder3", "Ejer", 2000, 2026);
Worker worker4 = new Worker("Mette", "Medarbejder4", "Syerske", 2018, 2025);
List<Worker> workerList = new List<Worker>();
workerList.Add(worker);
workerList.Add(worker2);
workerList.Add(worker3);
workerList.Add(worker4);




List<Fabric> MinListeAfStoffer = new List<Fabric> { fabric, fabric2, fabric3, fabric4 };
Console.WriteLine($"Antallet af stoffer på lageret: {MinListeAfStoffer.Count}");

List<Equipment> MinListeAfUdstyr = new List<Equipment> { equipment, equipment2, equipment3, equipment4 };
Console.WriteLine($"Antallet af udstyr på lageret: {MinListeAfUdstyr.Count}"); //Find ud af hvordan jeg automatisk tilføjer nyt udstyr til listen


