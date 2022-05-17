using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuesitonsApp
{
    public class SigmaSixAlgorithm
    {
        public static void StepOne()
        {
            bool FirstTimeTrue = false; //Bir sorunun ilk defa doğru yapılıp yapılmadığını denetler
            int FirstTimeDayInterval = 1; //İlk zaman aralığını bir gün olmak üzere ayarlar

            //if(CorrectAnswer == Answer)
            //{
                DateTime InitialTime = DateTime.Now; //Başlangıç zamanını veritabanına kaydetmek üzere "InitialTime" değişkenine eşitler
                FirstTimeTrue = true;
            //}

            //Üst üste bir defa doğru işaretlenen soruların tutulduğu veritabanı kodu buraya yazılacak
        }

        public static void StepTwo(bool FirstTimeTrue)
        {
            if (FirstTimeTrue == true /* && InitialTime + FirstTimeDayInterval == DateTime.Now) */)
            {
                bool SecondTimeTrue = false; //Bir sorunun ikinci defa üst üste doğru yapılıp yapılmadığını denetler
                int SecondTimeWeekInterval = 1; //İkinci zaman aralığını 1 hafta olmak üzere ayarlar

                //Veritabanından soruyu forma yazdıracak kod buraya yazılacak

                //if(CorrectAnswer == Answer)
                //{
                    SecondTimeTrue = true;
                    //Üst üste iki defa doğru işaretlenen soruların tutulduğu veritabanı kodu buraya yazılacak
                //}
                //else 
                //{
                    //Sorunun başa geri döndürüldüğü (algoritma veritabanından çıkartıldığı) kod buraya yazılmalı
                //}

                FirstTimeTrue = false; //Bool tipindeki değişken bir daha kullanılabilmek üzere sıfırlandı
            }
        }

        public static void StepThree(bool SecondTimeTrue)
        {
            if (SecondTimeTrue == true /* && InitialTime + SecondTimeWeekInterval == DateTime.Now) */)
            {
                bool ThirdTimeTrue = false; //Bir sorunun ikinci defa üst üste doğru yapılıp yapılmadığını denetler
                int ThirdTimeMonthInterval = 3; //İkinci zaman aralığını 3 ay olmak üzere ayarlar

                //Veritabanından soruyu forma yazdıracak kod buraya yazılacak

                //if(CorrectAnswer == Answer)
                //{
                    ThirdTimeTrue = true;
                    //Üst üste üç defa doğru işaretlenen soruların tutulduğu veritabanı kodu buraya yazılacak
                //}
                //else 
                //{
                    //Sorunun başa geri döndürüldüğü (algoritma veritabanından çıkartıldığı) kod buraya yazılmalı
                //}

                SecondTimeTrue = false; //Bool tipindeki değişken bir daha kullanılabilmek üzere sıfırlandı
            }
        }

        public static void StepFour(bool ThirdTimeTrue)
        {
            if (ThirdTimeTrue == true /* && InitialTime + ThirdTimeMonthInterval == DateTime.Now) */)
            {
                bool FourthTimeTrue = false; //Bir sorunun ikinci defa üst üste doğru yapılıp yapılmadığını denetler
                int FourthTimeMonthInterval = 6; //İkinci zaman aralığını 6 ay olmak üzere ayarlar

                //Veritabanından soruyu forma yazdıracak kod buraya yazılacak

                //if(CorrectAnswer == Answer)
                //{
                    FourthTimeTrue = true;
                    //Üst üste dört defa doğru işaretlenen soruların tutulduğu veritabanı kodu buraya yazılacak
                //}
                //else 
                //{
                    //Sorunun başa geri döndürüldüğü (algoritma veritabanından çıkartıldığı) kod buraya yazılmalı
                //}

                ThirdTimeTrue = false; //Bool tipindeki değişken bir daha kullanılabilmek üzere sıfırlandı
            }
        }

        public static void StepFive(bool FourthTimeTrue)
        {
            if (FourthTimeTrue == true /* && InitialTime + FourthTimeMonthInterval == DateTime.Now) */)
            {
                bool FifthTimeTrue = false; //Bir sorunun ikinci defa üst üste doğru yapılıp yapılmadığını denetler
                int FifthTimeYearInterval = 1; //İkinci zaman aralığını 1 yıl olmak üzere ayarlar

                //Veritabanından soruyu forma yazdıracak kod buraya yazılacak

                //if(CorrectAnswer == Answer)
                //{
                    FifthTimeTrue = true;
                    //Üst üste beş defa doğru işaretlenen soruların tutulduğu veritabanı kodu buraya yazılacak
                //}
                //else 
                //{
                    //Sorunun başa geri döndürüldüğü (algoritma veritabanından çıkartıldığı) kod buraya yazılmalı
                //}

                FourthTimeTrue = false; //Bool tipindeki değişken bir daha kullanılabilmek üzere sıfırlandı
            }
        }

        public static void StepSix(bool FifthTimeTrue)
        {
            if (FifthTimeTrue == true /* && InitialTime + FifthTimeYearInterval == DateTime.Now) */)
            {
                //Bir sorunun altıncı defa üst üste doğru yapılıp yapılmadığını denetler
                //Altı kere üst üste doğru cevaplanan sorunun sistemden çıkartılmasını sağlar

                //Veritabanından soruyu forma yazdıracak kod buraya yazılacak

                //if(CorrectAnswer == Answer)
                //{
                    //Buraya gelmiş soruları bir daha sorulmamak üzere veritabanından çıkartacak kod buraya yazılacak
                //}
                //else 
                //{
                    //Sorunun başa geri döndürüldüğü (algoritma veritabanından çıkartıldığı) kod buraya yazılmalı
                    FifthTimeTrue = false; //Bool tipindeki değişken bir daha kullanılabilmek üzere sıfırlanacak
                //}
            }
        }
    }
}
