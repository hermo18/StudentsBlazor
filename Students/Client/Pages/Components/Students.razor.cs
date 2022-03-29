using Students.Client.Data;

namespace Students.Client.Pages.Components
{
    public partial class Students
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
