﻿using FeedbackFinal.Data;
using FeedbackFinal.Models;
using FeedbackFinal.Models.Domain;
using FeedbackFinal.Models.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Remoting;

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


        public IActionResult Submission()
        {
            SubmissionForm obj = new SubmissionForm();
            obj.Subjects = FbDbContext.SubjectDetails.ToList();
            return View(obj);
        }

        public IActionResult Result(SubmissionForm submissionForm)   
        {
            SubmissionResult obj = new SubmissionResult();
            obj.FilledResponses = FbDbContext.FeedbackEntry.Where(x=> x.SubjectId ==  submissionForm.SubjectCode && x.SubmissionTimestamp.Year == submissionForm.Year).ToList();
            obj.D1 = 5.0;
            obj.D2 = 5.0;
            obj.D3 = 5.0;
            obj.D4 = 5.0;
            obj.D5 = 5.0;
            obj.D6 = 5.0;
            obj.D7 = 5.0;
            obj.D8 = 5.0;
            obj.D9 = 5.0;
            obj.D10 = 5.0;
            obj.TotalEntries = obj.FilledResponses.Count;

            return View(obj);
        }

        public IActionResult Submissions()
        {
            SubmissionForm submissionForm = new SubmissionForm();
            return View(submissionForm);
        }

        public IActionResult ShowResponse()
        {
            var Responses = FbDbContext.FeedbackEntry.ToList();
            return View(Responses);
        }

        public IActionResult ViewForm()
        {
            string guidStr = HttpContext.Request.Query["FeedbackId"].ToString().ToUpper();

			Guid feedbackId = Guid.Parse(guidStr);
            Response obj = FbDbContext.ResponseEntry.Where(x => x.FeedbackId == feedbackId).FirstOrDefault();
            if (obj == null) return NotFound();
			return View(obj);
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
            Response responseObj = new Response();
            responseObj.FeedbackId = FeedBackId;
			responseObj.ResponseTextA1 = response.A1;
            responseObj.ResponseTextA2 = response.A2;
            responseObj.ResponseTextA3 = response.A3;
            responseObj.ResponseTextB1 = response.B1;
            responseObj.ResponseTextB2 = response.B2;
            responseObj.ResponseTextB3 = response.B3;
            responseObj.ResponseTextB4 = response.B4;
            responseObj.ResponseTextB5 = response.B5;
            responseObj.ResponseTextB6 = response.B6;
            responseObj.ResponseTextC1 = response.C1;
            responseObj.ResponseTextC2 = response.C2;
            responseObj.ResponseTextC3 = response.C3;
            responseObj.ResponseTextC4 = response.C4;
            responseObj.ResponseTextC5 = response.C5;
            responseObj.ResponseTextD1 = response.D1;
            responseObj.ResponseTextD2 = response.D2;
            responseObj.ResponseTextD3 = response.D3;
            responseObj.ResponseTextD4 = response.D4;
            responseObj.ResponseTextD5 = response.D5;
            responseObj.ResponseTextD6 = response.D6;
            responseObj.ResponseTextD7 = response.D7;
            responseObj.ResponseTextD8 = response.D8;
            responseObj.ResponseTextD9 = response.D9;
            responseObj.ResponseTextD10 = response.D10;
            responseObj.ResponseTextE1 = response.E1;
            responseObj.ResponseTextF1 = response.F1;
            responseObj.ResponseTextG1 = response.G1;
            responseObj.ResponseTextH1 = response.H1;
            responseObj.ResponseTextI1 = response.I1;
            responseObj.ResponseTextI2 = response.I2;
            responseObj.ResponseTextI3 = response.I3;
            responseObj.ResponseTextI4 = response.I4;
            responseObj.ResponseTextI5 = response.I5;
            responseObj.ResponseTextJ1 = response.J1;
            responseObj.ResponseTextJ2 = response.J2;
            responseObj.ResponseTextJ3 = response.J3;
            responseObj.ResponseTextJ4 = response.J4;
            responseObj.ResponseTextJ5 = response.J5;
            responseObj.ResponseTextK1 = response.K1;


			FbDbContext.FeedbackEntry.Add(FbEntry);
			FbDbContext.SaveChanges();

            FbDbContext.ResponseEntry.Add(responseObj);
			FbDbContext.SaveChanges();
			FbDbContext.SaveChanges();

			return RedirectToAction("Index");
        }

    }
}
