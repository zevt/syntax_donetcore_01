namespace Experiment.Employment
{
    internal class Employee
    {
        private string _department;
        private int _empID;
        private string _loginName;
        private string _name;
        private string _password;

        public string Name
        {
            set { _name = value; }
            get { return _name;  }
        }


    }
}