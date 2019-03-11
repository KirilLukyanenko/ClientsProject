using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2.Service
{
    public class ExportCSV
    {
        private string path;
        private List<PriceModel> models;
        public ExportCSV(string path, List<PriceModel> models)
        {
            this.path = path;
            this.models = models;

            SaveModelsToCSV();
        }

        public string WarningMessage { get; private set; }

        private void SaveModelsToCSV()
        {
            var csv = new StringBuilder();

            foreach (var value in models)
            {
                var newLine = string.Format("{0},{1},{2},{3},{4},{5}",
                    value.Id, value.Promotion, value.Product,
                    value.RealPrice, value.Discount, value.DiscountPrice);

                csv.AppendLine(newLine);
            }

            try
            {
                File.WriteAllText(path, csv.ToString());
            }
            catch (Exception ex)
            {
                WarningMessage = ex.Message;
            }
        }
    }
}
