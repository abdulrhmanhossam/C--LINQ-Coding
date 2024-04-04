
using Shared;

//RunMethod01();
//RunMethod02();
//RunMethod03();
RunMethod04();

Console.ReadKey();

static void RunMethod01()
{
    var quiz01 = QuestionBank.Randomize(3);
    var quiz02 = QuestionBank.Randomize(2);

    var quiz03 = quiz01.Concat(quiz02);
    quiz03.ToQuiz();
}

static void RunMethod02()
{
    var quiz01 = QuestionBank.Randomize(3);
    var quiz02 = QuestionBank.Randomize(2);

    var questionTitle = quiz01.Select(q => q.Title).Concat(quiz02.Select(q => q.Title));
    foreach (var q in questionTitle)
    {
        Console.WriteLine(q);
    }
}

static void RunMethod03()
{
    var quiz01 = QuestionBank.Randomize(3);
    var quiz02 = QuestionBank.Randomize(2);
    var quiz03 = QuestionBank.GetQuestionRange(Enumerable.Range(11, 14));

    var questionTitle = quiz01.Select(q => q.Title)
        .Concat(quiz02.Select(q => q.Title))
        .Concat(quiz03.Select(q => q.Title));

    foreach (var q in questionTitle)
    {
        Console.WriteLine(q);
    }
}

static void RunMethod04()
{
    var quiz01 = QuestionBank.Randomize(3);
    var quiz02 = QuestionBank.Randomize(2);

    var quiz03 = new[] { quiz01, quiz02 }.SelectMany(q => q.Select(q => q.Title));

    foreach (var q in quiz03)
    {
        Console.WriteLine(q);
    }
}