using Microsoft.AspNetCore.Mvc;
using TechJobs.Data;
using TechJobs.Models;
using TechJobs.ViewModels;

namespace TechJobs.Controllers
{
    public class JobController : Controller
    {

        // Our reference to the data store
        private static JobData jobData;

        static JobController()
        {
            jobData = JobData.GetInstance();
        }

        // The detail display for a given Job at URLs like /Job?id=17
        public IActionResult Index(int id)
        {
            // TODO #1 - get the Job with the given ID and pass it into the view

            var someJob = jobData.Find(id);
            Job singleJob = new Job();

            singleJob.Name = someJob.Name;
            singleJob.Employer = someJob.Employer;
            singleJob.Location = someJob.Location;
            singleJob.CoreCompetency = someJob.CoreCompetency;
            singleJob.PositionType = someJob.PositionType;

            return View(singleJob);

        }

        public IActionResult New()
        {
            NewJobViewModel newJobViewModel = new NewJobViewModel();
            return View(newJobViewModel);
        }

     

        [HttpPost]
        public IActionResult New(NewJobViewModel newJobViewModel)
        {
            // TODO #6 - Validate the ViewModel and if valid, create a 
            // new Job and add it to the JobData data store. Then
            // redirect to the Job detail (Index) action/view for the new Job.
            if (ModelState.IsValid)
            {
                Job newJob = new Job
                {
                    Name = ;

                };
            return Redirect(string.Format("/Job?={0}", id));
            }

            return View(newJobViewModel);
            
        }
    }

