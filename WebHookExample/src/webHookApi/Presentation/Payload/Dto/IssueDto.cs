using System;
namespace webHookApi.Presentation.Payload.Dto
{
	public class IssueDto
	{
        public string Url { get; set; }

        public int Number { get; set; }

        public string Title { get; set; }
    }
}

