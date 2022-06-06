using System;
using System.Net.Mail;

namespace DST__Dükkan_Stok_Takip_
{
    internal class mailmessage
    {
        public mailmessage()
        {
        }

        public static implicit operator MailMessage(mailmessage v)
        {
            throw new NotImplementedException();
        }
    }
}