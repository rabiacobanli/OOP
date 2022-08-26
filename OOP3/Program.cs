using OOP3;

IKrediManager ihtiyacKrediManager=new IhtiyacKrediManager();
IKrediManager tasitKrediManager =new TasitKrediManager();
IKrediManager konutKrediManager =new KonutKrediManager();

ILoggerService databaseLoggerService=new DatabaseLoggerService();
ILoggerService fileLoggerService=new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(new EsnafKrediManager(),new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });
//basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);
//basvuruManager.BasvuruYap(tasitKrediManager);
//basvuruManager.BasvuruYap(ihtiyacKrediManager);


//Interface'ler o interface'i implement eden class'ın referans numarasını tutabilir.

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);





