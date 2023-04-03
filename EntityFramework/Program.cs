using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with ADO.NET EF *****\n");
            //int carId = AddNewRecord();
            //Console.WriteLine(carId);
            EagerLoading();
            Console.ReadLine();
        }
        private static int AddNewRecord()
        {
            // Add record to the Inventory table of the AutoLot database.
            using (var context = new JMSEntities())
            {
                try
                {
                    // Hard-code data for a new record, for testing.
                    applicant app = new applicant
                    {
                        name = "sarcastic",
                        address = "NYC",
                        email_address = "sarcastic@no-one.com",
                        marks_in_matriculation = 200,
                        marks_in_intermediate = 100,
                        marks_in_batchelor = 199,
                        applicant_gender = "m",
                        date_of_birth = new DateTime(2015, 12, 25)
                    };

                    context.applicants.Add(app);
                    context.SaveChanges();
                    // On a successful save, EF populates the database generated identity field.
                    return app.applicant_id;
                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException?.Message);
                    return 0;
                }
            }
        }
        private static void EagerLoading()
        {
            JMSEntities context = new JMSEntities();
            foreach (var applicant in context.applicants.Include ("recommended_candidates_for_job"))
            {
                if (applicant.recommended_candidates_for_job.Count() > 0)
                {
                    Console.WriteLine("candidate: {0} with the ID {1} recommended for the following jobs\n",
                                   applicant.name,
                                   applicant.applicant_id);

                    foreach (var recommendedFor in applicant.recommended_candidates_for_job)
                    {
                        Console.WriteLine(recommendedFor.job_id);
                    }
                }
                
            }
        }
    }
    
}
