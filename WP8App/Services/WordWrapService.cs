using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPAppStudio.Services
{
    public class WordWrapService
    {
        public string GetWords(string text, int wordCount)
        {

            StringBuilder result = new StringBuilder();

            for (int word = 0; word < wordCount; word++)
            {
                int space = text.IndexOf(' ', 1);
                //return text.Substring(0, space);
                result.Append(text.Substring(0, space));
                text = text.Substring(space);
            }

            return result.ToString();
        }
    }
}
