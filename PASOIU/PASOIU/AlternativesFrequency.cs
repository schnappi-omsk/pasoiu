using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Report
{
    class AlternativesFrequency
    {

        private List<Record> records = new List<Record>();

        private class Record
        {

            private string name;

            private string frequency;

            private string percentage;

            public string Name {
                get
                {
                    return this.name;
                }
                set 
                {
                    this.name = value;
                }
            }
            public string Frequency 
            { 
                get
                {
                    return this.frequency;
                }
                set
                {
                    this.frequency = value;
                }
            }
            public string Percentage 
            { 
                get
                {
                    return this.percentage;
                }
                set { 
                    this.percentage = String.Format("{0}%", value); 
                }  
            }
        }

        public void AddRecord(string name, int frequency, double percentage)
        {
            records.Add(new Record() { Name = name, Frequency = frequency.ToString(), Percentage = percentage.ToString() });
        }

        public List<Tuple<string, string, string>> GetRecords()
        {
            var result = new List<Tuple<string, string, string>>();
            foreach (Record record in records)
            {
                result.Add(new Tuple<string, string, string>(record.Name, record.Frequency, record.Percentage));
            }
            return result;
        }

    }
}
