using System;
namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    { 
        void IKrediManager.BiseyYap()
        {
            throw new NotImplementedException();
        }

        void IKrediManager.Hesapla()
        {
            //Hesaplar yapıldı, kodlar yazıldı... En son:
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}

