using System;

public class SimpleMathExam : Exam
{
    public int ProblemsSolved { get; private set; }

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0)
        {
            problemsSolved = 0;
        }

        if (problemsSolved > 10)
        {
            problemsSolved = 10;
        }

        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Sorry, but you failed! You can't solved any task. May be next time.");
        }
        else if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "You solved only one task.");
        }
        else if (this.ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Great! You solved and both task, you have excelent result.");
        }
        else
        {
            throw new ArgumentException("Incorrect result.");
        }
    }
}
