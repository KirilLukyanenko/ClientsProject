using System;
using System.Collections.Generic;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    public class PriceEventArgs : EventArgs
    {
        public PriceEventArgs(string filePath, object source)
        {
            FilePath = filePath;

            Models = source as List<PriceModel>;
        }

        public string FilePath { get; private set; }
        public List<PriceModel> Models { get; private set; }
    }
}
