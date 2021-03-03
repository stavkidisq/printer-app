using ApplicationStyles;
using System;

namespace BusinessInterfaces
{
    public class RequestPrintForm : IRequestForm
    {
        public int Id { get; set; }
        public DocumentForPrint Document { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public string RecipientName { get; set; }
        public string SenderName { get; set; }
        public Policy PrivatePolicy { get; set; }

        public RequestPrintForm(string recipientName, DocumentForPrint document, Policy policy = Policy.Public)
        {
            Id = default;
            RecipientName = recipientName;
            Document = document;
            PrivatePolicy = policy;
        }
    }
}
