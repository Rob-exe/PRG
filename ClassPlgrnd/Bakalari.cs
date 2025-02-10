using System.Diagnostics.Metrics;

namespace ClassPlayground
{
	class Student
	{
		int year;
		int id;
		Dictionary<string, List<float>> subjects;

		public void AddSubject(string subjectName)
		{
			if (subjects.ContainsKey(subjectName))
			{
				Console.WriteLine("ERROR: Subject is already assigned.");
			} else {
				subjects.Add(subjectName,[]);
				Console.WriteLine("Added subject: " + subjectName);
			}
		}
		public void AddGrade(string subjectName, string grade)
		{
			int gradeNorm;
			if (Convert.ToInt32(grade) < 0)
			{
				gradeNorm = Math.Abs(Convert.ToInt32(grade));
			}
			subjects[subjectName].Add(gradeNorm);
		}
	}
}