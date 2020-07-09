using System;
using System.ComponentModel.DataAnnotations;

namespace FrontierCodeChallenge.Models
{
    public class AccountsViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        //TODO PhoneNumber is a string so I added a second Phone field as an Int64 to make it easier to format. May cause issues later if different
        //TODO Phone Number styles are in the data. Possibly a Regex could be used to do the formatting, but should be a better way than this.
        public string PhoneNumber { get; set; }
        [DisplayFormat(DataFormatString = "{0:(###) ###-####}")]
        public long PhoneNum { get { return Convert.ToInt64(PhoneNumber); } }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal AmountDue { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset? PaymentDueDate { get; set; }
        public int AccountStatusId { get; set; }
    }
}
