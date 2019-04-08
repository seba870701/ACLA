using System;
using System.Collections.Generic;

namespace ACLA
{
    class ListOfJiraIssues
    {
        public string Expand { get; set; }
        public int StartAt { get; set; }
        public int MaxResults { get; set; }
        public int Total { get; set; }
        public List<JiraIssue> Issues { get; set; }
    }
    public class JiraIssue
    {
        public string Expand { get; set; }
        public string Id { get; set; }
        public string Self { get; set; }
        public string Key { get; set; }
        public Fields Fields { get; set; }
    }


    public class Issuetype
    {
        public string Self { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public bool Subtask { get; set; }
    }

    public class AvatarUrls
    {
        public string __invalid_name__48x48 { get; set; }
        public string __invalid_name__24x24 { get; set; }
        public string __invalid_name__16x16 { get; set; }
        public string __invalid_name__32x32 { get; set; }
    }

    public class ProjectCategory
    {
        public string Self { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }

    public class Project
    {
        public string Self { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public AvatarUrls AvatarUrls { get; set; }
        public ProjectCategory ProjectCategory { get; set; }
    }

    public class FixVersion
    {
        public string Self { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool Archived { get; set; }
        public bool Released { get; set; }
    }

    public class Resolution
    {
        public string Self { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }

    public class Watches
    {
        public string Self { get; set; }
        public int WatchCount { get; set; }
        public bool IsWatching { get; set; }
    }

    public class Priority
    {
        public string Self { get; set; }
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class Customfield10100
    {
        public string Self { get; set; }
        public string Value { get; set; }
        public string Id { get; set; }
    }

    public class Customfield10101
    {
        public string Self { get; set; }
        public string Value { get; set; }
        public string Id { get; set; }
    }

    public class AvatarUrls2
    {
        public string __invalid_name__48x48 { get; set; }
        public string __invalid_name__24x24 { get; set; }
        public string __invalid_name__16x16 { get; set; }
        public string __invalid_name__32x32 { get; set; }
    }

