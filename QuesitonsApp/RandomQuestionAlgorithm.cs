using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuesitonsApp
{
    public class RandomQuestionAlgorithm
    {
        public int QuestionNumber;
        public static void main()
        {
            FormAddQuestion Question = new FormAddQuestion(); //Son soru ID'sinin olduğu sınıftan instance alındı

            Random Random = new Random(); //Random sınıfından instance alındı

            for (int QuestionNumber = 1; QuestionNumber <= 10; QuestionNumber++) //10 soruluk bir sınav hazırlanacağı için fonksiyonu 10 kere çalıştıracak olan kod yazıldı 
            {
                  int QuestionRandom = Random.Next(0, Question.lastQuestId + 1); //Rastgele sorular seçmek üzere "QuestionRandom" değişkeni oluşturuldu
            }
        }
    }
}
