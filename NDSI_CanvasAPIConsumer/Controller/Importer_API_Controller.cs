using NDSI_CanvasAPIConsumer.Model.RAW;
using NDSI_CanvasAPIConsumer.Template.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NDSI_CanvasAPIConsumer.Controller
{
    public class Importer_API_Controller
    {
        public async Task<List<RAW_Course>> GetCoursesAsync()
        {
            //Assisting variables
            bool readMore = true;
            int pageNum = 1;

            //Returnable Variable
            List<RAW_Course> courses = new List<RAW_Course>();

            //Main Code
            while (readMore)
            {
                GetCoursesByAccount getCourse = new GetCoursesByAccount(pageNum);
                try
                {
                    List<RAW_Course> newCourses = (List<RAW_Course>)getCourse.TreatResponse(await getCourse.SendGetRequestAsync()).Result;
                    if (newCourses.Count < 10 || newCourses is null) readMore = false;

                    foreach (RAW_Course course in newCourses)
                    {
                        //Console.WriteLine(course.Id + " has been imported sucessfully");
                        courses.Add(course);
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("========================== ERROR ==========================");
                    Console.WriteLine(ex.Message);
                    readMore = false;
                }
                pageNum++;
            }

            return courses;
        }
    }
}