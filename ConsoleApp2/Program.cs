using System.Data.SqlTypes;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sor Numarasını Giriniz:!");
            int qNum = Convert.ToInt32(Console.ReadLine());

            if (qNum == 1)
            {
                //Girilen sayının tek mi çift mi olduğunu bulan program

                Console.WriteLine("Bir sayı giriniz : ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine(num + " çift bir sayıdır.");
                }
                else
                {
                    Console.WriteLine(num + " tek bir sayıdır.");
                }
            }

            if (qNum == 2)
            {
                //Girilen sayı hem 2 hem de 3 ile tam bölünebiliyorsa “TAMAM”, aksi halde “HATA” mesajı veren program

                Console.WriteLine("Bir sayı giriniz :");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0 && num % 3 == 0)
                {
                    Console.WriteLine("TAMAM");
                }
                else
                {
                    Console.WriteLine("HATA");
                }

            }

            if (qNum == 3)
            {
                //Girilen 3 sayıdan en az biri 50’den büyükse “Yeterli”, aksi halde “Yetersiz” mesajı veren program
                Console.WriteLine("Üç sayı girin:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 > 50 || num2 > 50 || num3 > 50)
                {
                    Console.WriteLine("Yeterli");
                }
                else
                {
                    Console.WriteLine("Yetersiz");
                }

            }

            if (qNum == 4)
            {
                //Kullanıcı ders notunu girsin. Notu 50'den küçükse kaldınız, büyükse geçtiniz yazan program

                Console.WriteLine("Ders notunu giriniz:");
                int exam = Convert.ToInt32(Console.ReadLine());

                if (exam < 50)
                {
                    Console.WriteLine("Kaldınız.");
                }
                else
                {
                    Console.WriteLine("Geçtiniz.");
                }
            }

            if (qNum == 5)
            {
                //Girilen sayının pozitif mi negatif mi olduğunu yazan program

                Console.WriteLine("Bir sayı girin:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine("Girilen sayı pozitif.");
                }
                else if (num < 0)
                {
                    Console.WriteLine("Girilen sayı negatif.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı sıfıra eşit.");
                }
            }

            if (qNum == 6)
            {
                //Girilen sayının mükemmel sayı olup olmadığını bulan program(Bir sayının kendisi hariç bölenlerinin toplamının kendisine eşit olması. 6 -> 1 - 2 - 3 - 6 | 1+2+3 = 6)

                Console.WriteLine("Bir sayı girin:");
                int num = Convert.ToInt32(Console.ReadLine());

                int total = 0;

                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        total += i;
                    }
                }

                if (total == num)
                {
                    Console.WriteLine(num + " mükemmel bir sayıdır.");
                }
                else
                {
                    Console.WriteLine(num + " mükemmel bir sayı değildir.");
                }
            }

            if (qNum == 7)
            {
                //1 ve 200 arasında çift sayıların toplamını bulan program
                int total = 0;

                for (int i = 2; i <= 200; i += 2)
                {
                    total += i;
                }

                Console.WriteLine("1 ile 200 arasındaki çift sayıların toplamı: " + total);
            }

            if (qNum == 8)
            {
                //Klavyeden girilecek X değerinden N değerine kadar tüm doğal sayıları listeleyen program
                Console.Write("Başlangıç değerini girin : ");
                int iValue = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bitiş değerini girin : ");
                int endValue = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Doğal sayılar " + iValue + " ile " + endValue + " arasında:");

                for (int i = iValue; i <= endValue; i++)
                {
                    Console.WriteLine(i);
                }
            }

            if (qNum == 9)
            {
                //Klavyeden girilen bir sayının tüm tam bölenlerini bulup ekrana yazan program

                Console.WriteLine("Bir sayı giriniz:");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num + " sayısının tam bölenleri:");

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            if (qNum == 10)
            {
                //1 ile 40 arasında bulunan 5 in katı olan sayıları ekrana yazan program

                Console.WriteLine("1 ile 40 arasındaki 5'in katı olan sayılar:");

                for (int i = 1; i <= 40; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            if (qNum == 11)
            {
                //Kullanıcıdan alınan iki sayı arasındaki asal sayıları bulan program
                Console.WriteLine("Bir sayı giriniz :");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bir sayı giriniz :");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int counter = 0, i;

                Console.WriteLine("Girdiğiniz sayılar arasında bulunan asal sayılar :");

                for (i = num1; i <= num2; i++)

                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                        }

                    }
                    if (counter == 0 && i != 1)
                    {
                        Console.WriteLine(i);
                    }

                    counter = 0;
                }

            }

            if (qNum == 12)
            {
                //Klavyeden girilen sayının 2′ye bölümünü bulan programı yapınız. (Not: Bölme / operatörünü kullanmadan yapılacak)

                Console.WriteLine("Bölünecek sayıyı giriniz :");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bölen sayıyı giriniz:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int section = 0;
                int rest = num1;

                while (rest >= num2)
                {
                    rest -= num2;
                    section++;
                }
                Console.WriteLine("Bölüm = " + section + " Kalan = " + rest);
            }

            if (qNum == 13)
            {
                //Kullanıcıdan bir sayı girmesi istenecek ve kullanıcı "Başka bir sayı girmek istiyor musunuz?" sorusuna hayır cevabını verene kadar sayı girmeye devam edecek. Kullanıcının girdiği sayıların ortalamasını bulan program.(Kullanıcı ilk sayıyı girerken Başka bir sayı girmek istiyor musunuz? sorusu sorulmamalı) 
                int sum = 0;
                int count = 0;
                string answer = "evet";

                while (answer == "evet" || answer == "Evet")
                {
                    Console.Write("Bir sayı girin: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    sum += number;
                    count++;

                    Console.Write("Başka bir sayı girmek istiyor musunuz? (Evet/Hayır): ");
                    answer = Console.ReadLine();
                }

                double average = (double)sum / count;
                Console.WriteLine("Girilen sayıların ortalaması: " + average);
            }

            if (qNum == 14)
            {
                //Klavyeden 0 girilene kadar girilmiş olan sayıların toplamını ekrana yazan program
                int total = 0;
                int number = 1;

                while (number != 0)
                {
                    Console.WriteLine("Bir sayı girin (Programı sonlandırmak ve girdiğniz sayıların toplamını elde etmek için 0'a basınız): ");
                    number = Convert.ToInt32(Console.ReadLine());

                    total += number;
                }

                Console.WriteLine("Girilen sayıların toplamı: " + total);
            }

            if (qNum == 15)
            {
                //Bir sayının palindrom olup olmadığını bulan program
                int total = 0;
                int i;
                int temp;
                Console.Write("Bir sayı giriniz :");
                int num = Convert.ToInt32(Console.ReadLine());

                for (i = num; num != 0; num = num / 10)
                {
                    temp = num % 10;
                    total = total * 10 + temp;
                }
                if (i == total)
                    Console.Write(i + " bir palindromik sayıdır");
                else
                    Console.Write(i + " bir palindromik sayı değildir");
            }

            if (qNum == 16)
            {
                //Girilen pozitif sayının kaç basamaklı olduğunu bulan program

                Console.Write("Bir sayi giriniz: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int counter = 0;
                while (num > 0)
                {
                    num /= 10;
                    counter++;
                }
                Console.WriteLine("Girdiginiz sayi " + counter + " basamaklıdır.");

                Console.ReadLine();

            }

            if (qNum == 17)
            {
                //Bir sayı belirleyin. Kullanıcıdan bu sayıyı tahmin etmesini isteyin. Kullanıcı sayıyı bulana kadar sormaya devam edin
                int targetNumber = 16;
                Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin.");

                int guess = 0;
                while (guess != targetNumber)
                {
                    Console.Write("Tahmininiz: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess < targetNumber)
                    {
                        Console.WriteLine("Daha büyük bir sayı deneyin.");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Daha küçük bir sayı deneyin.");
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler! Doğru sayıyı buldunuz.");
                    }
                }
            }

            if (qNum == 18)
            {
                int num;
                int exponent;
                int result = 1;


                Console.WriteLine("Sayıyı giriniz = ");
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ussu giriniz = ");
                exponent = Convert.ToInt32(Console.ReadLine());

                while (exponent > 0)
                {

                    result = result * num;

                    exponent--;
                }
                Console.WriteLine("Sonuç = " + result);
                Console.ReadKey();
            }

            if (qNum == 19)
            {
                //1-100 arasındaki asal sayıları bulup ekrana asal sayıları yazan ve kaç adet asal sayı olduğunu bulan program
                int counter = 0;

                for (int num = 2; num <= 100; num++)
                {
                    int check = 0;

                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            check = 1;
                            break;
                        }
                    }
                    if (check == 0)
                    {
                        Console.WriteLine(num + " asaldır.");
                        counter++;
                    }

                }

                Console.WriteLine(counter + " adet asal sayı var");
                Console.ReadKey();
            }

            if (qNum == 20)
            {
                //-Girilen bir sayının basamaklarında ki en büyük sayıyı bulan program
                Console.WriteLine("Bir sayı girin:");
                int num = Convert.ToInt32(Console.ReadLine());

                int maxDigit = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    if (digit > maxDigit)
                    {
                        maxDigit = digit;
                    }
                    num /= 10;
                }

                Console.WriteLine("En büyük basamak: " + maxDigit);
            }

            if (qNum == 21)
            {
                //Girilen 3 basamaklı bir sayının her bir basamağındaki sayının küplerinin toplamının sayının kendisine eşit olup olmadığını bulan program.
                Console.WriteLine("Üç basamaklı bir sayı girin:");

                int num = Convert.ToInt32(Console.ReadLine());

                int originalNumber = num;
                int cube = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    cube += digit * digit * digit;
                    num /= 10;
                }

                if (cube == originalNumber)
                {
                    Console.WriteLine("Girilen sayı Armstrong sayıdır.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı Armstrong sayı değildir.");
                }
            }

            if (qNum == 22)
            {
                //Kullanıcıdan bir dikdörtgenin kısa ve uzun kenar ölçüleri alınacak ve dikdörtgenin alan ve çevresi hesaplanacak. Kullanıcı herhangi bir değere 0 ve sıfırdan küçük değer girmediği müddetçe kullanıcıdan ölçü alınıp işlem yapılmaya devam edilecek
                while (true)
                {
                    Console.WriteLine("Dikdörtgenin kısa kenarını girin (Daha fazla hesaplama yapmak istemiyorsanız 0'a basınız):");
                    double shortSide = Convert.ToInt32(Console.ReadLine());

                    if (shortSide <= 0)
                    {
                        Console.WriteLine("Programdan çıkılıyor...");
                        break;
                    }

                    Console.WriteLine("Dikdörtgenin uzun kenarını girin:");
                    double longSide = Convert.ToInt32(Console.ReadLine());

                    double area = shortSide * longSide;
                    double perimeter = 2 * (shortSide + longSide);

                    Console.WriteLine("Dikdörtgenin alanı: " + area);
                    Console.WriteLine("Dikdörtgenin çevresi: " + perimeter);
                }
            }

            if (qNum == 23)
            {
                //Kullanıcının girdiği kelimenin yarısından sonrasını altsatıra bastıran program

                Console.WriteLine("Lütfen bir kelime girin:");
                string word = Console.ReadLine();

                int wordLength = word.Length;

                int halfWord = wordLength / 2;

                for (int i = 0; i < halfWord; i++)
                {
                    Console.Write(word[i]);
                }

                Console.WriteLine();

                for (int i = halfWord; i < wordLength; i++)
                {
                    Console.Write(word[i]);
                }


            }

            if (qNum == 24)
            {
                //0 ile 100 arasında 7'ye bölümünden kalanı 3 olan kaç tane sayı olduğunu bulan program
                int counter = 0;

                for (int i = 0; i <= 100; i++)
                {
                    if (i % 7 == 3)
                    {
                        counter++;
                    }
                }

                Console.WriteLine("0 ile 100 arasında 7'ye bölümünden kalanı 3 olan sayı adedi: " + counter);
            }

            if (qNum == 25)
            {
                //Kullanıcının girdiği sayıların toplamı 30'u geçtiği an işlemi durdurup sayıları ve kaç adet sayı girildiğini ekrana bastıran program
                int total = 0;
                int counter = 0;

                while (total <= 30)
                {
                    Console.Write("Bir sayı girin: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());

                    total += sayi;
                    counter++;
                }

                Console.WriteLine("Toplam: " + total);
                Console.WriteLine("Girilen sayı adedi: " + counter);
            }

            if (qNum == 26)
            {
                //Kullanıcının girdiği 10 adet sayıdan çift sayıların toplamının tek sayıların toplamına oranını bulan program
                int doubleTotal = 0;
                int oneTotal = 0;

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Bir sayı girin: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());

                    if (sayi % 2 == 0)
                    {
                        doubleTotal += sayi;
                    }
                    else
                    {
                        oneTotal += sayi;
                    }
                }

                if (oneTotal != 0)
                {
                    double rate = (double)doubleTotal / oneTotal;
                    Console.WriteLine("Çift sayıların toplamı tek sayıların toplamına oranı: " + rate);
                }
                else
                {
                    Console.WriteLine("Tek sayı girilmediği için oran hesaplanamıyor.");
                }
            }

            if (qNum == 27)
            {
                //Kullanıcıdan 2 adet sayı alın ve çıkarma işlemi yapın. İşlemin sonucu sıfırdan büyük ve çift ise 'Başarılı' yazsın.
                Console.Write("Birinci sayıyı girin: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("İkinci sayıyı girin: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int fark = num1 - num2;

                if (fark > 0 && fark % 2 == 0)
                {
                    Console.WriteLine("Başarılı");
                }

                else
                {
                    Console.WriteLine(fark + " İşlem Başarısız");
                }
            }

            if (qNum == 28)
            {
                //Klavyeden ardı ardına sayı girişi isteyen ve bu sayı 10 ile 15 arasında olmadığı sürece bu işleme devam eden program
                int num;

                Console.Write("Lütfen bir sayı girin: ");
                num = Convert.ToInt32(Console.ReadLine());

                while (num < 10 || num > 15)
                {
                    Console.WriteLine("Girilen sayı 10 ile 15 arasında değil.");
                    Console.Write("Lütfen tekrar bir sayı girin: ");
                    num = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Girilen sayı 10 ile 15 arasındadır.");
            }

            if (qNum == 29)
            {
                //Klavyeden bir not girilmesini isteyen ve bu not 0-49 arasındaysa “Başarısız”, 50-64 arasındaysa “Orta”, 65-84 arasındaysa “İyi”, 85-100 arasındaysa “Çok iyi “ Yazan program
                int point;

                Console.Write("Lütfen bir not girin: ");
                point = Convert.ToInt32(Console.ReadLine());

                if (point >= 0 && point <= 49)
                {
                    Console.WriteLine("Başarısız");
                }
                else if (point >= 50 && point <= 64)
                {
                    Console.WriteLine("Orta");
                }
                else if (point >= 65 && point <= 84)
                {
                    Console.WriteLine("İyi");
                }
                else if (point >= 85 && point <= 100)
                {
                    Console.WriteLine("Çok İyi");
                }
                else
                {
                    Console.WriteLine("Geçersiz not girişi");
                }
            }

            if (qNum == 30)
            {
                //Kullanıcıdan parola girmesini isteyin. Parolanın geçerli olabilmesi için ya 10 karakterden fazla olması ya da 8 karakterden fazla ve ilk karakterinin büyük bir harf olması 
                //Bu soruda algoritmayı kurmakta zorlandım internetten yardım aldım
                string password;

                Console.Write("Lütfen bir parola girin: ");
                password = Console.ReadLine();

                if (password.Length > 10 || (password.Length > 8 && (password[0] >= 'A' && password[0] <= 'Z')))
                {
                    Console.WriteLine("Parola kabul edildi.");
                }
                else
                {
                    Console.WriteLine("Parola kabul edilmedi.");
                }


            }

            if (qNum == 31)
            {
                //Kullanıcıdan hava durumu bilgisini (yağmurlu, güneşli, karlı vb.) alın. Eğer hava durumu yağmurlu ise veya karlı ise, "Şemsiyenizi veya kar botlarınızı almayı unutmayın!" mesajını verin.

                Console.Write("Lütfen hava durumu bilgisini girin : ");
                string weather = Console.ReadLine();

                if (weather == "yağmurlu" || weather == "karlı")
                {
                    Console.WriteLine("Şemsiyenizi veya kar botlarınızı almayı unutmayın!");
                }
                else 
                {
                    Console.WriteLine("Havanın tadını çıkarın...");
                }
            }

            if (qNum == 32)
            {
                //Bir işyerinde çalışanın aylık satışını alın. Eğer aylık satış 5000 TL'den fazla ise veya çalışanın toplam satışı 20000 TL'den fazla ise, çalışana bonus verilmesi gerektiğini belirtin.
                Console.WriteLine("Lütfen Aylık Kazancınızı Girin");
                int total = Convert.ToInt32(Console.ReadLine());

                if (total > 5000 || total > 20000)
                {
                    Console.WriteLine("Tebrikler Bonus Kazandınız...");
                }

                else
                {
                    Console.WriteLine("Bir daha ki sefere..");
                }
            }
        }
    }
}


