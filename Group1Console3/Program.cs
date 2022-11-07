using Group1Console3;

Console.WriteLine("Mire se vini ne Kolegjin AAB!");
////tri kategori te variableave
//int numri=1;
//string emri="Leron Berisha";
//bool kushti=true;
//kushti=true;
////Console.WriteLine($"{emri} eshte numer {numri}");
////Console.WriteLine($"A eshte e vertete a jo? {kushti}");

//void ParaqitProfesorin(string prof,int numrip,bool kushtip)
//{
//    Console.WriteLine($"{prof} eshte numer {numrip}");
//    Console.WriteLine($"A eshte e vertete a jo? {kushtip}");
//}
//ParaqitProfesorin("Leron Berisha",1,true);

// int numri2 = 100;
// Studenti studenti = new Studenti("Edi","Morina",21);
// studenti.Pershendete();
//
// Profesor profesor1 = new Profesor("Leron", "Berisha");
// profesor1.Pershendete();


List<Person> personat = new List<Person>();
personat.Add(new Profesor("Leron","Berisha"));
personat.Add(new Studenti("Dorjana","Shala",20));
personat.Add(new Studenti("Edi", "Morina", 21));

foreach (var person in personat)
{
    person.Pershendete();
}

int Mbledhja(int numri1,int numri2)
{
  int rezultati = numri1 + numri2;
  return rezultati;
}

int rez= Mbledhja(2,2);
Console.WriteLine(rez);

void Mbledhja2(int numri1, int numri2)
{
    int rezultati = numri1 + numri2;
    Console.WriteLine(rezultati);
}

 Mbledhja2(2,2);