using DB_project.Utils;
using NUnit.Framework;

namespace DB_project
{
    public class Tasks
    {
        private string _fileName = "DataFile.csv";

        [Test]
        public void Task1Test()
        {
            var data = DbUtils.ExecuteQuery(Constants.MIN_WORK_TIME);

            FileUtils.CreateAndWriteFile(_fileName, data);
        }

        [Test]
        public void Task2Test()
        {
            var data = DbUtils.ExecuteQuery(Constants.TESTS_COUNT);

            FileUtils.CreateAndWriteFile(_fileName, data);
        }

        [Test]
        public void Task3Test()
        {
            var data = DbUtils.ExecuteQuery(Constants.TESTS_DATE);

            FileUtils.CreateAndWriteFile(_fileName, data);
        }

        [Test]
        public void Task4Test()
        {
            var data = DbUtils.ExecuteQuery(Constants.COUNT_BROWSERS_TESTS);

            FileUtils.CreateAndWriteFile(_fileName, data);
        }
    }
}