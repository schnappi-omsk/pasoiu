using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DS;

namespace PASOIU
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            AllocConsole();
            Test();
        }

        static void Test() 
        {
            var pollDAO = new PollDAO();
            Poll poll = pollDAO.Read("test poll");//new Poll("test poll");

            Console.WriteLine(poll.ToString());

            //var q1 = new Question();
            //q1.Text = "your name?";
            //poll.AddQuestion(q1);

            //var q2 = new Question();
            //q2.Text = "Your age?";
            //poll.AddQuestion(q2);
            //Alternative less18 = new Alternative(q2, 1, "< 18");
            //Alternative less25 = new Alternative(q2, 2, "18 - 25");
            //Alternative less40 = new Alternative(q2, 3, "25-40");
            //Alternative more40 = new Alternative(q2, 4, " > 40");
            //poll.AddAllAlternatives(q2, less18, less25, less40, more40);

            //var q3 = new Question();
            //q3.Text = "Your position?";
            //poll.AddQuestion(q3);

            //var q4 = new Question();
            //q3.Text = "Salary, you want?";
            //poll.AddQuestion(q4);

            //var q5 = new Question();
            //q5.Text = "Have you satisfied with you work?";
            //poll.AddQuestion(q5);


            //PollResult result = new PollResult(poll);
            //result.AnswerTo(q1, "tst1");
            //result.SelectAlternative(q2, less40);
            //result.AnswerTo(q3, "40000");
            //result.AnswerTo(q4, "80000");
            //result.AnswerTo(q5, "yes");

            //PollResult result2 = new PollResult(poll);
            //result2.AnswerTo(q1, "tst1");
            //result2.SelectAlternative(q2, less40);
            //result2.AnswerTo(q3, "20000");
            //result2.AnswerTo(q4, "50000");
            //result2.AnswerTo(q5, "yes");

            //PollResult result3 = new PollResult(poll);
            //result3.AnswerTo(q1, "tst1");
            //result3.SelectAlternative(q2, more40);
            //result3.AnswerTo(q3, "45000");
            //result3.AnswerTo(q4, "70000");
            //result3.AnswerTo(q5, "no");

            //PollResult result4 = new PollResult(poll);
            //result4.AnswerTo(q1, "tst1");
            //result4.SelectAlternative(q2, less25);
            //result4.AnswerTo(q3, "30000");
            //result4.AnswerTo(q4, "40000");
            //result4.AnswerTo(q5, "no");

            //PollResult result5 = new PollResult(poll);
            //result5.AnswerTo(q1, "tst1");
            //result5.SelectAlternative(q2, less25);
            //result5.AnswerTo(q3, "30000");
            //result5.AnswerTo(q4, "50000");
            //result5.AnswerTo(q5, "yes");            

            //PollManager manager = new PollManager();
            //manager.AddAllResults(result, result2, result3, result4, result5);
            //var report = manager.AlternativesByQuestion(q2).GetRecords();

            //foreach (Tuple<string, string, string> record in report)
            //{
            //    Console.WriteLine(
            //        String.Format("{0}: {1}, {2}", record.Item1, record.Item2, record.Item3)
            //        );
            //}

            //IReadOnlyList<PollResult> results = manager.GetResults();
            //foreach (PollResult current in results)
            //{
            //    Dictionary<IQuestion, Alternative> ch = current.GetChoices();
            //    foreach (IQuestion q in ch.Keys)
            //    {
            //        Console.WriteLine(String.Format("{0} : {1}", q.Text, ch[q].Text));
            //    }
            //}

            //Console.WriteLine();

            //var stats = manager.StatsOf(q3);
            //var recs = stats.GetRecords();
            //foreach (var rec in recs)
            //{
            //    Console.WriteLine(String.Format("{0}\t{1}\t{2}\t{3}", rec.Text, rec.Min, rec.Average, rec.Max));
            //}

            Console.ReadKey();

        }

    }
}
