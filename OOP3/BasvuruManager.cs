﻿using System;
namespace OOP3
{
	class BasvuruManager
	{
		//Method Injection
		public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
		{
			//Başvuran bilgilerini değerlendirme
			//
			krediManager.Hesapla();
			loggerService.Log();
		}
		
		public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
		{
			foreach (var kredi in krediler)
			{
				kredi.Hesapla();
			}
		}
 
	}
}

