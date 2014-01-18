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

            //var poll = new Poll("e");

            //var q1 = new Question();
            //q1.Text = "your name?";
            //poll.AddQuestion(q1);

            //var q2 = new Question();
            //q2.Text = "Your age?";
            //poll.AddQuestion(q2);
            //Alternative less18 = new Alternative(1, "< 18");
            //Alternative less25 = new Alternative(2, "18 - 25");
            //Alternative less40 = new Alternative(3, "25-40");
            //Alternative more40 = new Alternative(4, " > 40");
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

            //pollDAO.Update(poll);

            PollResultDAO resultDao = new PollResultDAO();            

            PollResult result = new PollResult(poll);
            result.AnswerTo(poll.GetQuestions()[0], "tst1");
            result.SelectAlternative(poll.GetQuestions()[1], poll.GetAlternatives(poll.GetQuestions()[1])[2]);
            result.AnswerTo(poll.GetQuestions()[2], "40000");
            result.AnswerTo(poll.GetQuestions()[3], "80000");
            result.AnswerTo(poll.GetQuestions()[4], "yes");

            resultDao.Create(result);

            PollResult result2 = new PollResult(poll);
            result2.AnswerTo(poll.GetQuestions()[0], "tst1");
            result2.SelectAlternative(poll.GetQuestions()[1], poll.GetAlternatives(poll.GetQuestions()[1])[1]);
            result2.AnswerTo(poll.GetQuestions()[2], "20000");
            result2.AnswerTo(poll.GetQuestions()[3], "50000");
            result2.AnswerTo(poll.GetQuestions()[4], "yes");

            resultDao.Create(result2);
            
            PollResult result3 = new PollResult(poll);
            result3.AnswerTo(poll.GetQuestions()[0], "tst1");
            result3.SelectAlternative(poll.GetQuestions()[1], poll.GetAlternatives(poll.GetQuestions()[1])[1]);
            result3.AnswerTo(poll.GetQuestions()[2], "45000");
            result3.AnswerTo(poll.GetQuestions()[3], "70000");
            result3.AnswerTo(poll.GetQuestions()[4], "no");

            resultDao.Create(result3);

            PollResult result4 = new PollResult(poll);
            result4.AnswerTo(poll.GetQuestions()[0], "tst1");
            result4.SelectAlternative(poll.GetQuestions()[1], poll.GetAlternatives(poll.GetQuestions()[1])[3]);
            result4.AnswerTo(poll.GetQuestions()[2], "30000");
            result4.AnswerTo(poll.GetQuestions()[3], "40000");
            result4.AnswerTo(poll.GetQuestions()[4], "no");

            resultDao.Create(result4);

            PollResult result5 = new PollResult(poll);
            result5.AnswerTo(poll.GetQuestions()[0], "tst1");
            result5.SelectAlternative(poll.GetQuestions()[1], poll.GetAlternatives(poll.GetQuestions()[1])[0]);
            result5.AnswerTo(poll.GetQuestions()[2], "30000");
            result5.AnswerTo(poll.GetQuestions()[3], "50000");
            result5.AnswerTo(poll.GetQuestions()[4], "yes");

            //resultDao.Create(result5);

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
