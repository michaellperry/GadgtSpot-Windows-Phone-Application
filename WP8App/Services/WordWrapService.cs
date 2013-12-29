using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPAppStudio.Services.Interfaces;

namespace WPAppStudio.Services
{
    public class WordWrapService
    {
        private readonly ITextMeasurementService _tms;

        public WordWrapService(ITextMeasurementService textMeasurementService)
        {
            _tms = textMeasurementService;
        }

        public string GetWords(string text, int wordCount)
        {

            StringBuilder result = new StringBuilder();

            for (int word = 0; word < wordCount; word++)
            {
                int space = text.IndexOf(' ', 1);
                //return text.Substring(0, space);
                if (space == -1)
                {
                    result.Append(text);
                    return result.ToString();
                }
                result.Append(text.Substring(0, space));
                text = text.Substring(space);
                
            }

            return result.ToString();
        }

        public string GetLine(string text, int lineLength)
        {
            string line = GetWords(text, 2);

            int width = _tms.GetTextWidth(line);

            if (width <= lineLength)
            {
                return line;
            }

            return GetWords(text, 1);
        }
    }
}
