namespace DB_project
{
    public static class Constants
    {
        public const string MIN_WORK_TIME =
            "SELECT distinct project.name, test.name, ( test.end_time - test.start_time) From test JOIN project ON project_id = project.id Where (test.end_time - test.start_time) > '0' group by test.name order by project.name, test.name";

        public const string TESTS_COUNT =
            "SELECT project.name, count(test.id) From test JOIN project ON project_id = project.id group by project.name";

        public const string TESTS_DATE =
            "select project.name, test.name, end_time From test join project on project_id = project.id where end_time > '2015-11-07 00:00:00' order by project.name, test.name";

        public const string COUNT_BROWSERS_TESTS =
            "select count(test.browser) from test Where browser = 'chrome' union select count(test.browser) from test Where test.browser = 'firefox'";
    }
}