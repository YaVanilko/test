using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordsSequenceGame
{
    class PlayerNPC: Player
    {
        /// <summary>
        ////Конструктор класса Бот-игрока
        /// </summary>
        /// <param name="name"> имя игрока </param>
        /// <param name="lexicon">лексикон созданной игры</param>
        /// <param name="delg">делегат</param>
        public PlayerNPC(string name, LexiconOfGame lexicon, DialogInterface delg) : 
            base(name, lexicon, delg) { }
        /// <summary>
        /// Совершение хода бот-игроком
        /// </summary>
        /// <param name="carrent">текущее слово к которому нужно дать пару</param>
        public override void MakeMove(string carrent)
        {
            // Инициализация и выбор слова при первом ходе
            base.MakeMove(carrent);

            // Буферная переменная
            string temp;

            for (int i = 0; i < lexicon.GetNamesDictCollections().Length; ++i)
            {
                for (int j = 0; j < DictionarySet.GetDictionary(
                    lexicon.GetNamesDictCollections()[i]).Count; ++j)
                {
                    temp = DictionarySet.GetDictionary(lexicon.GetNamesDictCollections()[i])[j];
                    if (lexicon.AddWordInSequence(temp))
                    {
                        delg(string.Format(
                            "\nPlayer {0} said: \n{1}", this.name, temp));
                        return;
                    }
                }
            }
            delg("End of dictionary. The last word: " + carrent);
        }
    }
}
