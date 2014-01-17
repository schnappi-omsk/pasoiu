using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Report
{
    class QuestionStatistics
    {

        private List<Record> records = new List<Record>();

        public class Record 
        {
            private string text;

            private double min;

            private double average;

            private double max;

            public string Text
            {
                get
                {
                    return this.text;
                }
                set 
                {
                    this.text = value;
                }
            }

            public double Min
            {
                get
                {
                    return this.min;
                }
                set
                {
                    this.min = value;
                }                        
            }

            public double Average
            {
                get
                {
                    return this.average;
                }
                set
                {
                    this.average = value;
                }
            }

            public double Max
            {
                get
                {
                    return this.max;
                }
                set
                {
                    this.max = value;
                }
            }

        }

        public void AddRecord(string text, double min, double average, double max)
        {
            records.Add( new Record() { Text = text, Min = min, Average = average, Max = max} );
        }

        public IReadOnlyList<Record> GetRecords()
        {
            return records.AsReadOnly();
        }

    }
}
