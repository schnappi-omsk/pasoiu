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
using DS;

namespace PASOIU
{
    public partial class PollForm : Form
    {
        private Poll poll;

        private PollDAO dao = new PollDAO();

        private Dictionary<Alternative, RadioButton> buttons = new Dictionary<Alternative, RadioButton>();

        private Dictionary<IQuestion, TextBox> textboxes = new Dictionary<IQuestion, TextBox>();

        private int vertical = 10;

        private int horizontal = 30;

        private void FillList()
        {
            var polls = dao.GetAll();
            foreach (var poll in polls)
            {
                pollNameList.Items.Add(poll.Name);
            }
        }

        public PollForm()
        {
            InitializeComponent();
            FillList();
        }

        private void selectPollButton_Click(object sender, EventArgs e)
        {
            var pollName = pollNameList.Text;
            if (pollName.Length > 0)
            {
                pollPanel.Controls.Clear();
                buttons.Clear();
                textboxes.Clear();
                poll = dao.Read(pollName);
                ShowPoll();
            }
        }

        private void ShowPoll()
        {
            if (poll == null) return;
            buttons.Clear();
            textboxes.Clear();
            vertical = 10;
            foreach (var question in poll.GetQuestions())
            {
                if (poll.HasAlternatives(question))
                {
                    DrawClosedQuestion(question);
                }
                else
                {
                    DrawOpenQuestion(question);
                }
            }
        }

        private void DrawDivider() 
        {
            Label divider = new Label();
            divider.Text = "";
            divider.BorderStyle = BorderStyle.Fixed3D;
            divider.AutoSize = false;
            divider.Height = 2;
            divider.Location = new Point(horizontal, vertical);
            divider.Width = pollPanel.Width - 2 * horizontal;
            vertical += 10;
            pollPanel.Controls.Add(divider);
        }

        private void DrawOpenQuestion(IQuestion question)
        {
            Label text = new Label();
            text.Text = question.Text;
            text.Location = new Point(horizontal, vertical);
            text.Width = pollPanel.Width - 2 * horizontal;
            pollPanel.Controls.Add(text);

            vertical += text.Height + 2;

            TextBox answerField = new TextBox();
            textboxes.Add(question, answerField);
            answerField.Location = new Point(horizontal, vertical);
            pollPanel.Controls.Add(answerField);

            vertical += text.Height + 10;

            DrawDivider();

        }

        private void DrawClosedQuestion(IQuestion question)
        {
            Label text = new Label();
            text.Text = question.Text;
            text.Location = new Point(horizontal, vertical);
            text.Width = pollPanel.Width - 2 * horizontal;
            pollPanel.Controls.Add(text);

            vertical += text.Height + 2;

            GroupBox variants = new GroupBox();
            variants.Location = new Point(horizontal, vertical);
            variants.FlatStyle = FlatStyle.Flat;
            int x = 5;
            int y = 5;
            int count = poll.GetAlternatives(question).Count;
            int heightSum = 0;
            bool selected = false;
            foreach (var variant in poll.GetAlternatives(question))
            {
                RadioButton alternative = new RadioButton();
                if (!selected)
                {
                    alternative.Checked = true;
                    selected = true;
                }
                alternative.Text = variant.Text;                
                buttons.Add(variant, alternative);
                alternative.Location = new Point(x, y);
                variants.Controls.Add(alternative);
                y += alternative.Height + 5;
                heightSum += alternative.Height + 5;
            }
            variants.Height = heightSum;
            pollPanel.Controls.Add(variants);
            vertical += variants.Height + 10;

            DrawDivider();
            
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (poll == null) return;
            var resultDao = new PollResultDAO();
            var result = new PollResult(poll);
            foreach (var current in textboxes.Keys)
            {
                result.AnswerTo(current, textboxes[current].Text);
            }
            foreach (var current in buttons.Keys)
            {
                if (buttons[current].Checked)
                {
                    result.SelectAlternative(current.Question, current);
                }
            }
            resultDao.Create(result);
            vertical = 10;
            pollPanel.Controls.Clear();
        }

        private void printPoll_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var g = e.Graphics;
            var pollStr = poll.ToString();
            Font pollFont = new Font("Arial", 16, System.Drawing.GraphicsUnit.Point);
            g.DrawString(pollStr, pollFont, Brushes.Black, 30, 30);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            previewPoll.ShowDialog();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (poll != null) dao.Delete(poll);
        }

    }
}
