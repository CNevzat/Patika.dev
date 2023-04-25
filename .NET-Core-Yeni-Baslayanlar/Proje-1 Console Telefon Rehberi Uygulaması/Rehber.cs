using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1_Console_Telefon_Rehberi_Uygulaması
{
	public class Rehber
	{
		List<Kisi> kisiler = new List<Kisi>(); //Listenin tipi Kisi objesi
		public Rehber()
		{
			// Varsayılan 5 kişi
			kisiler.Add(new Kisi("Nevzat", "Çırpıcıoğlu", "1806538"));
			kisiler.Add(new Kisi("Yahya", "Çırpıcıoğlu", "1806537"));
			kisiler.Add(new Kisi("Furkan", "Demir", "1806536"));
			kisiler.Add(new Kisi("Berk", "Sayit", "1806535"));
			kisiler.Add(new Kisi("Erman", "Kaymaz", "1806534"));
		}

		public void AddNo()
		{
			Console.WriteLine("**** Yeni Numara Kaydetme ****");
			string name = "";
			string surname = "";
			string phone_number = "";
			//Kullanıcıdan aldığımız inputların validasyonu için bool ifadeleri ile kontrol sağlanır
			//Default olarak false
			bool nameIsValid = false;
			bool surnameIsValid = false;
			bool phoneIsValid = false;

			while (!nameIsValid || !surnameIsValid || !phoneIsValid) //tüm koşullar true olduğunda döngü sonlanır
			{
				if (!nameIsValid) //initial olarak bu block çalışır
				{
					Console.Write("İsminizi giriniz: ");
					name = Console.ReadLine().Trim(); // Kullanıcı boşluk kullanarak giriş yaparsa Trim metodu ile boşluklar silinir
					if (string.IsNullOrEmpty(name)) //string kütüphanesinin bir metodu olan IsNullOrEmpty metodu ile name'in boş olup
													//olmadığı kontrolü yapılır
					{
						Console.WriteLine("Uyarı !!!");
						Console.WriteLine("İsim boş bırakılamaz");
					}
					else //name boş değilse
					{
						nameIsValid = true;
					}
				}
				else if (!surnameIsValid)
				{
					Console.Write("Soyisminizi giriniz: ");
					surname = Console.ReadLine().Trim();
					if (string.IsNullOrEmpty(surname))
					{
						Console.WriteLine("Uyarı !!!");
						Console.WriteLine("Soyisim boş bırakılamaz");
					}
					else
					{
						surnameIsValid = true;
					}
				}
				else if (!phoneIsValid)
				{
					Console.Write("10 haneli telefon numaranızı giriniz: ");
					phone_number = Console.ReadLine().Trim();

					if (string.IsNullOrEmpty(phone_number))
					{
						Console.WriteLine("Uyarı !!!");
						Console.WriteLine("Telefon numarası boş geçilemez");
					}
					else if (phone_number.Length == 10)
					{
						//string türündeki telefon numarasını TryParse metodu ile long türüne çevirmeye çalışılır
						//Eğer çevrilemezse yapı false döner ve geçersiz telefon numarası uyarısı verir. 
						if (long.TryParse(phone_number, out long converted_no) == false)
						{
							Console.WriteLine("Geçersiz telefon numarası");
						}
						else { phoneIsValid = true; }
					}
				}
			}
			kisiler.Add(new Kisi(name, surname, phone_number));
			Console.WriteLine("Ekleme işlemi başarılı");
		}
		public void DeleteNo()
		{
			string name = "";
			string surname = "";
			bool nameIsValid = false;
			bool surnameIsValid = false;
			while (!nameIsValid || !surnameIsValid)
			{
				if (!nameIsValid)
				{
					Console.Write("Numarasını silmek istediğiniz kişinin adını giriniz: ");
					name = Console.ReadLine().Trim();
					if (string.IsNullOrEmpty(name))
					{
						Console.WriteLine("İsim boş bırakılamaz");
					}
					else
					{
						nameIsValid = true;
					}
				}
				else if (!surnameIsValid)
				{
					Console.Write("Numarasını silmek istediğiniz kişinin soyadını giriniz: ");
					surname = Console.ReadLine().Trim();
					if (string.IsNullOrEmpty(surname))
					{
						Console.WriteLine("Soyad boş bırakılamaz");
					}
					else
					{
						surnameIsValid = true;
					}
				}
			}
			var result = kisiler.Find(x => x.Name == name && x.Surname == surname);
			if (result != null)
			{
				kisiler.Remove(result);
				Console.WriteLine("Kişi başarıyla listenizden silindi");
			}
			else
			{
				Console.WriteLine("Kişi bulanamadı !");
			}
		}
		public void List()
		{
			bool secimIsValid = false;
			string secim = "";
			Console.WriteLine("Rehberi Listele");
			Console.WriteLine("****************");
			while (!secimIsValid)
			{
				if (!secimIsValid)
				{
					Console.WriteLine("A-Z listelemek için '1' \nZ-A listelemek için '2' seçiniz: ");
					secim = Console.ReadLine();
					if (string.IsNullOrEmpty(secim))
					{
						Console.WriteLine("Lütfen doğru seçim yapınız");
					}
					else
					{
						secimIsValid = true;
					}
				}
			}
			if (secim == "1")
			{
				Console.WriteLine("Telefon Listesi");
				Console.WriteLine("****************");
				List<Kisi> sortedList = kisiler.OrderBy(x => x.Name).ToList();   // İsme göre A-Z
				foreach (var item in sortedList)
				{
					Console.WriteLine("Ad: " + item.Name);
					Console.WriteLine("Soyad: " + item.Surname);
					Console.WriteLine("Telefon numarası: " + item.Phone_Number);
				}
			}
			if (secim == "2")
			{
				Console.WriteLine("Telefon Listesi");
				Console.WriteLine("****************");
				List<Kisi> sortedList = kisiler.OrderByDescending(x => x.Name).ToList();   // İsme göre Z-A
				foreach (var item in sortedList)
				{
					Console.WriteLine("Ad: " + item.Name);
					Console.WriteLine("Soyad: " + item.Surname);
					Console.WriteLine("Telefon numarası: " + item.Phone_Number);
				}
			}
		}
		public void Search()
		{
			Console.WriteLine("İsim ve soyisme göre arama yapmak için '1'\n" +
				"Telefon numarasına göre arama yapmak için '2' seçiniz: ");
			string secim = Console.ReadLine();

			if (secim == "1")
			{
				Console.Write("İsim giriniz: ");
				string name = Console.ReadLine();
				Console.Write("Soyisim giriniz: ");
				string surname = Console.ReadLine();

				var result = kisiler.Find(x => x.Name == name && x.Surname == surname);
				if (result != null)
				{
					Console.Write(result.Name + " ");
					Console.Write(result.Surname + " ");
					Console.WriteLine(result.Phone_Number);
				}
				else
				{
					Console.WriteLine("Kişi bulunamadı");
				}
			}
			else if (secim == "2")
			{
				Console.WriteLine("Telefon numarası giriniz:");
				string no = Console.ReadLine();

				var result = kisiler.Find(x => x.Phone_Number == no); //LINQ Expression
				if (result != null)
				{
					Console.WriteLine(result.Name);
					Console.WriteLine(result.Surname);
					Console.WriteLine(result.Phone_Number);
				}
				else
				{ Console.WriteLine("Kişi bulunamadı"); }
			}
		}
		public void UpdateNo()
		{
			string name = "";
			string surname = "";
			string phoneNumber = "";
			bool nameIsValid = false;
			bool surnameIsValid = false;
			bool phoneIsValid = false;

			while (!nameIsValid || !surnameIsValid || !phoneIsValid)
			{
				if (!nameIsValid)
				{
					Console.Write("Numarasını güncellemek istediğiniz kişinin adını giriniz: ");
					name = Console.ReadLine().Trim();
					if (string.IsNullOrEmpty(name))
					{
						Console.WriteLine("İsim boş bırakılamaz");
					}
					else
					{
						nameIsValid = true;
					}
				}
				else if (!surnameIsValid)
				{
					Console.Write("Numarasını güncellemek istediğiniz kişinin soyadını giriniz: ");
					surname = Console.ReadLine().Trim();
					if (string.IsNullOrEmpty(surname))
					{
						Console.WriteLine("Soyad boş bırakılamaz");
					}
					else
					{
						surnameIsValid = true;
					}
				}
				else if (!phoneIsValid)
				{
					Console.Write("10 haneli telefon numaranızı giriniz: ");
					phoneNumber = Console.ReadLine().Trim();
					var result = kisiler.Find(x => x.Phone_Number == phoneNumber);

					if (string.IsNullOrEmpty(phoneNumber))
					{
						Console.WriteLine("Uyarı !!!");
						Console.WriteLine("Telefon numarası boş geçilemez");
					}
					else if (phoneNumber.Length == 10)
					{
						//string türündeki telefon numarasını TryParse metodu ile long türüne çevirmeye çalışılır
						//Eğer çevrilemezse yapı false döner ve geçersiz telefon numarası uyarısı verir. 
						if (long.TryParse(phoneNumber, out long converted_no) == false)
						{
							Console.WriteLine("Geçersiz telefon numarası");
						}
					}
					else if (result != null)
					{
						Console.WriteLine("Kişi bulundu");
						Console.Write("Yeni telefon numarasını giriniz:");
						string new_no = Console.ReadLine();
						if (string.IsNullOrEmpty(new_no))
						{
							Console.WriteLine("Numara boş geçilemez !");
						}
						else if (new_no.Length == 10)
						{
							if (long.TryParse(phoneNumber, out long converted_no) == false)
							{
								Console.WriteLine("Geçersiz telefon numarası");
							}
							else
							{
								var sonuc = kisiler.Find(x => x.Phone_Number == phoneNumber);
								sonuc.Phone_Number = new_no;
								Console.WriteLine("Güncelleme başarıyla gerçekleştirildi");
								phoneIsValid = true;
							}
						}
						else { Console.WriteLine("Geçersiz telefon numarası!"); }
					}
					else
					{
						Console.WriteLine("Kişi bulunamadı. Lütfen bir seçim yapınız");
						Console.WriteLine("Güncellenemyi sonlandırmak için :'1'\n" +
										  "Yeniden denemek için:           :'2'");
						string secim = Console.ReadLine();
						if (secim == "1")
						{
							break;
						}
						else if (secim != "2")
						{
							Console.WriteLine("Hatalı giriş yaptınız");
						}
					}
				}
			}
		}
	}
}