    public class Assignee
    {
        public string Self { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string EmailAddress { get; set; }
        public AvatarUrls2 AvatarUrls { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
        public string TimeZone { get; set; }
    }


    public class StatusCategory
    {
        public string Self { get; set; }
        public int Id { get; set; }
        public string Key { get; set; }
        public string ColorName { get; set; }
        public string Name { get; set; }
    }

    public class Status
    {
        public string Self { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public StatusCategory StatusCategory { get; set; }
    }

    public class Component
    {
        public string Self { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Customfield10608
    {
        public string Self { get; set; }
        public string Value { get; set; }
        public string Id { get; set; }
    }

    public class AvatarUrls3
    {
        public string __invalid_name__48x48 { get; set; }
        public string __invalid_name__24x24 { get; set; }
        public string __invalid_name__16x16 { get; set; }
        public string __invalid_name__32x32 { get; set; }
    }

    public class Creator
    {
        public string Self { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string EmailAddress { get; set; }
        public AvatarUrls3 AvatarUrls { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
        public string TimeZone { get; set; }
    }

    public class AvatarUrls4
    {
        public string __invalid_name__48x48 { get; set; }
        public string __invalid_name__24x24 { get; set; }
        public string __invalid_name__16x16 { get; set; }
        public string __invalid_name__32x32 { get; set; }
    }

    public class Reporter
    {
        public string Self { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string EmailAddress { get; set; }
        public AvatarUrls4 AvatarUrls { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
        public string TimeZone { get; set; }
    }

    public class Aggregateprogress
    {
        public int Progress { get; set; }
        public int Total { get; set; }
        public decimal percent { get; set; }
    }

    public class Customfield11603
    {
        public string Self { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
    }

    public class Progress
    {
        public int progress { get; set; }
        public int Total { get; set; }
    }

    public class Votes
    {
        public string Self { get; set; }
        public int votes { get; set; }
        public bool HasVoted { get; set; }
    }
    public class Fields
    {
        public Issuetype issuetype { get; set; }
        public string timespent { get; set; }
        public Project project { get; set; }
        public List<FixVersion> fixVersions { get; set; }
        public object customfield_11200 { get; set; }
        public string aggregatetimespent { get; set; }
        public Resolution resolution { get; set; }
        public object customfield_11201 { get; set; }
        public DateTime? customfield_11314 { get; set; }
        public object customfield_10501 { get; set; }
        public DateTime? customfield_11315 { get; set; }
        public string customfield_11316 { get; set; }
        public object customfield_10700 { get; set; }
        public List<Customfield10701> customfield_10701 { get; set; }
        public object customfield_10900 { get; set; }
        public DateTime? resolutiondate { get; set; }
        public Int64 workratio { get; set; }
        public DateTime? lastViewed { get; set; }
        public Watches watches { get; set; }
        public DateTime created { get; set; }
        public object customfield_12001 { get; set; }
        public Priority priority { get; set; }
        public Customfield10100 customfield_10100 { get; set; }
        public Customfield10101 customfield_10101 { get; set; }
        public object customfield_10300 { get; set; }
        public List<object> labels { get; set; }
        public string customfield_11313 { get; set; }
        public string customfield_11501 { get; set; }
        public object timeestimate { get; set; }
        public object aggregatetimeoriginalestimate { get; set; }
        public List<object> versions { get; set; }
        public List<object> issuelinks { get; set; }
        public Assignee assignee { get; set; }
        public DateTime updated { get; set; }
        public Status status { get; set; }
        public List<Component> components { get; set; }
        public object timeoriginalestimate { get; set; }
        public string description { get; set; }
        public object customfield_11100 { get; set; }
        public object customfield_10011 { get; set; }
        public object customfield_11101 { get; set; }
        public object customfield_10012 { get; set; }
        public object customfield_10013 { get; set; }
        public object customfield_10014 { get; set; }
        public object customfield_10401 { get; set; }
        public object customfield_10005 { get; set; }
        public object customfield_10600 { get; set; }
        public object customfield_10402 { get; set; }
        public string customfield_10006 { get; set; }
        public object customfield_10601 { get; set; }
        public object customfield_10403 { get; set; }
        public object customfield_10206 { get; set; }
        public object customfield_10207 { get; set; }
        public object customfield_10603 { get; set; }
        public string aggregatetimeestimate { get; set; }
        public object customfield_10208 { get; set; }
        public object customfield_10604 { get; set; }
        public object customfield_10605 { get; set; }
        public object customfield_10606 { get; set; }
        public Customfield10608 customfield_10608 { get; set; }
        public object customfield_10609 { get; set; }
        public string summary { get; set; }
        public Creator creator { get; set; }
        public List<object> subtasks { get; set; }
        public Reporter reporter { get; set; }
        public object customfield_10000 { get; set; }
        public Aggregateprogress aggregateprogress { get; set; }
        public object customfield_10001 { get; set; }
        public object customfield_10200 { get; set; }
        public object customfield_10400 { get; set; }
        public string customfield_10004 { get; set; }
        public List<object> customfield_11601 { get; set; }
        public string customfield_11600 { get; set; }
        public Customfield11603 customfield_11603 { get; set; }
        public object customfield_11602 { get; set; }
        public object duedate { get; set; }
        public Progress progress { get; set; }
        public Votes votes { get; set; }
        public Customfield11304 customfield_11304 { get; set; }
        public Worklog worklog { get; set; }
    }
    public class Worklog
    {
        public int startAt { get; set; }
        public int maxResults { get; set; }
        public int total { get; set; }
        public List<object> worklogs { get; set; }
    }
    public class Customfield10701
    {
        public string self { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public string emailAddress { get; set; }
        public AvatarUrls2 avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
    }
    public class Customfield11304
    {
        public List<Step> steps { get; set; }
    }
    public class Step
    {
        public int id { get; set; }
        public int index { get; set; }
        public string step { get; set; }
        public string data { get; set; }
        public string result { get; set; }
        public List<object> attachments { get; set; }
    }
    public class AvatarUrlsm
    {
        public string __invalid_name__48x48 { get; set; }
        public string __invalid_name__24x24 { get; set; }
        public string __invalid_name__16x16 { get; set; }
        public string __invalid_name__32x32 { get; set; }
    }

    public class StorySummary
    {
        public string IssueKey { get; set; }
        public string Summary { get; set; }
        public string IssueStatus { get; set; }
        public string Resolution { get; set; }
        public string TimeSpent { get; set; }
        public string TimeRemaining { get; set; }
        public string Assignee { get; set; }
        public string AssigneeEmail { get; set; }
    }
}
