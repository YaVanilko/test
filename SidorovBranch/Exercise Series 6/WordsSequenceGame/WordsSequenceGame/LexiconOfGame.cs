using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WordsSequenceGame
{
    class LexiconOfGame
    {
        string[] dictNameArray;
        List<string> SequenceOfWords;

        public LexiconOfGame( string[] dictNameArray )
        {
            this.dictNameArray = dictNameArray;
            SequenceOfWords = new List<string>();
        }

        public bool AddWordInSequence(string word)
        {
            if (!SequenceOfWords.Contains(word) &&
                DictionarySet.SearchInSet(word, dictNameArray) &&
                word[0] == SequenceOfWords.Last<string>().Last<char>())
                SequenceOfWords.Add(word);
            else
                return false;
            return true;
        }

        public List<string> GetCarrentSequence()
        {
            if (SequenceOfWords.Count == 0)
            {
                Random rand = new Random();
                int randomIndex1 = rand.Next(0, dictNameArray.Length - 1);
                int randomIndex2 = rand.Next(0, DictionarySet.GetDictionary(
                    dictNameArray[randomIndex1]).Count - 1);
                
                SequenceOfWords.Add(DictionarySet.GetDictionary(
                    dictNameArray[randomIndex1])[randomIndex2]);
            }
            return SequenceOfWords;
        }

        public string[] GetNamesDictCollections()
        {
            return dictNameArray;
        }

        public void AddWordInUsersDict(string temp)
        {
            DictionarySet.GetDictionary(
                DictionarySet.path + "usersdictionary.txt").Add(temp);

            using (StreamWriter file = new StreamWriter(
                DictionarySet.path + "usersdictionary.txt", true,
                System.Text.Encoding.GetEncoding(1251)))
            {
                file.WriteLine(temp);
            }

        }
    }
}
