using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPAppStudio.Services.Interfaces;

namespace UnitTests.Fakes
{
    public class FakeTextMeasurementService : ITextMeasurementService
    {
        public int GetTextWidth(string text)
        {
            return text.Length * 10;
        }
    }
}
