using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ACLA
{
    class ApiRequests
    {
        public static List<StorySummary> GetStoryListFromEpic(string jiraUrl, string login, string password, string issueKey)
        {
            int startingIndex = 0, finishedIterations = 0, pageSize = 50;
            bool exitLoop;
            List<StorySummary> storyList = new List<StorySummary>();
            string issueType = "story";

            do
            {
                //string url = jiraUrl + $@"/rest/api/latest/search?jql=Type%20%3D%20{issueType}%20and%20%22Epic%20Link%22%3D{issueKey}&startAt={startingIndex}";
                string url = jiraUrl + $@"/rest/api/latest/search?jql=%22Epic%20Link%22%3D{issueKey}&startAt={startingIndex}";

                string serverResponse = JiraWebRequest(url, login, password);

                ListOfJiraIssues resultList = JsonConvert.DeserializeObject<ListOfJiraIssues>(serverResponse);
                foreach (var item in resultList.Issues)
                {
                    StorySummary story = new StorySummary { IssueKey = item?.Key, Summary = item?.Fields?.summary,
                        IssueStatus = item?.Fields?.status?.Name, Resolution = item?.Fields?.resolution?.Name,
                        TimeSpent = item?.Fields?.aggregatetimespent, TimeRemaining = item?.Fields?.aggregatetimeestimate,
                        Assignee = item?.Fields?.assignee?.DisplayName, AssigneeEmail = item?.Fields?.assignee?.EmailAddress
                    };
                    storyList.Add(story);
                }
                startingIndex += pageSize;
                finishedIterations += 1;
                exitLoop = CanExitLoop(resultList.Total, finishedIterations);

            } while (exitLoop == false);

            return storyList;
        }
        public static JiraIssue GetJiraIssueDetails(string jiraUrl, string login, string password, string issueKey)
        {
            JiraIssue issue = new JiraIssue();
            string url = jiraUrl + "/rest/api/latest/issue/" + issueKey;

            string serverResponse = JiraWebRequest(url, login, password);

            issue = JsonConvert.DeserializeObject<JiraIssue>(serverResponse);

            return issue;
        }
        private  static string JiraWebRequest(string url, string login, string password)
        {
            WebRequest myRequest = WebRequest.Create(url);
            string credentials = login + ":" + password;
            myRequest.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials)));

            WebResponse wr = myRequest.GetResponse();
            Stream receivedStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receivedStream, Encoding.UTF8);
            string serverResponse = reader.ReadToEnd();

            return serverResponse;
        }
        private static bool CanExitLoop(int totalNoOfIssues, int finishedIterations)
        {
            var neededIterations = int.Parse(Math.Ceiling(totalNoOfIssues / (decimal)50).ToString());
            return ((totalNoOfIssues <= 50) || (totalNoOfIssues > 50 && neededIterations > 1 && finishedIterations == neededIterations));
        }
    }
}
