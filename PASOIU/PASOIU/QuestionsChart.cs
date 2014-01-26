using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Domain.Report;
using DS;
using System.Windows.Forms.DataVisualization.Charting;

namespace PASOIU
{
    public partial class QuestionsChart : Form
    {

        private Poll poll;

        private Dictionary<int, IQuestion> questions = new Dictionary<int, IQuestion>();

        public QuestionsChart()
        {
            InitializeComponent();
            initPollList();
        }

        private void initPollList()
        {
            var dao = new PollDAO();
            var list = dao.GetAll();
            foreach (var poll in list)
            {
                pollNameCombo.Items.Add(poll.Name);
            }
        }

        private void initQuestionsList()
        {
            questionList.Items.Clear();
            questionList.Text = "";
            var pollName = pollNameCombo.Text;
            if (pollName.Length > 0)
            {

                var dao = new PollDAO();
                poll = dao.Read(pollName);
                if (poll != null)
                {
                    questions.Clear();
                    var pollQuestions = poll.GetQuestions();
                    foreach (var question in pollQuestions)
                    {
                        if (poll.HasAlternatives(question))
                        {
                            questions.Add(question.Id, question);
                            questionList.Items.Add(question.Text);
                        }
                    }
                }
            }
        }

        private void pollNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            initQuestionsList();
        }

        private void questionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillChart();
        }

        private void fillChart()
        {
            
            var questionText = questionList.Text;            
            alternativesChart.Series.Clear();
            foreach (var question in questions.Values)
            {
                if (questionText == question.Text)
                {
                    var resultDao = new PollResultDAO();
                    var results = resultDao.AllByPoll(poll);
                    var manager = new PollManager();                    
                    manager.AddAllResults(results.ToArray());
                    var report = manager.AlternativesByQuestion(question).GetRecords();
                    foreach (var record in report)
                    {
                        var val = 0.0;
                        Series series = alternativesChart.Series.Add(record.Item1);
                        var result = Double.TryParse(record.Item2, out val) ? val : 0.0;
                        series.Points.Add(result);                        
                    }
                    
                    break;
                }
            }
        }

    }
}
