using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordsSequenceGame
{
    class PlayerHuman: Player
    {
        string temp;

        public PlayerHuman(string name, LexiconOfGame lexicon, DialogInterface delg) :
            base(name, lexicon, delg) { }

        public override void MakeMove(string carrent)
        {
            base.MakeMove(carrent);

            temp = delg(string.Format("\nPlayer {0} said: ", this.name));

            if (!lexicon.AddWordInSequence(temp))
            {
                if (delg("Do you want to add the word in additional dictionary? y / n") == "y")
                {
                    lexicon.AddWordInUsersDict(temp);

                    if (!lexicon.AddWordInSequence(temp))
                    {
                        delg("Follow the rules!!! You miss the move...");
                        return;
                    }
                    return;
                }
                delg("You miss the move...");
            }
        }
    }
}
