using Shared;


RunMethod01();
RunMethod02();
RunMethod03();

Console.ReadKey();


static void RunMethod01()
{
    var q01 = QuestionBank.PickOne();
    var q02 = QuestionBank.PickOne();
    var q03 = QuestionBank.PickOne();

    var quiz01 = new List<Question>(new[] { q01, q02, q03 });
    var quiz02 = new List<Question>(new[] { q01, q02, q03 });

    var equal = quiz01.SequenceEqual(quiz02);
    Console.WriteLine($"quiz01 and quiz02 {(equal ? "are" : "not")} Equal");

}

static void RunMethod02()
{
    var randomFourQuestion =
        QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));

    var quiz01 = randomFourQuestion;
    var quiz02 = randomFourQuestion;

    var equal = quiz01.SequenceEqual(quiz02);
    Console.WriteLine($"quiz01 and quiz02 {(equal ? "are" : "not")} Equal");

}

static void RunMethod03()
{
    var quiz01 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));
    var quiz02 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));

    var equal = quiz01.SequenceEqual(quiz02);
    Console.WriteLine($"quiz01 and quiz02 {(equal ? "are" : "not")} Equal");
}
