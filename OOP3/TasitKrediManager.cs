using System;
namespace OOP3
{
    public class TasitKrediManager : IKrediManager
    { 
        void IKrediManager.BiseyYap()
        {
            throw new NotImplementedException();
        }

        void IKrediManager.Hesapla()
        {
            //Hesaplar yapıldı, kodlar yazıldı... En son:
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}

