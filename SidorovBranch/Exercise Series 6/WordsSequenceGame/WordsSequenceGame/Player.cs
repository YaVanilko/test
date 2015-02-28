using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordsSequenceGame
{
    /// <summary>
    /// Абстрактный класс Player содержит основные 
    /// методы присущие всем не конкретизированым игрокам 
    /// и является обобщением игроков
    /// </summary>
    
    abstract class Player
    {
        protected string name;
        protected LexiconOfGame lexicon;
        protected DialogInterface delg;

        public Player(string name, LexiconOfGame lexicon, DialogInterface delg)
        {
            this.name = name;
            this.lexicon = lexicon;
            this.delg = delg;
        }

        public string GetName()
        {
            return name;
        }

        public virtual void MakeMove(string str)
        {
            if (lexicon.GetCarrentSequence().Count == 1)
                delg(string.Format(
                    "\nLet us begin with word: \n{0}", lexicon.GetCarrentSequence().Last<string>()));
        }
    }
}
