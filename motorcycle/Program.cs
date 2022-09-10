Motorcycle Motorcycle1 = new Motorcycle();
Motorcycle1.Marka = "Ducati";
Motorcycle1.Model = "V4S";
Motorcycle1.Hp = 214;
Motorcycle1.Hacim = 1103;
Motorcycle1.Tipi = "Racing";

Motorcycle Motorcycle2 = new Motorcycle();
Motorcycle2.Marka = "Kawasaki";
Motorcycle2.Model = "H2R";
Motorcycle2.Hp = 310;
Motorcycle2.Hacim = 998;
Motorcycle2.Tipi = "Raceing";

Motorcycle Motorcycle3 = new Motorcycle();
Motorcycle3.Marka = "Yamaha";
Motorcycle3.Model = "MT-07";
Motorcycle3.Hp = 74.8;
Motorcycle3.Hacim = 689;
Motorcycle3.Tipi = "Naked";

Motorcycle Motorcycle4 = new Motorcycle();
Motorcycle4.Marka = "Honda";
Motorcycle4.Model = "CRF 250L";
Motorcycle4.Hp = 24;
Motorcycle4.Hacim = 250;
Motorcycle4.Tipi = "Cross";

Motorcycle Motorcycle5 = new Motorcycle();
Motorcycle5.Marka = "BMW";
Motorcycle5.Model = "R1250GS";
Motorcycle5.Hp = 136;
Motorcycle5.Hacim = 1254;
Motorcycle5.Tipi = "Adventure";

Motorcycle[] Motorcycles = new Motorcycle[] {  Motorcycle1  ,  Motorcycle2  , Motorcycle3 , Motorcycle4 , Motorcycle5 };

foreach (var Motorcycle in Motorcycles)
{
	if (Motorcycle.Hp > 100)
	{
		Console.WriteLine(Motorcycle.Marka +" "+ Motorcycle.Model +" "+ Motorcycle.Hp +" "+ Motorcycle.Hacim +" "+ Motorcycle.Tipi +" "+"Roket");
	}

	else if (Motorcycle.Hp < 100 )
	{
		Console.WriteLine(Motorcycle.Marka + " " + Motorcycle.Model + " " + Motorcycle.Hp + " " + Motorcycle.Hacim + " " + Motorcycle.Tipi + " " +"Karınca");
	}


}

