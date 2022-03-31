using Person.Client.Data;

namespace Person.Client.Pages.Components
{
    public partial class StudentComponent 
    {

		protected List<StudentModel> studentList = new List<StudentModel>();

		protected StudentModel student = new StudentModel();

		protected void AddTask()
		{
			studentList.Add(student);
			student = new StudentModel();
		}

		private int st;
		private int newMark;

		public void Modify()
		{
			foreach (var i in studentList)
			{
				var selectedStudent = studentList.Where(s => s.StudentId == st).FirstOrDefault();
				if(selectedStudent != null)
                {
					selectedStudent.StudentMark = newMark;
                }
                else
                {
					Console.WriteLine("NO ID DETECTED");
				}
				
				
			}

		}
	}
}
