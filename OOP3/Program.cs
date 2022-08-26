using OOP3;

IKrediManager ihtiyacKrediManager=new IhtiyacKrediManager();
IKrediManager tasitKrediManager=new TasitKrediManager();
IKrediManager konutKrediManager=new KonutKrediManager();


BasvuruManager basvuruManager = new BasvuruManager();
//basvuruManager.BasvuruYap(konutKrediManager);
//basvuruManager.BasvuruYap(tasitKrediManager);
//basvuruManager.BasvuruYap(ihtiyacKrediManager);


//Interface'ler o interface'i implement eden class'ın referans numarasını tutabilir.

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

basvuruManager.KrediOnBilgilendirmesiYap(krediler);





