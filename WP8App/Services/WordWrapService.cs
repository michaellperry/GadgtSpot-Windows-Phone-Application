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
            int space = text.IndexOf(' ');
            return text.Substring(0, space);
        }
    }
}
