using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NDSI_CanvasAPIConsumer.Model.RAW
{
    public class RAW_Course
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("grading_standard_id")]
        public long? GradingStandardId { get; set; }

        [JsonProperty("is_public", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsPublic { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("course_code")]
        public string CourseCode { get; set; }

        [JsonProperty("default_view")]
        public string DefaultView { get; set; }

        [JsonProperty("root_account_id")]
        public long RootAccountId { get; set; }

        [JsonProperty("enrollment_term_id")]
        public long EnrollmentTermId { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("grade_passback_setting")]
        public string GradePassbackSetting { get; set; }

        [JsonProperty("end_at", NullValueHandling = NullValueHandling.Ignore)]
        public string EndAt { get; set; }

        [JsonProperty("public_syllabus")]
        public bool PublicSyllabus { get; set; }

        [JsonProperty("public_syllabus_to_auth")]
        public bool PublicSyllabusToAuth { get; set; }

        [JsonProperty("storage_quota_mb")]
        public long StorageQuotaMb { get; set; }

        [JsonProperty("is_public_to_auth_users")]
        public bool IsPublicToAuthUsers { get; set; }

        [JsonProperty("homeroom_course")]
        public bool HomeroomCourse { get; set; }

        [JsonProperty("course_color")]
        public string CourseColor { get; set; }

        [JsonProperty("friendly_name")]
        public string FriendlyName { get; set; }

        [JsonProperty("apply_assignment_group_weights")]
        public bool ApplyAssignmentGroupWeights { get; set; }

        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }

        //[JsonProperty("calendar")]
        //public Dictionary<string, string> Calendar { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("blueprint")]
        public bool Blueprint { get; set; }

        [JsonProperty("template")]
        public bool Template { get; set; }

        [JsonProperty("sis_course_id")]
        public string SisCourseId { get; set; }

        [JsonProperty("sis_import_id")]
        public string SisImportId { get; set; }

        [JsonProperty("integration_id")]
        public string IntegrationId { get; set; }

        [JsonProperty("hide_final_grades")]
        public bool HideFinalGrades { get; set; }

        [JsonProperty("workflow_state")]
        public string WorkflowState { get; set; }

        [JsonProperty("restrict_enrollments_to_course_dates")]
        public bool RestrictEnrollmentsToCourseDates { get; set; }

        [JsonProperty("overridden_course_visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string OverriddenCourseVisibility { get; set; }
    }
}
