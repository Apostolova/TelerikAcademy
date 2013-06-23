using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private string comments;

    public int MaxGrade { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("Max grade must be bigger than min grade.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Grade can't be negative number.");
            }

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("MinGrade can't be negative number.");
            }

            this.minGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentNullException("Comment is null or empty.");
            }

            this.comments = value;
        }
    }
}
