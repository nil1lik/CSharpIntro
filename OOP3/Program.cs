using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);

List<IKrediManager> krediler = new List<IKrediManager>
{
    ihtiyacKrediManager, tasitKrediManager
};


//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
Console.ReadLine();