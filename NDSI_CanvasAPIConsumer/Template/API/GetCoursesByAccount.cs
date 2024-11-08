using NDSI_CanvasAPIConsumer.Model.RAW;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace NDSI_CanvasAPIConsumer.Template.API
{
    public class GetCoursesByAccount : APIConnect
    {
        private int pageNum;
        public GetCoursesByAccount(int pageNum)
        {
            this.pageNum = pageNum;
        }

        public override async Task<object> TreatResponse(HttpResponseMessage response)
        {
            if (response.StatusCode != System.Net.HttpStatusCode.OK) throw new Exception("Bad Request");

            //Treat response to see only the content
            HttpContent httpContent = response.Content;
            string content = await httpContent.ReadAsStringAsync();

            //Get content inside model of needed info
            List<RAW_Course> courses = JsonConvert.DeserializeObject<List<RAW_Course>>(content);

            return courses;
        }

        protected override string Params()
        {
            return "?page=" + pageNum;
        }

        protected override string URLComplement()
        {
            return "/accounts/1/courses";
        }
    }
}
