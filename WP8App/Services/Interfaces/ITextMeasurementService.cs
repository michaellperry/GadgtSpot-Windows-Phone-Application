using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPAppStudio.Services.Interfaces
{
    public interface ITextMeasurementService
    {
        int GetTextWidth(string text);
    }
}
