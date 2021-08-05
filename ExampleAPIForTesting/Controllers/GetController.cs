//using Dapper;
using ExampleAPIForTesting.Models;
using ExampleAPIForTesting.Models.Response;
using ExampleAPIForTesting.Models.Response_and_Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;


namespace ExampleAPIForTesting.Controllers
{
    public class GetController : ApiController
    {
        CQMsolutionEntities db = new CQMsolutionEntities();
        CqmEhrReporting_productionEntities db1 = new CqmEhrReporting_productionEntities();

        [HttpGet]
        [Route("GetReportByUserid")]
        public ListDataResponse<SpGetOverallReports_ByRanUserID_Result> Get_ReportByUserid()
        {
            ListDataResponse<SpGetOverallReports_ByRanUserID_Result> response = new ListDataResponse<SpGetOverallReports_ByRanUserID_Result>();
            try
            {
                List<SpGetOverallReports_ByRanUserID_Result> data = db.SpGetOverallReports_ByRanUserID(2).ToList();
                if (data != null)
                {
                    response.ListResult = data;
                    response.IsSuccess = true;
                    response.AffectedRecords = data.Count;
                    response.EndUserMessage = "Get OverallReport Details Successfully";
                }
                else
                {
                    response.IsSuccess = true;
                    response.AffectedRecords = 0;
                    response.EndUserMessage = "No Data Found";
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.AffectedRecords = 0;
                response.EndUserMessage = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
                response.Exception = ex;
            }
            return response;
        }


        [HttpPost]
        [Route("GetDetailsReport")]
        public ListDataResponse<Sp_Get_Main_DetailReport_Result> Get_Main_DetailReport(upsertGet_Main_DetailReport res)
        {
            ListDataResponse<Sp_Get_Main_DetailReport_Result> response = new ListDataResponse<Sp_Get_Main_DetailReport_Result>();
            ListDataResponse<Sp_Measure_SubDetails_Result> listDataResponse = new ListDataResponse<Sp_Measure_SubDetails_Result>();
            

            try
            {
                List<Sp_Measure_SubDetails_Result> data1 = db.Sp_Measure_SubDetails(res.reportID, res.PracticeName, res.bundle).ToList();
                List<Sp_Get_Main_DetailReport_Result> data = db.Sp_Get_Main_DetailReport(res.reportID, res.PracticeName, res.bundle).ToList();
                if (data != null)
                {
                    response.ListResult = data;
                    response.IsSuccess = true;
                    response.AffectedRecords = data.Count;
                    response.EndUserMessage = "Get Main_DetailReport Details Successfully";
                   if (data1 != null) { 
                    listDataResponse.ListResult = data1;
                    listDataResponse.IsSuccess = true;
                    listDataResponse.AffectedRecords = data1.Count;
                    listDataResponse.EndUserMessage = "Get sub  Details Successfully";

                    }
                    else
                    {
                        listDataResponse.IsSuccess = true;
                        listDataResponse.AffectedRecords = 0;
                        listDataResponse.EndUserMessage = "No Data Found";
                    }
                    


                }
                else
                {
                    response.IsSuccess = true;
                    response.AffectedRecords = 0;
                    response.EndUserMessage = "No Data Found";
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.AffectedRecords = 0;
                response.EndUserMessage = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
                response.Exception = ex;
            }
            return response;
        }

        [HttpPost]
        [Route("GetSubDetailsReport")]
        public ListDataResponse<Sp_Measure_SubDetails_Result> Get_SubMain_DetailReport(upsertGet_Main_DetailReport res)
        {
            ListDataResponse<Sp_Measure_SubDetails_Result> response = new ListDataResponse<Sp_Measure_SubDetails_Result>();
            try
            {
                List<Sp_Measure_SubDetails_Result> data = db.Sp_Measure_SubDetails(res.reportID, res.PracticeName, res.bundle).ToList();

                if (data != null)
                {
                    
                    response.ListResult = data;
                    response.IsSuccess = true;
                    response.AffectedRecords = data.Count;
                    response.EndUserMessage = "Get Main_DetailReport Details Successfully";
                }
                else
                {
                    response.IsSuccess = true;
                    response.AffectedRecords = 0;
                    response.EndUserMessage = "No Data Found";
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.AffectedRecords = 0;
                response.EndUserMessage = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
                response.Exception = ex;
            }
            return response;
        }


        [HttpPost]
        [Route("GetBasicReportInfo")]
        public ListDataResponse<Sp_Get_Practice_BasicReport_Info_Result> Get_BasicReportInfo(upsertGetBasicReportInfo_byReportID_PracticeID res)
        {
            ListDataResponse<Sp_Get_Practice_BasicReport_Info_Result> response = new ListDataResponse<Sp_Get_Practice_BasicReport_Info_Result>();
            try
            {
                List<Sp_Get_Practice_BasicReport_Info_Result> data = db.Sp_Get_Practice_BasicReport_Info(res.practiceID, res.reportID).ToList();
                if (data != null)
                {
                    response.ListResult = data;
                    response.IsSuccess = true;
                    response.AffectedRecords = data.Count;
                    response.EndUserMessage = "Get OverallReport Details Successfully";
                }
                else
                {
                    response.IsSuccess = true;
                    response.AffectedRecords = 0;
                    response.EndUserMessage = "No Data Found";
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.AffectedRecords = 0;
                response.EndUserMessage = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
                response.Exception = ex;
            }
            return response;
        }


        [HttpPost]
        [Route("GetDashBoardReport")]
        public ListDataResponse<SpGetDashBoard_Report_Result> Get_DashBoardReport(upsertGetDashBoardReport res)
        {
            ListDataResponse<SpGetDashBoard_Report_Result> response = new ListDataResponse<SpGetDashBoard_Report_Result>();
            try
            {
                List<SpGetDashBoard_Report_Result> data = db.SpGetDashBoard_Report(res.reportID, res.BundleYear, res.BundleType).ToList();
                if (data != null)
                {
                    response.ListResult = data;
                    response.IsSuccess = true;
                    response.AffectedRecords = data.Count;
                    response.EndUserMessage = "Get OverallReport Details Successfully";
                }
                else
                {
                    response.IsSuccess = true;
                    response.AffectedRecords = 0;
                    response.EndUserMessage = "No Data Found";
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.AffectedRecords = 0;
                response.EndUserMessage = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
                response.Exception = ex;
            }
            return response;
        }



        [HttpGet]
        [Route("GetProviders")]
        public ListDataResponse<Sp_GetProviders_Result> GetProviders()
        {
            ListDataResponse<Sp_GetProviders_Result> response = new ListDataResponse<Sp_GetProviders_Result>();
            try
            {
                List<Sp_GetProviders_Result> data = db1.Sp_GetProviders().ToList(); ;
                if (data != null)
                {
                    response.ListResult = data;
                    response.IsSuccess = true;
                    response.AffectedRecords = data.Count;
                    response.EndUserMessage = "Get  Details Successfully";
                }
                else
                {
                    response.IsSuccess = true;
                    response.AffectedRecords = 0;
                    response.EndUserMessage = "No Data Found";
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.AffectedRecords = 0;
                response.EndUserMessage = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
                response.Exception = ex;
            }
            return response;
        }




        [HttpPost]
        [Route("Creatreport")]
        public ListDataResponse<dynamic> CreateReport(upsertCreateReport res)
        {
            ListDataResponse<dynamic> response = new ListDataResponse<dynamic>();
            try
            {
                var data = db1.SP_Report_Creation(res.Description, res.StartDate, res.EndDate,res.BundleYear,res.PracticeLocation,res.ProviderID,res.MeasureList,res.RanByUserID);
                if (data > 0)
                {
                    //response.ListResult = res;
                    response.IsSuccess = true;
                    response.AffectedRecords = 1;
                    response.EndUserMessage = "Report Added Successfully";
                }
                else
                {
                    response.IsSuccess = false;
                    response.AffectedRecords = 0;
                    response.EndUserMessage = "Report not created";
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.AffectedRecords = 0;
                response.EndUserMessage = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
                response.Exception = ex;
            }
            return response;
        }
        [HttpPost]
        [Route("UserLogin")]
        public ListDataResponse<dynamic> UserLogin(userLogin res)
        {
            

            ListDataResponse<dynamic> response = new ListDataResponse<dynamic>();
            try
            {
                //var Obj = db.Sp_Login(res.UserName, res.Password).ToList<Sp_Login_Result>().FirstOrDefault();
                //var data = db.Sp_Login(res.UserName, res.Password);

                var data = db.User_Login.Where(x => x.UserName == res.UserName && x.Password == res.Password).FirstOrDefault();

                if(data!= null)
                {
                    //response.ListResult = res;
                    response.IsSuccess = true;
                    response.AffectedRecords = 1;
                    response.EndUserMessage = "Login Successfully";
                }
                else
                {
                    response.IsSuccess = false;
                    response.AffectedRecords = 0;
                    response.EndUserMessage = "Invalid UserName and Password";
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.AffectedRecords = 0;
                response.EndUserMessage = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
                response.Exception = ex;
            }
            return response;
        }














    }
}
