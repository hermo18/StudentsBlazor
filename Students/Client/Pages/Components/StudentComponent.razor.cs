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
	}
}
