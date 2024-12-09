using SSH.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SSH.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var model = new Contact();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Contact(Contact model)
        {
            StringBuilder sb = new StringBuilder();
            if (ModelState.IsValid)
            {
                var mail = new MailMessage();
                mail.Subject =String.Concat("SSH Website::Contact::", model.Subject);
                mail.Body = sb.Append(model.Message).Append(Environment.NewLine).Append("Email from: ").Append(model.Email).Append(Environment.NewLine).ToString();
                mail.From = new MailAddress(model.Email);
                mail.To.Add(new MailAddress("enquiry@srisaihospitals.co.in"));
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 3535;
                smtp.Host = "smtpout.asia.secureserver.net";
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("from2@srisaihospitals.co.in", "Srisai@1qaz!QAZ"); //("website@srisaihospitals.co.in", "Srisai@1qaz!QAZ");
                // smtp.EnableSsl = true;

                //System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
                //       System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                //       System.Security.Cryptography.X509Certificates.X509Chain chain,
                //       System.Net.Security.SslPolicyErrors sslPolicyErrors)
                //{
                //    return true;
                //};
                smtp.Send(mail);
                return Json(new { message = "Message was sent" });
            }
            else
            {
                return Json(new { message = "Message was not sent" });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Email(EmailModel model)
        {
            StringBuilder sb = new StringBuilder();
            if (ModelState.IsValid)
            {
                var mail = new MailMessage();
                mail.Subject = String.Concat("SSH Website::Email::", model.Subject);
                sb.Append(model.Message).Append(Environment.NewLine).Append("Email: ").Append(model.Email).Append(Environment.NewLine);
                if (!string.IsNullOrEmpty(model.PhoneNo))
                {
                    sb.Append(model.Message).Append(Environment.NewLine).Append("Phone: ").Append(model.PhoneNo).Append(Environment.NewLine);
                }
                if (!string.IsNullOrEmpty(model.City))
                {
                    sb.Append(model.Message).Append(Environment.NewLine).Append("City: ").Append(model.City).Append(Environment.NewLine);
                }
                if (!string.IsNullOrEmpty(model.FormName))
                {
                    sb.Append(model.Message).Append(Environment.NewLine).Append("Form Name: ").Append(model.FormName).Append(Environment.NewLine);
                }
                mail.Body = sb.ToString();
                mail.From = new MailAddress(model.Email);
                mail.To.Add(new MailAddress("enquiry@srisaihospitals.co.in"));
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
               // smtp.Host = "smtp.gmail.com";
                smtp.Port = 3535;
               smtp.Host= "smtpout.asia.secureserver.net";
                smtp.UseDefaultCredentials = false;
                //smtp.Credentials = new System.Net.NetworkCredential("info@srisaihospitals.co.in", "Srisai@123"); // Enter seders User name and password  
                smtp.Credentials = new System.Net.NetworkCredential("from2@srisaihospitals.co.in", "Srisai@1qaz!QAZ"); //("website@srisaihospitals.co.in", "Srisai@1qaz!QAZ"); // Enter seders User name and password 
               // smtp.EnableSsl = false;

                //System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
                //       System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                //       System.Security.Cryptography.X509Certificates.X509Chain chain,
                //       System.Net.Security.SslPolicyErrors sslPolicyErrors)
                //{
                //    return true;
                //};
                smtp.Send(mail);
                return Json(new { message = "Email was sent" });
            }
            else
            {
                return Json(new { message = "Email was not sent" });
            }

        }

        public ActionResult Services()
        {
            
            return View();
        }

        public ActionResult Facilities()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Packages()
        {
            ViewBag.Message = "Health Packages.";
            return View("packages");
        }

        public ActionResult DiagnosticServices()
        {
            ViewBag.Message = "Diagnostic Services.";
            return View("DiagnosticServices");
        }

        public ActionResult OutPatientService()
        {
            ViewBag.Message = "Outpatient Service.";
            return View("OutPatientService");
        }

        public ActionResult AdmissionDischargeProcedure()
        {
            ViewBag.Message = "Admission and Discharge Procedures.";
            return View("AdmissionDischargeProcedure");
        }

        public ActionResult InPatientServices()
        {
            ViewBag.Message = "Inpatient Services.";
            return View("InPatientServices");
        }

        public ActionResult Insurance()
        {
            ViewBag.Message = "Insurance.";
            return View("Insurance");
        }

        public ActionResult AmbulanceServices()
        {
            ViewBag.Message = "Ambulance Services.";
            return View("AmbulanceServices");
        }

        public ActionResult VisitorInformation()
        {
            ViewBag.Message = "Visitor Information.";
            return View("VisitorInformation");
        }


        public ActionResult Doctors()
        {
            ViewBag.Message = "Your contact page.";
            return View("our-doctors");
        }

        public ActionResult Appointment()
        {
            ViewBag.Message = "Your Appointment page.";
            return View();
        }

        public ActionResult Specialities()
        {
            ViewBag.Message = "Your Specialities page.";
            return View();
        }

        public ActionResult specialitiesDetails()
        {
            ViewBag.Message = "Your Specialities page.";
            return View();
        }

        public ActionResult facilitiesDetails()
        {
            ViewBag.Message = "Your Specialities page.";
            return View();
        }




    }
}