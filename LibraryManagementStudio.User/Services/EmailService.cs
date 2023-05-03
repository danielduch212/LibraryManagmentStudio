using System.Net;
using System.Net.Mail;
using LibraryManagementStudio.User.Services.Interfaces;

namespace LibraryManagementStudio.User.Services;

public class EmailService : IEmailService
{
    private const string FromEmailAddress = "noreplay@example.com";
    private readonly SmtpClient _smtpClient;

    public EmailService()
    {
	    _smtpClient = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
        {
            Credentials = new NetworkCredential("d10a9774b781ba", "3d03da2278e58c"),
            EnableSsl = true
        };
    }
    
    private void SendEmail(string toEmailAddress, string subject, string body)
    {
	    MailMessage mailMessage = new MailMessage();
	    mailMessage.From = new MailAddress(FromEmailAddress);
	    mailMessage.To.Add(toEmailAddress);
	    mailMessage.Subject = subject;
	    mailMessage.IsBodyHtml = true;
	    mailMessage.Body = body;
	    
        _smtpClient.Send(mailMessage);
    }
    
    public void SendCodeMessage(string toEmailAddress, string pickupCode, string returnCode, string bookName)
    {
	    var subject = "Kody odbioru i zwrotu dla książki " + bookName;
	    
	    var htmlBody = CodesHtmlBody.Replace("{bookName}", bookName);
	    htmlBody = htmlBody.Replace("{pickupCode}", pickupCode);
	    htmlBody = htmlBody.Replace("{returnCode}", returnCode);
	    
	    SendEmail(toEmailAddress, subject, htmlBody);
    }
    
    private const string CodesHtmlBody = @"
	<!DOCTYPE html>
	<html>
	<head>
		<meta charset='UTF-8'>
		<title>Dziękujemy za wypożyczenie książki</title>
		<style>
			body {
				font-family: Arial, sans-serif;
				background-color: #f2f2f2;
				margin: 0;
				padding: 0;
			}
			.container {
				max-width: 600px;
				margin: 0 auto;
				background-color: #ffffff;
				padding: 20px;
			}
			h1 {
				font-size: 24px;
				color: #0077c0;
				margin-top: 0;
			}
			h2 {
				font-size: 20px;
				color: #333333;
				margin-top: 0;
			}
			p {
				font-size: 16px;
				color: #333333;
				margin-bottom: 20px;
			}
			.pickup-code {
				background-color: #0077c0;
				color: #ffffff;
				padding: 10px;
				display: inline-block;
				margin-right: 10px;
			}
			.return-code {
				background-color: #333333;
				color: #ffffff;
				padding: 10px;
				display: inline-block;
			}
		</style>
	</head>
	<body>
		<div class='container'>
			<h1>Dziękujemy za wyporzyczenie książki pt. '{bookName}'</h1>
			<h2>Oto Twoje kody wypożyczenia</h2>
			<p>Kod odbioru:</p>
			<p><span class='pickup-code'>{pickupCode}</span></p>
			<p>Kod zwrotu:</p>
			<p><span class='return-code'>{returnCode}</span></p>
			<p>Zapamiętaj te kody, aby móc odebrać i zwrócić książkę. W przypadku problemów zapraszamy do oddziału stacjonarnego.</p>
		</div>
	</body>
	</html>";
}