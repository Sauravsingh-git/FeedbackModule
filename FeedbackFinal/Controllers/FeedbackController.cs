using FeedbackFinal.Data;
using FeedbackFinal.Models;
using FeedbackFinal.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackFinal.Controllers
{
    public class FeedbackController : Controller
    {
		private readonly FeedbackDbContext FbDbContext;

		public FeedbackController(FeedbackDbContext FbDbContext)
		{
			this.FbDbContext = FbDbContext;
		}

		public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(String SubjectId, String SubjectName)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FormResponse response)
        {
            Guid FeedBackId = Guid.NewGuid();
            // feedback entry object 
            FeedbackEntry FbEntry = new FeedbackEntry();
            FbEntry.SubmissionTimestamp = DateTime.Now;
            FbEntry.FeedbackId = FeedBackId;
            FbEntry.EnrollmentRollNo = response.EnrollmentNo;
			
            FbEntry.SubjectId = response.SubjectId;

            // Response objects
            Response responseObjA1 = new Response();
            responseObjA1.FeedbackId = FeedBackId;
            responseObjA1.QuestionId = "A1";
			responseObjA1.ResponseText = response.A1;

			Response responseObjA2 = new Response();
			responseObjA2.FeedbackId = FeedBackId;
			responseObjA2.QuestionId = "A2";
			responseObjA2.ResponseText = response.A2;

			Response responseObjA3 = new Response();
			responseObjA3.FeedbackId = FeedBackId;
			responseObjA3.QuestionId = "A3";
			responseObjA3.ResponseText = response.A3;

			Response responseObjB1 = new Response();
			responseObjB1.FeedbackId = FeedBackId;
			responseObjB1.QuestionId = "B1";
			responseObjB1.ResponseText = response.B1;

			Response responseObjB2 = new Response();
			responseObjB2.FeedbackId = FeedBackId;
			responseObjB2.QuestionId = "B2";
			responseObjB2.ResponseText = response.B2;

			Response responseObjB3 = new Response();
			responseObjB3.FeedbackId = FeedBackId;
			responseObjB3.QuestionId = "B3";
			responseObjB3.ResponseText = response.B3;

			Response responseObjB4 = new Response();
			responseObjB4.FeedbackId = FeedBackId;
			responseObjB4.QuestionId = "B4";
            responseObjB4.ResponseText = response.B4;

			Response responseObjB5 = new Response();
			responseObjB5.FeedbackId = FeedBackId;
			responseObjB5.QuestionId = "B5";
			responseObjB5.ResponseText = response.B5;

			Response responseObjB6 = new Response();
			responseObjB6.FeedbackId = FeedBackId;
			responseObjB6.QuestionId = "B6";
			responseObjB6.ResponseText = response.B6;

			Response responseObjC1 = new Response();
			responseObjC1.FeedbackId = FeedBackId;
			responseObjC1.QuestionId = "C1";
			responseObjC1.ResponseText = response.C1;

			Response responseObjC2 = new Response();
			responseObjC2.FeedbackId = FeedBackId;
			responseObjC2.QuestionId = "C2";
			responseObjC2.ResponseText = response.C2;

			Response responseObjC3 = new Response();
			responseObjC3.FeedbackId = FeedBackId;
			responseObjC3.QuestionId = "C3";
			responseObjC3.ResponseText = response.C3;

			Response responseObjC4 = new Response();
			responseObjC4.FeedbackId = FeedBackId;
			responseObjC4.QuestionId = "C4";
			responseObjC4.ResponseText = response.C4;

			Response responseObjC5 = new Response();
			responseObjC5.FeedbackId = FeedBackId;
			responseObjC5.QuestionId = "C5";
			responseObjC5.ResponseText = response.C5;

			Response responseObjD1 = new Response();
			responseObjD1.FeedbackId = FeedBackId;
			responseObjD1.QuestionId = "D1";
			responseObjD1.ResponseText = response.D1;

			Response responseObjD2 = new Response();
			responseObjD2.FeedbackId = FeedBackId;
			responseObjD2.QuestionId = "D2";
			responseObjD2.ResponseText = response.D2;

			Response responseObjD3 = new Response();
			responseObjD3.FeedbackId = FeedBackId;
			responseObjD3.QuestionId = "D3";
			responseObjD3.ResponseText = response.D3;

			Response responseObjD4 = new Response();
			responseObjD4.FeedbackId = FeedBackId;
			responseObjD4.QuestionId = "D4";
			responseObjD4.ResponseText = response.D4;

			Response responseObjD5 = new Response();
			responseObjD5.FeedbackId = FeedBackId;
			responseObjD5.QuestionId = "D5";
			responseObjD5.ResponseText = response.D5;

			Response responseObjD6 = new Response();
			responseObjD6.FeedbackId = FeedBackId;
			responseObjD6.QuestionId = "D6";
			responseObjD6.ResponseText = response.D6;

			Response responseObjD7 = new Response();
			responseObjD7.FeedbackId = FeedBackId;
			responseObjD7.QuestionId = "D7";
			responseObjD7.ResponseText = response.D7;

			Response responseObjD8 = new Response();
			responseObjD8.FeedbackId = FeedBackId;
			responseObjD8.QuestionId = "D8";
			responseObjD8.ResponseText = response.D8;

			Response responseObjD9 = new Response();
			responseObjD9.FeedbackId = FeedBackId;
			responseObjD9.QuestionId = "D9";
			responseObjD9.ResponseText = response.D9;

			Response responseObjD10 = new Response();
			responseObjD10.FeedbackId = FeedBackId;
			responseObjD10.QuestionId = "D10";
			responseObjD10.ResponseText = response.D10;

			Response responseObjE1 = new Response();
			responseObjE1.FeedbackId = FeedBackId;
			responseObjE1.QuestionId = "E1";
			responseObjE1.ResponseText = response.E1;

			Response responseObjF1 = new Response();
			responseObjF1.FeedbackId = FeedBackId;
			responseObjF1.QuestionId = "F1";
			responseObjF1.ResponseText = response.F1;

			Response responseObjG1 = new Response();
			responseObjG1.FeedbackId = FeedBackId;
			responseObjG1.QuestionId = "G1";
			responseObjG1.ResponseText = response.G1;

			Response responseObjH1 = new Response();
			responseObjH1.FeedbackId = FeedBackId;
			responseObjH1.QuestionId = "H1";
			responseObjH1.ResponseText = response.H1;

			Response responseObjI1 = new Response();
			responseObjI1.FeedbackId = FeedBackId;
			responseObjI1.QuestionId = "I1";
			responseObjI1.ResponseText = response.I1; 

			Response responseObjI2 = new Response();
			responseObjI2.FeedbackId = FeedBackId;
			responseObjI2.QuestionId = "I2";
			responseObjI2.ResponseText = response.I2;

			Response responseObjI3 = new Response();
			responseObjI3.FeedbackId = FeedBackId;
			responseObjI3.QuestionId = "I3";
			responseObjI3.ResponseText = response.I3;

			Response responseObjI4 = new Response();
			responseObjI4.FeedbackId = FeedBackId;
			responseObjI4.QuestionId = "I4";
			responseObjI4.ResponseText = response.I4;

			Response responseObjI5 = new Response();
			responseObjI5.FeedbackId = FeedBackId;
			responseObjI5.QuestionId = "I5";
			responseObjI5.ResponseText = response.I5;

			Response responseObjJ1 = new Response();
			responseObjJ1.FeedbackId = FeedBackId;
			responseObjJ1.QuestionId = "J1";
			responseObjJ1.ResponseText = response.J1;

			Response responseObjJ2 = new Response();
			responseObjJ2.FeedbackId = FeedBackId;
			responseObjJ2.QuestionId = "J2";
			responseObjJ2.ResponseText = response.J2;

			Response responseObjJ3 = new Response();
			responseObjJ3.FeedbackId = FeedBackId;
			responseObjJ3.QuestionId = "J3";
			responseObjJ3.ResponseText = response.J3;

			Response responseObjJ4 = new Response();
			responseObjJ4.FeedbackId = FeedBackId;
			responseObjJ4.QuestionId = "J4";
			responseObjJ4.ResponseText = response.J4;

			Response responseObjJ5 = new Response();
			responseObjJ5.FeedbackId = FeedBackId;
			responseObjJ5.QuestionId = "J5";
			responseObjJ5.ResponseText = response.J5;

			Response responseObjK1 = new Response();
			responseObjK1.FeedbackId = FeedBackId;
			responseObjK1.QuestionId = "K1";
			responseObjK1.ResponseText = response.K1;

			FbDbContext.FeedbackEntry.Add(FbEntry);
			FbDbContext.SaveChanges();

			FbDbContext.ResponseEntry.Add(responseObjA1);
			FbDbContext.ResponseEntry.Add(responseObjA2);
			FbDbContext.ResponseEntry.Add(responseObjA3);
			FbDbContext.ResponseEntry.Add(responseObjB1);
			FbDbContext.ResponseEntry.Add(responseObjB2);
			FbDbContext.ResponseEntry.Add(responseObjB3);
			FbDbContext.ResponseEntry.Add(responseObjB4);
			FbDbContext.ResponseEntry.Add(responseObjB5);
			FbDbContext.ResponseEntry.Add(responseObjB6);
			FbDbContext.ResponseEntry.Add(responseObjC1);
			FbDbContext.ResponseEntry.Add(responseObjC2);
			FbDbContext.ResponseEntry.Add(responseObjC3);
			FbDbContext.ResponseEntry.Add(responseObjC4);
			FbDbContext.ResponseEntry.Add(responseObjC5);
			FbDbContext.ResponseEntry.Add(responseObjD1);
			FbDbContext.ResponseEntry.Add(responseObjD2);
			FbDbContext.ResponseEntry.Add(responseObjD3);
			FbDbContext.ResponseEntry.Add(responseObjD4);
			FbDbContext.ResponseEntry.Add(responseObjD5);
			FbDbContext.ResponseEntry.Add(responseObjD6);
			FbDbContext.ResponseEntry.Add(responseObjD7);
			FbDbContext.ResponseEntry.Add(responseObjD8);
			FbDbContext.ResponseEntry.Add(responseObjD9);
			FbDbContext.ResponseEntry.Add(responseObjD10);
			FbDbContext.ResponseEntry.Add(responseObjE1);
			FbDbContext.ResponseEntry.Add(responseObjF1);
			FbDbContext.ResponseEntry.Add(responseObjG1);
			FbDbContext.ResponseEntry.Add(responseObjH1);
			FbDbContext.ResponseEntry.Add(responseObjI1);
			FbDbContext.ResponseEntry.Add(responseObjI2);
			FbDbContext.ResponseEntry.Add(responseObjI3);
			FbDbContext.ResponseEntry.Add(responseObjI4);
			FbDbContext.ResponseEntry.Add(responseObjI5);
			FbDbContext.ResponseEntry.Add(responseObjJ1);
			FbDbContext.ResponseEntry.Add(responseObjJ2);
			FbDbContext.ResponseEntry.Add(responseObjJ3);
			FbDbContext.ResponseEntry.Add(responseObjJ4);
			FbDbContext.ResponseEntry.Add(responseObjJ5);
			FbDbContext.ResponseEntry.Add(responseObjK1);
			FbDbContext.SaveChanges();
			FbDbContext.SaveChanges();

			return RedirectToAction("Index");
        }

    }
}
