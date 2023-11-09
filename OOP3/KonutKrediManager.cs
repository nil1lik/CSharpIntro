using System;
namespace OOP3
{
    public class KonutKrediManager : IKrediManager
    {
        void IKrediManager.BiseyYap()
        {
            throw new NotImplementedException();
        }

        void IKrediManager.Hesapla()
        {
            //Hesaplar yapıldı, kodlar yazıldı... En son:
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}

