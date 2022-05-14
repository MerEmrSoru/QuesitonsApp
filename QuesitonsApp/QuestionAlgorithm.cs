using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuesitonsApp
{
    public class QuestionAlgorithm
    {
        static void main()
        {
            QuestionCounter Counter = new QuestionCounter(); //"QuestionCount" değerini kullanmak üzere "QuestionCounter" sınıfından instance alındı

            Random Random = new Random();
            int QuestionRandom = Random.Next(0, Counter.QuestionCount + 1); //Rastgele sorular seçmek üzere "QuestionRandom" değişkeni oluşturuldu
        }
    }
}
