using System;

namespace Harman
{
    // Business class that holds one facilities issue and checks the rules.
    public class FacilitiesIssue
    {
        private int issueID;
        private string location = string.Empty;
        private string issueCategory = string.Empty;
        private string description = string.Empty;
        private DateTime dateReported;
        private string priority = string.Empty;
        private string status = string.Empty;
        private string reportedBy = string.Empty;

        public int IssueID
        {
            get { return issueID; }
            set { issueID = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string IssueCategory
        {
            get { return issueCategory; }
            set { issueCategory = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime DateReported
        {
            get { return dateReported; }
            set { dateReported = value; }
        }

        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string ReportedBy
        {
            get { return reportedBy; }
            set { reportedBy = value; }
        }

        // Returns an empty string when valid, or an error message when invalid.
        public string Validate()
        {
            if (string.IsNullOrWhiteSpace(location))
            {
                return "Location must not be empty.";
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                return "Issue description must not be empty.";
            }

            if (string.IsNullOrWhiteSpace(reportedBy))
            {
                return "Reported By must not be empty.";
            }

            if (string.IsNullOrWhiteSpace(issueCategory))
            {
                return "Please select an issue category.";
            }

            if (priority != "Low" && priority != "Medium" && priority != "High")
            {
                return "Priority must be Low, Medium or High.";
            }

            if (status != "Open" && status != "In Progress" && status != "Resolved")
            {
                return "Status must be Open, In Progress or Resolved.";
            }

            if (dateReported.Date > DateTime.Today)
            {
                return "Date reported cannot be in the future.";
            }

            return string.Empty;
        }
    }
}
