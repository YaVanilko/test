using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WordsSequenceGame
{
    static class DictionarySet
    {   // путь к словарям
        public static string path = Directory.GetCurrentDirectory() + @"\dictionares\";
        // имена загружаемых словарей
        static string[] keyArray;
        /// <summary>
        /// Контейнер со всеми словами всех словарей
        /// </summary>
        static Dictionary<string, List<string> > FullDictionary;
        /// <summary>
        /// Статический конструктор класса
        /// </summary>
        static DictionarySet()
        {
            FullDictionary = new Dictionary< string, List<string> >();
            keyArray = Directory.GetFiles(path, "*.txt");
            for (int i = 0; i < keyArray.Length; ++i)
            {
                ReadFromFile(keyArray[i]);
            }
        }

        static void ReadFromFile(string name)
        {
            List<string> ListOfWords = new List<string>();

            using (StreamReader file = new StreamReader(new FileStream(name, FileMode.Open),
                System.Text.Encoding.GetEncoding(1251)))
            {
                while (file.Peek() >= 0)
                {
                    ListOfWords.Add(file.ReadLine());
                }
                FullDictionary.Add(name, ListOfWords);
            }
        }

        public static string[] GetNamesOfDicts()
        {
            return keyArray;
        }

        public static bool SearchInSet(string testStr, string[] dictNames)
        {
            foreach (string str in dictNames)
            {
                if (FullDictionary[str].Contains(testStr))
                    return true;
            }
            return false;
        }

        public static List<string> GetDictionary(string dictName)
        {
            return FullDictionary[dictName];
        }
    }
}
