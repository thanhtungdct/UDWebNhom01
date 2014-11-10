using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Net.Mail;
using System.Data;
/// <summary>
/// Hàm cấu hình và gởi Email.
/// </summary>
public class SendEmail
{
    public string send_Mail(string mailto, string Contents)
    {
        string Subject = "Thông tin đặt hàng tại Fast Food Shop";
        string EmailId = "mailforwebsurvey@gmail.com";
        string EmailPassword = "0974693299";
        try
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html><head>");
            sb.Append("<link rel='stylesheet' type='text/css' href='theme.css' />");
            sb.Append("</head>");
            sb.Append("<body>");

            sb.Append("<table>");
            sb.Append("<tr><td>" + Contents + "</td></tr>");
            sb.Append("<tr><td>--------------------------------------------------------------------------------</td></tr>");
            sb.Append("<tr><td>© Copyright © MatKinhSaiGon.com all rights reserved</td></tr>");
            sb.Append("</table>");
            sb.Append("</body>");
            sb.Append("</html>");
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage(); //create new Email
            msg.From = new MailAddress(EmailId, "Fast Food Shop", System.Text.Encoding.UTF8);
            msg.Subject = Subject;
            msg.To.Add(mailto);
            msg.Body = sb.ToString();
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.High;
            //Add the Creddentials
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(EmailId, EmailPassword);
            client.Port = 587; //gmail port
            client.Host = "smtp.gmail.com";//gmail host
            client.EnableSsl = true;
            client.Send(msg);
            return "Successfull!";
        }
        catch (Exception ms)
        {
            return ms.Message;
        }
    }

}