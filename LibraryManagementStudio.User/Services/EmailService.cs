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
	        Credentials = new NetworkCredential("8e7ba0efe55a04", "33fd41a9fcfce2"),
	        EnableSsl = true
        };
    }

    public void SendReturnCodeMessage(string toEmailAddress, string returnCode, string bookName)
    {
	    var subject = "Kod zwrotu dla książki " + bookName;
	    
	    var htmlBody = ReturnHtmlBody.Replace("{bookName}", bookName);
	    htmlBody = htmlBody.Replace("{returnCode}", returnCode);
	    
	    SendEmail(toEmailAddress, subject, htmlBody);
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

    private const string ReturnHtmlBody = @"
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
			.return-code {
				background-color: #333333;
				color: #ffffff;
				padding: 10px;
				display: inline-block;
			}
			.header {
				background-color: black;
				color: #ffffff;
				padding: 20px;
				max-width: 600px;
				margin: 0 auto;
			}
		</style>
	</head>
	<body>
	    <h1 class='header'>Library Management Studio</h1>
		<div class='container'>
			<h2>Dziękujemy za zwrot książki pt. '{bookName}'</h1>
			<p>Kod zwrotu:</h2>
			<p><span class='return-code'>{returnCode}</span></p>
			<p>Aby zwrócić książke użyj podanego kodu w naszym książkomacie. W przypadku problemów zapraszamy do oddziału stacjonarnego.</p>
		</div>
	</body>
	</html>";
}