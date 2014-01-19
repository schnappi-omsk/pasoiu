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
                poll = dao.Read(pollName);
                ShowPoll();
            }
        }

        private void ShowPoll()
        {
            if (poll == null) return;
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
            foreach (var variant in poll.GetAlternatives(question))
            {
                RadioButton alternative = new RadioButton();
                alternative.Text = variant.Text;
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

    }
}
