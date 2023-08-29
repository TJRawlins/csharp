
using BootcampDb.Models;
using Microsoft.EntityFrameworkCore;

var _context = new BootcampContext();

/**-*-*-*-*-*-*-*-* ADD STUDENTS *-*-*-*-*-*-*-*-*-**/
/*
var newStudent = new Student()
{
    Name = "Tony Rawlins",
    Email = "trawlins@gmail.com",
    Phone = "123-456-7891"
};

var newStudent2 = new Student()
{
    Name = "Joe Blow",
    Email = "jblow@lacontent.com",
    Phone = "468-687-1895"
};
var newStudent3 = new Student()
{
    Name = "Jane Doe",
    Email = "jdoe@gmail.com",
    Phone = "789-468-7894"
};

_context.Students.Add(newStudent);
_context.Students.Add(newStudent2);
_context.Students.Add(newStudent3);
_context.SaveChanges();
*/

/**-*-*-*-*-*-*-*-* ADD ASSESSMENTS *-*-*-*-*-*-*-*-*-**/
/*
var newAssessment = new Assessment()
{
    Topic = "Git"
};
var newAssessment2 = new Assessment()
{
    Topic = "SQL"
};
var newAssessment3 = new Assessment()
{
    Topic = "CSharp"
};
var newAssessment4 = new Assessment()
{
    Topic = "HtmlCssJs"
};
var newAssessment5 = new Assessment()
{
    Topic = "Angular"
};

_context.Assessments.Add(newAssessment);
_context.Assessments.Add(newAssessment2);
_context.Assessments.Add(newAssessment3);
_context.Assessments.Add(newAssessment4);
_context.Assessments.Add(newAssessment5);
_context.SaveChanges();
*/

/**-*-*-*-*-*-*-*-* ADD SCORES *-*-*-*-*-*-*-*-*-**/
/*
// STUDENT 1
var newScoreGit = new Score()
{
    Points = 110,
    StudentId = 1,
    AssessmentId = 1
};
var newScoreSql = new Score()
{
    Points = 100,
    StudentId = 1,
    AssessmentId = 2
};
var newScoreCsharp = new Score()
{
    Points = 110,
    StudentId = 1,
    AssessmentId = 3
};
var newScoreHtmlCssJs = new Score()
{
    Points = 100,
    StudentId = 1,
    AssessmentId = 4
};
var newScoreAngular = new Score()
{
    Points = 110,
    StudentId = 1,
    AssessmentId = 5
};
_context.Scores.Add(newScoreGit);
_context.Scores.Add(newScoreSql);
_context.Scores.Add(newScoreCsharp);
_context.Scores.Add(newScoreHtmlCssJs);
_context.Scores.Add(newScoreAngular);
// STUDENT 2
var newScoreGit2 = new Score()
{
    Points = 80,
    StudentId = 2,
    AssessmentId = 1
};
var newScoreSql2 = new Score()
{
    Points = 100,
    StudentId = 2,
    AssessmentId = 2
};
var newScoreCsharp2 = new Score()
{
    Points = 90,
    StudentId = 2,
    AssessmentId = 3
};
var newScoreHtmlCssJs2 = new Score()
{
    Points = 110,
    StudentId = 2,
    AssessmentId = 4
};
var newScoreAngular2 = new Score()
{
    Points = 100,
    StudentId = 2,
    AssessmentId = 5
};
_context.Scores.Add(newScoreGit2);
_context.Scores.Add(newScoreSql2);
_context.Scores.Add(newScoreCsharp2);
_context.Scores.Add(newScoreHtmlCssJs2);
_context.Scores.Add(newScoreAngular2);
// STUDENT 3
var newScoreGit3 = new Score()
{
    Points = 110,
    StudentId = 3,
    AssessmentId = 1
};
var newScoreSql3 = new Score()
{
    Points = 70,
    StudentId = 3,
    AssessmentId = 2
};
var newScoreCsharp3 = new Score()
{
    Points = 100,
    StudentId = 3,
    AssessmentId = 3
};
var newScoreHtmlCssJs3 = new Score()
{
    Points = 100,
    StudentId = 3,
    AssessmentId = 4
};
var newScoreAngular3 = new Score()
{
    Points = 80,
    StudentId = 3,
    AssessmentId = 5
};
_context.Scores.Add(newScoreGit3);
_context.Scores.Add(newScoreSql3);
_context.Scores.Add(newScoreCsharp3);
_context.Scores.Add(newScoreHtmlCssJs3);
_context.Scores.Add(newScoreAngular3);

_context.SaveChanges();
*/
/**-*-*-*-*-*-*-*-* JOIN TABLES *-*-*-*-*-*-*-*-*-**/
var scores = from s in _context.Students
             join sc in _context.Scores
                on s.Id equals sc.StudentId
             join a in _context.Assessments
                on sc.AssessmentId equals a.Id
             select new 
             { 
                Student = s.Name,
                Assessment = a.Topic,
                sc.Points
             };

foreach (var score in scores)
{
    Console.WriteLine($"{score.Student} | {score.Assessment} | {score.Points}");
}
