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
    public partial class InsertPoll : Form
    {

        private Poll poll = new Poll("");

        public InsertPoll()
        {
            InitializeComponent();
            SetControlsState();
        }

        private void insertQuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetControlsState();
        }

        private void SetControlsState()
        {
            bool withAlternatives = insertQuestionList.SelectedIndex == 1;
            addAlternativeField.Enabled = withAlternatives;
            addAlternativeBtn.Enabled = withAlternatives;
            alternativesList.Enabled = withAlternatives;
            removeAlternativeBtn.Enabled = withAlternatives;
        }

        private void pollNameField_TextChanged(object sender, EventArgs e)
        {
            poll.Name = pollNameField.Text;
        }

        private void saveQuestionBtn_Click(object sender, EventArgs e)
        {
            if (questionTextField.Text.Length > 0)
            {
                Question question = new Question();
                question.Text = questionTextField.Text;                
                if (insertQuestionList.SelectedIndex == 1)
                {
                    if (alternativesList.Items.Count < 2)
                    {
                        string errorText = "Добавьте, как минимум, 2 альтернативы";
                        string caption = "Ошибка при сохранении вопроса";
                        var buttons = MessageBoxButtons.OK;
                        var icon = MessageBoxIcon.Error;
                        MessageBox.Show(errorText, caption, buttons, icon);
                    }
                    for (int i = 0; i < alternativesList.Items.Count; i++)
                    {
                        var alternative = new Alternative(i + 1, (string) alternativesList.Items[i]);
                        poll.AddAlternative(question, alternative);
                    }
                }
                poll.AddQuestion(question);
                clearQuestionFields();
            }
        }

        private void clearQuestionFields()
        {
            alternativesList.Items.Clear();
            addAlternativeField.Clear();
            questionTextField.Clear();
        }

        private void savePoll_Click(object sender, EventArgs e)
        {
            var dao = new PollDAO();
            dao.Create(poll);
            Close();
        }

        private void addAlternativeBtn_Click(object sender, EventArgs e)
        {
            if (addAlternativeField.Text.Length > 0)
            {
                alternativesList.Items.Add(addAlternativeField.Text);
                addAlternativeField.Clear();
            }
            else
            {
                string errorText = "Заполните текст альтернативы";
                string caption = "Ошибка при добавлении альтернативы";
                var buttons = MessageBoxButtons.OK;
                var icon = MessageBoxIcon.Error;
                MessageBox.Show(errorText, caption, buttons, icon);

            }
        }

    }
}
