using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace ACLA
{
    public class DataAnalysisAndPresentation
    {
        public static System.Data.DataTable GetTableForSummaryGrid(List<StorySummary> stories, string epic)
        {
            List<Tuple<string, string>> storiesInEpic = GetStorySummaryEpicLevel(stories, epic);

            System.Data.DataTable output = new System.Data.DataTable();
            output.Columns.Add("Description", typeof(string));
            output.Columns.Add("Value", typeof(string));

            foreach (var record in storiesInEpic)
            {
                output.Rows.Add(record.Item1, record.Item2);
            }

            return output;
        }
        public static System.Data.DataTable GetEmailMatrix(List<StorySummary> stories, string signature)
        {
            var unassignedStories = ExcludeStoriesWithoutAssigneeOrResolved(stories);
            string email = "";

            System.Data.DataTable output = new System.Data.DataTable();
            output.Columns.Add("Story key", typeof(string));
            output.Columns.Add("Summary", typeof(string));
            output.Columns.Add("Status", typeof(string));
            output.Columns.Add("Assignee", typeof(string));
            output.Columns.Add("Assignee email", typeof(string));
            output.Columns.Add("Email text", typeof(string));

            foreach (var story in unassignedStories)
            {
                output.Rows.Add(story.IssueKey, story.Summary, story.IssueStatus, story.Assignee, story.AssigneeEmail, FormatEmail(story, signature));
            }

            
            return output;
        }
        private static List<Tuple<string, string>> GetStorySummaryEpicLevel(List<StorySummary> stories, string epic)
        {
            List<Tuple<string, string>> outputData = new List<Tuple<string, string>>();
            int noStories, noClosedStories = 0, noOpenStories = 0, noAnalysis = 0, noResolvedStories = 0, noReadyToDevelop = 0, noDevelopment = 0, noReadyToTest = 0, noTesting = 0;
            double totalstorysSpentEffort = 0, totalstorysRemainingEffort = 0;

            noStories = stories.Count();

            noOpenStories = stories.Where(x => x.IssueStatus.ToUpper() == "OPEN").Count();
            noAnalysis = stories.Where(x => x.IssueStatus.ToUpper() == "ANALYSIS").Count();
            noReadyToDevelop = stories.Where(x => x.IssueStatus.ToUpper() == "READY TO DEVELOP").Count();
            noDevelopment = stories.Where(x => x.IssueStatus.ToUpper() == "DEVELOPMENT").Count();
            noReadyToTest = stories.Where(x => x.IssueStatus.ToUpper() == "READY TO TEST").Count();
            noTesting = stories.Where(x => x.IssueStatus.ToUpper() == "TESTING").Count();
            noResolvedStories = stories.Where(x => x.IssueStatus.ToUpper() == "RESOLVED").Count();
            noClosedStories = stories.Where(x => x.IssueStatus.ToUpper() == "CLOSED").Count();

            foreach (var story in stories)
            {
                if (!string.IsNullOrEmpty(story.TimeRemaining))
                {
                    totalstorysRemainingEffort += int.Parse(story.TimeRemaining);
                }

                if (!string.IsNullOrEmpty(story.TimeSpent))
                {
                    totalstorysSpentEffort += int.Parse(story.TimeSpent);
                }
            }

            outputData.Add(Tuple.Create("ISSUES IN EPIC", ""));
            outputData.Add(Tuple.Create("Number of all stories in epic", noStories.ToString()));
            outputData.Add(Tuple.Create("Number of open stories in epic", noOpenStories.ToString()));
            outputData.Add(Tuple.Create("Number of stories in analysis in epic", noAnalysis.ToString()));
            outputData.Add(Tuple.Create("Number of stories ready to develop in epic", noReadyToDevelop.ToString()));
            outputData.Add(Tuple.Create("Number of stories in development in epic", noDevelopment.ToString()));
            outputData.Add(Tuple.Create("Number of stories ready to test in epic", noReadyToTest.ToString()));
            outputData.Add(Tuple.Create("Number of stories under testing in epic", noTesting.ToString()));
            outputData.Add(Tuple.Create("Number of resolved stories in epic", noResolvedStories.ToString()));
            outputData.Add(Tuple.Create("Number of closed stories in epic", noClosedStories.ToString()));
            outputData.Add(Tuple.Create("Effort spent on stories", Math.Round((decimal)totalstorysSpentEffort / 3600, 2) + "h"));
            outputData.Add(Tuple.Create("Estimated effort to spend on stories", Math.Round((decimal)totalstorysRemainingEffort / 3600, 2) + "h"));

            return outputData;
        }

        private static List<StorySummary> ExcludeStoriesWithoutAssigneeOrResolved(List<StorySummary> stories)
        {
            return stories.Where(s => s.Assignee != null && string.IsNullOrWhiteSpace(s.Resolution)).Select(s => s).ToList();
        }

        private static string FormatEmail(StorySummary story, string signature)
        {
            StringBuilder mail = new StringBuilder();
            mail.AppendLine($"Cześć {story.Assignee}!");
            mail.AppendLine($"Jesteś przypisany do taska {story.IssueKey}: {story.Summary}.");
            mail.AppendLine($"Czy mógłbyś przesłać mi krótki update jak Ci idzie, lub czy potrzebujesz jakiejś pomocy?");
            mail.AppendLine("Pozdrawiam,");
            mail.AppendLine(signature);
            return mail.ToString();
        }
    }
}
