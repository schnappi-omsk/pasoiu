using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    interface IPoll
    {

        void AddQuestion(IQuestion question);

        void AddAlternative(IQuestion question, Alternative alternative);

        void AddAllAlternatives(IQuestion question, params Alternative[] allAlternatives);

        bool HasAlternatives(IQuestion question);

        bool HasAlternative(IQuestion question, Alternative alternative);

        IReadOnlyList<Alternative> GetAlternatives(IQuestion question);

        IReadOnlyList<IQuestion> GetQuestions();

        string QuestionString(IQuestion question);

    }
}
