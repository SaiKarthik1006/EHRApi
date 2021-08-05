using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAPIForTesting.Models.Response_and_Request
{

    

    public class upsertGet_Main_DetailReport
    {
        public string reportID { get; set; }
        public string PracticeName { get; set; }
        public string bundle { get; set; }
        public List<upsertGet_SubMain_DetailReport> upsertGet_SubMain_DetailReport { get; set; }


    }
    public class DetailReport
    {
        public List<upsertGet_SubMain_DetailReport> upsertGet_SubMain_DetailReport { get; set; }
        public List<upsertGet_Main_DetailReport> upsertGet_Main_DetailReport { get; set; }


    }

    public class upsertGet_SubMain_DetailReport
    {
        public string reportID { get; set; }
        public string PracticeName { get; set; }
        public string bundle { get; set; }
    }

    public class upsertGetOverallReports_byRanUserID
    {
        public int UserID { get; set; }
        
    }

   

    public class upsertGetBasicReportInfo_byReportID_PracticeID
    {
        public int reportID { get; set; }
        public int practiceID { get; set; }


    }

    

    public class upsertGetDashBoardReport
    {
        public int reportID { get; set; }
        public string BundleYear { get; set; }
        public string BundleType { get; set; }

    }
    //[Serializable]

    public class upsertCreateReport
    {
       
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string BundleYear { get; set; }
        public string PracticeLocation { get; set; }
        public string ProviderID { get; set; }
        public string MeasureList { get; set; }
        public int RanByUserID { get; set; }

        
    }
   

    public class upsertGetReport
    {
        public string C_ID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

    }

    public class userLogin
    {

        public string UserName { get; set; }
       
        public string Password { get; set; }
       
    }


}