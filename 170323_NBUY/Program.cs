using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace _170323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Collection Türü
            /*  ArrayList liste = new ArrayList();
      liste.Add(1);
      liste.Add(2);
      liste.Add(3);
      liste.Add("Eray");
      liste.Add('k');
      int adet = liste.Count;
      liste.Insert(3, adet);
      liste.RemoveAt(2);
      Console.WriteLine("bulunduğu yer: " + liste.IndexOf('k'));

      if (liste.Contains(5))
      {
          Console.WriteLine("içinde var");
      }
      foreach (var item in liste)
      {
          Console.WriteLine(item);
      }

      liste.Remove("Eray");
      liste.Clear();
      liste.Add("vp");*/
            #endregion

            #region Girilen Arabaları Listeye Ekleme,Listeyi Yazdırma,Listeyi sildirme collections yöntemi
            /* ArrayList a1 = new ArrayList();
         gel:
             Console.WriteLine("Araba Eklemek İçin 1'e Basın");
             Console.WriteLine("Eklediğiniz Arabaları Listelemek İçin 2'e basın");
             Console.WriteLine("Eklediğiniz Arabaları Silmek İçin 3'e basın");
             Console.WriteLine("Çıkmak İçin 4'e Basın");
             string secim = Console.ReadLine();

             switch (secim)
             {
                 case "1":
                     Console.WriteLine("Arabanın Modelini girin:");
                     string model = Console.ReadLine();
                     Console.WriteLine("Arabanın Rengini Girin");
                     string renk = Console.ReadLine();
                     a1.Add(model);
                     a1.Add(renk);
                     break;
                 case "2":
                     foreach (var item in a1)
                     {
                         Console.WriteLine(item);
                     }

                     break;
                 case "3":
                     a1.Clear();
                     Console.WriteLine("Liste Temizlendi");
                     Console.WriteLine("Çıkış Yapılıyor");
                     break;

                 case "4":
                     Console.WriteLine("Çıkış Yapıldı.");
                     break;
             }
             goto gel;*/
            #endregion

            #region Enum ogrenci
            /* Ogrenci o1 = new Ogrenci();
             o1.adı = "Fatma";
             o1.soyad = "Pamukşeker";
             o1.Alani = Alan.sayisal;


         }
     }
     class Ogrenci
     {
         public string adı { get; set; }
         public string soyad { get; set; }
         public Alan Alani { get; set; }
     }
     public enum Alan
     {
         sayisal,
         sozel,
         esitagirlik,
         dil
     } */
            #endregion

            #region enum gunler
            /*  Gunler g1 = new Gunler();






          }
      }
      class Gunler
      {
          public haftaici gunler { get; set; }
          public haftasonu gunleri { get; set; }
      }
      public enum haftaici
      {
          pazartesi,
          salı,
          çarşamba,
          perşembe,
          cuma,

      }
      public enum haftasonu
      {
          cumartesi,
          pazar
      } */
            #endregion

            #region HashTable şehir ilçe yazdırma
            /*  Hashtable ht = new Hashtable();
              ht.Add("Üsküdar", "İstanbul");
              ht.Add("Kadıköy", "İstanbul");
              ht.Add("Sincan", "Ankara");
              ht.Add("Çankaya", "Ankara");
              ht.Add("İkizdere", "Rize");
              ht.Add("Çayeli", "Rize");
              ht.Add("Görele", "Giresun");
              ht.Add("Çanakçı", "Giresun");

              foreach (DictionaryEntry hash in ht)
              {
                  Console.WriteLine(hash.Key + " " + hash.Value);
              }


          label:
              Console.WriteLine("Hangi Şehir ile ilgili bilgileri istiyorusunuz ?\nİstanbul : 1\nAnkara   : 2\nRize     : 3\nGiresun  : 4");
              switch (Console.ReadLine())
              {
                  case "1":
                      Console.WriteLine("İstanbulun İlçeleri\n----------------------");
                      foreach (DictionaryEntry hash in ht)
                      {
                          if (hash.Value.Equals("İstanbul"))
                          {
                              Console.WriteLine(hash.Key);
                          }
                      }
                      break;
                  case "2":
                      Console.WriteLine("\nAnkaranın İlçeleri\n---------------------");
                      foreach (DictionaryEntry hash in ht)
                      {
                          if (hash.Value.Equals("Ankara"))
                          {
                              Console.WriteLine(hash.Key);
                          }
                      }
                      break;
                  case "3":
                      Console.WriteLine("\nRizenin İlçeleri\n---------------------");
                      foreach (DictionaryEntry hash in ht)
                      {
                          if (hash.Value.Equals("Rize"))
                          {
                              Console.WriteLine(hash.Key);
                          }
                      }
                      break;
                  case "4":
                      Console.WriteLine("\nGiresunun İlçeleri\n---------------------");
                      foreach (DictionaryEntry hash in ht)
                      {
                          if (hash.Value.Equals("Giresun"))
                          {
                              Console.WriteLine(hash.Key);
                          }
                      }
                      break;
                  default:
                      Console.WriteLine("Yanlış giriş Tekrar girin");
                      goto label;
              }

          } */
            #endregion

            #region Hastable Anlatım
            /*  İncelemek isteyenler için Nafih'in Lojistik Örneği 13.Hafta 4.Günde .
      -------------------------------------------------------------------------------------- -
      Hastable |
      ----------

      Örnek: Key ve value ile ekliyoruz.Keye göre value value ye göre key getirebiliyoruz.
  Not: Keyler Unique değerdir.Aynı keyden 2 tane olamaz.


  Özellikler:
              Hashtable ht = new Hashtable();

              ht.ContainsKey("");
              Girilen key değeri var ise True yok ise false döner.

              ht.ContainsValue("");
              Girilen value değeri var ise True yok ise false döner.
              --------------------------------------------------------------------------------------
    class Program
          {
              static void Main(string[] args)
              {
                  Hashtable ht = new Hashtable();
                  ht.Add("Üsküdar", "İstanbul");
                  ht.Add("Kadıköy", "İstanbul");
                  ht.Add("Sincan", "Ankara");
                  ht.Add("Çankaya", "Ankara");

                  Console.WriteLine("İstanbulun İlçeleri\n----------------------");
                  foreach (DictionaryEntry hash in ht)
                  {
                      if (hash.Value.Equals("İstanbul"))
                      {
                          Console.WriteLine(hash.Key);
                      }
                  }

                  Console.WriteLine("\nAnkaranın İlçeleri\n---------------------");
                  foreach (DictionaryEntry hash in ht)
                  {
                      if (hash.Value.Equals("Ankara"))
                      {
                          Console.WriteLine(hash.Key);
                      }
                  }

                  Console.ReadKey();
              }
          }
  -----------------------------------------------------------------------------------------
  SortedList | : Hashtable ile aynı özelliklere sahiptir.
  ------------   extra olarak Liste içerisindeki tüm değerleri sıralar

  class Program
          {
              static void Main(string[] args)
              {
                  SortedList sl = new SortedList();

                  sl.Add("Bilal", "B");
                  sl.Add("Can", "C");
                  sl.Add("Ayşe", "A");
                  sl.Add("Baran", "B");
                  sl.Add("Ali", "A");
                  sl.Add("Ceren", "C");

                  foreach (DictionaryEntry list in sl)
                  {
                      Console.WriteLine(list.Key + " " + list.Value);
                  }
                  Console.ReadKey();
              }
          }
  -------------------------------------------------------------------------------------------
  Stack | İlk giren En son çıkar. (LİFO) kapasite = 10(Aşınca 2 katına çıakr)
  ------ -
  Push() : Ekleme
  Pop()  : Alma(Okuduğu elemanı siler.)
  Peek() : En son elemanı gösterir.

      class Program
          {
              static void Main(string[] args)
              {
                  Stack stk = new Stack();

                  stk.Push(1);
                  stk.Push(2);
                  stk.Push(3);
                  stk.Push(4);
                  stk.Push(5);
                  stk.Push(6);

                  Console.WriteLine("En son eleman = {0}", stk.Peek());

                  int uzun = stk.Count;
                  for (int i = 0; i < uzun; i++)
                  {
                      Console.WriteLine(stk.Pop());
                  }

                  Console.ReadKey();
              }
          }
  -------------------------------------------------------------------------------------------
  Queue-Kuyruk | İlk giren İlk Çıkar(FİFO) kapasite = 32(aşınca 2 katına çıkar)
  --------------

  class Program
          {
              static void Main(string[] args)
              {
                  Queue qu = new Queue();

                  qu.Enqueue("Bir");
                  qu.Enqueue("İki");
                  qu.Enqueue("Üç");
                  qu.Enqueue("Dört");
                  qu.Enqueue("Beş");
                  qu.Enqueue("Altı");

                  Console.WriteLine("Baş Eleman = " + qu.Peek());
                  Console.WriteLine("Baş Elemanı yazar ve onu çıkarır = " + qu.Dequeue());
                  Console.WriteLine("Baş Elemanı yazar ve onu çıkarır = " + qu.Dequeue());
                  Console.WriteLine("Baş Elemanı yazar ve onu çıkarır = " + qu.Dequeue());
                  Console.ReadKey();
              }
          }
      } */
            #endregion

            #region Sinema Salonu Rezervasyon ArrayList
            /*    int koltuk = 0;
                string isim = "";
                ArrayList aksiyon = new ArrayList(15);
                ArrayList korku = new ArrayList(10);
                for (int i = 0; i < 15; i++)
                {
                    aksiyon.Add(i + 1);
                }
                for (int i = 0; i < 10; i++)
                {
                    korku.Add(i + 1);
                }
                int sayac = 0;
                int sayac2 = 0;
            label:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n**** Sinema Salonuna Hoş Geldiniz ****\n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("-----AKSİYON SALONU BOŞ KOLTUKLAR-----");

                foreach (var item in aksiyon)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    if (item.ToString() != "1" && item.ToString() != "2" && item.ToString() != "3" &&
                        item.ToString() != "4" && item.ToString() != "5" && item.ToString() != "6" &&
                        item.ToString() != "7" && item.ToString() != "8" && item.ToString() != "9" &&
                        item.ToString() != "10" && item.ToString() != "11" && item.ToString() != "12"
                        && item.ToString() != "13" && item.ToString() != "14" && item.ToString() != "15")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    Console.Write(item + "\t");
                    if (sayac == 4)
                    {
                        Console.Write("   \n");
                        sayac = -1;
                    }

                    sayac++;
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("--------------------------------------\n\n");
                Console.WriteLine("-----KORKU SALONU BOŞ KOLTUKLAR-------");
                foreach (var item in korku)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    if (item.ToString() != "1" && item.ToString() != "2" && item.ToString() != "3" &&
                        item.ToString() != "4" && item.ToString() != "5" && item.ToString() != "6" &&
                        item.ToString() != "7" && item.ToString() != "8" && item.ToString() != "9" &&
                        item.ToString() != "10")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    Console.Write(item + "\t");
                    if (sayac == 4)
                    {
                        Console.WriteLine();
                        sayac = -1;
                    }
                    sayac++;
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("--------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Hangi Salon \nAksiyon : 1\nKorku   : 2 : ");
                switch (Console.ReadLine())
                {
                    case "1":
                        #region Aksiyon
                        Console.ForegroundColor = ConsoleColor.White;
                    label2:
                        Console.Write("Hangi Koltuğa Oturmak İstiyorsunuz : ");
                        try
                        {
                            koltuk = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Hatalı giriş");
                            goto label2;
                        }
                        if (koltuk != 1 && koltuk != 2 && koltuk != 3 && koltuk != 4 && koltuk != 5 &&
                            koltuk != 6 && koltuk != 7 && koltuk != 8 && koltuk != 9 && koltuk != 10 &&
                            koltuk != 11 && koltuk != 12 && koltuk != 13 && koltuk != 14 && koltuk != 15)
                        {
                            Console.Clear();
                            Console.WriteLine("Böyle bir Koltuk Yok");
                            goto label;
                        }
                        else
                        {
                            if (aksiyon.Contains(koltuk))
                            {
                            label5:
                                Console.Write("İsminiz Nedir(En Fazla 7 Karakter Rakam İçeremez) ? : ");
                                isim = Console.ReadLine();
                                if (isim.Length <= 7 && isim.Length > 0)
                                {
                                    for (int i = 0; i < isim.Length; i++)
                                    {
                                        if (isim[i] == '1' || isim[i] == '2' || isim[i] == '3' || isim[i] == '4' || isim[i] == '5' ||
                                            isim[i] == '6' || isim[i] == '7' || isim[i] == '8' || isim[i] == '9')
                                        {
                                            sayac2++;
                                        }
                                    }
                                    if (sayac2 == 0)
                                    {
                                        Console.Write("Rezervasyon Yapılıyor");
                                        for (int i = 0; i < 5; i++)
                                        {
                                            Console.Write(".");
                                            System.Threading.Thread.Sleep(1000);
                                        }
                                        aksiyon.RemoveAt(koltuk - 1);
                                        aksiyon.Insert(koltuk - 1, isim);
                                        Console.Clear();
                                        Console.WriteLine("Rezervasyon Yapıldı !!!");
                                        goto label;
                                    }
                                    else
                                    {
                                        Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
                                        goto label5;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
                                    goto label5;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Bu koltuk Dolu !!");
                                goto label;
                            }

                        }
                    #endregion
                    case "2":
                        #region Korku
                        Console.ForegroundColor = ConsoleColor.White;
                    label3:
                        Console.Write("Hangi Koltuğa Oturmak İstiyorsunuz : ");
                        try
                        {
                            koltuk = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Hatalı giriş");
                            goto label3;
                        }
                        if (koltuk != 1 && koltuk != 2 && koltuk != 3 && koltuk != 4 && koltuk != 5 &&
                    koltuk != 6 && koltuk != 7 && koltuk != 8 && koltuk != 9 && koltuk != 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Böyle bir Koltuk Yok");
                            goto label;
                        }
                        else
                        {
                            if (korku.Contains(koltuk))
                            {
                            label4:
                                Console.Write("İsminiz Nedir(En Fazla 7 Karakter Rakam İçeremez) ? : ");
                                isim = Console.ReadLine();
                                if (isim.Length <= 7 && isim.Length > 0)
                                {
                                    for (int i = 0; i < isim.Length; i++)
                                    {
                                        if (isim[i] == '1' || isim[i] == '2' || isim[i] == '3' || isim[i] == '4' || isim[i] == '5' ||
                                            isim[i] == '6' || isim[i] == '7' || isim[i] == '8' || isim[i] == '9')
                                        {
                                            sayac2++;
                                        }
                                    }
                                    if (sayac2 == 0)
                                    {
                                        Console.Write("Rezervasyon Yapılıyor");
                                        for (int i = 0; i < 5; i++)
                                        {
                                            Console.Write(".");
                                            System.Threading.Thread.Sleep(1000);
                                        }
                                        korku.RemoveAt(koltuk - 1);
                                        korku.Insert(koltuk - 1, isim);
                                        Console.Clear();
                                        Console.WriteLine("Rezervasyon Yapıldı !!!");
                                        goto label;
                                    }
                                    else
                                    {
                                        Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
                                        goto label4;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
                                    goto label4;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Bu koltuk Dolu !!");
                                goto label;
                            }

                        }
                    #endregion
                    default:
                        Console.Clear();
                        Console.WriteLine("Yanlış Giriş");
                        goto label;
                } */
            #endregion

        }
    }
}