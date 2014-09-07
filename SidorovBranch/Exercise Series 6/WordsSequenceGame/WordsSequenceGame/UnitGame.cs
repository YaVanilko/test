using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordsSequenceGame
{
    class UnitGame
    {
        // Список игроков учасников
        List<Player> PlayersList;
        // "лексикон" игры в слова (набор словарей и т.д.)
        LexiconOfGame IndividualLexicon;
        // Ссылка на метод ввода-вывода
        DialogInterface delg;

        /// <summary>
        /// Конструктор UnitGame инициализирует новую игру, принимаю
        /// ссылку на функцию ввода-вывода
        /// </summary>
        /// <param name="delg"></param>
        public UnitGame(DialogInterface delg)
        {
            // Ссылка на функцию ввода-вывода
            this.delg = delg;

            int humanNumber = 
                int.Parse(delg("\nNumber of Human-type player "));

            int npcNumber =
                int.Parse(delg("\nNumber of Non Human-type player "));

            // Создание лексикона игры
            string[] choisenDicts = DictionarySet.GetNamesOfDicts();
            List<string> tmpList = new List<string>();
            foreach (string str in choisenDicts)
            {
                if (delg("Do you want to add the dictionary? (y / no- anything) \n" + str) == "y")
                    tmpList.Add(str);
                else
                    delg("The dictionary was not added.");
            }
            IndividualLexicon = new LexiconOfGame(tmpList.ToArray());

            #region 
            // Создание списка игроков
            PlayersList = new List<Player>(humanNumber + npcNumber);
            
            for (int i = 0; i < npcNumber; ++i)
            {
                PlayersList.Add(new PlayerNPC(string.Format("Comp_{0}", i + 1), 
                    IndividualLexicon,
                    delg));
            }
            for (int i = 0; i < humanNumber; ++i)
            {
                PlayersList.Add(new PlayerHuman(
                    delg(string.Format("The name of Human playe number {0} is ...\n", i + 1)),
                    IndividualLexicon,
                    delg));
            }
            #endregion 

            // розыгрыш порядка ходов участников
            ShaffeldOfList(PlayersList);
            delg("\nTurns queue of players: ");
            for (int i = 0; i < PlayersList.Count; ++i)
            {
                delg(string.Format("{0} => {1} ", i + 1, PlayersList[i].GetName()));
            }

            // Цыкл игры
            do
            {
                for (int i = 0; i < PlayersList.Count; ++i)
                {
                    PlayersList[i].MakeMove(
                        IndividualLexicon.GetCarrentSequence().Last<string>());
                }

            } while (delg("Do you want to continue? (y / no- anything) ") == "y");

            delg("---------- Game Over! ----------");
        }

        // Функция тасования очередности игроков
        void ShaffeldOfList(List<Player> someList)
        {
            Random rand = new Random();
            int temp;
            for (int i = 0; i < someList.Count; ++i)
            {
                temp = rand.Next(0, someList.Count - 1);
                someList.Add(someList[temp]);
                someList.RemoveAt(temp);
            }
        }
    }
}
