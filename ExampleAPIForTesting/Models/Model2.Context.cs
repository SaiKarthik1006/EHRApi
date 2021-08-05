﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExampleAPIForTesting.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CQMsolutionEntities : DbContext
    {
        public CQMsolutionEntities()
            : base("name=CQMsolutionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User_Login> User_Login { get; set; }
    
        public virtual ObjectResult<Sp_Get_Main_DetailReport_Result> Sp_Get_Main_DetailReport(string reportID, string practiceLocation, string bundle)
        {
            var reportIDParameter = reportID != null ?
                new ObjectParameter("ReportID", reportID) :
                new ObjectParameter("ReportID", typeof(string));
    
            var practiceLocationParameter = practiceLocation != null ?
                new ObjectParameter("PracticeLocation", practiceLocation) :
                new ObjectParameter("PracticeLocation", typeof(string));
    
            var bundleParameter = bundle != null ?
                new ObjectParameter("Bundle", bundle) :
                new ObjectParameter("Bundle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Get_Main_DetailReport_Result>("Sp_Get_Main_DetailReport", reportIDParameter, practiceLocationParameter, bundleParameter);
        }
    
        public virtual ObjectResult<Sp_Get_Practice_BasicReport_Info_Result> Sp_Get_Practice_BasicReport_Info(Nullable<int> practiceID, Nullable<int> reportID)
        {
            var practiceIDParameter = practiceID.HasValue ?
                new ObjectParameter("PracticeID", practiceID) :
                new ObjectParameter("PracticeID", typeof(int));
    
            var reportIDParameter = reportID.HasValue ?
                new ObjectParameter("ReportID", reportID) :
                new ObjectParameter("ReportID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Get_Practice_BasicReport_Info_Result>("Sp_Get_Practice_BasicReport_Info", practiceIDParameter, reportIDParameter);
        }
    
        public virtual ObjectResult<Sp_Measure_SubDetails_Result> Sp_Measure_SubDetails(string reportID, string practiceLocation, string bundle)
        {
            var reportIDParameter = reportID != null ?
                new ObjectParameter("ReportID", reportID) :
                new ObjectParameter("ReportID", typeof(string));
    
            var practiceLocationParameter = practiceLocation != null ?
                new ObjectParameter("PracticeLocation", practiceLocation) :
                new ObjectParameter("PracticeLocation", typeof(string));
    
            var bundleParameter = bundle != null ?
                new ObjectParameter("Bundle", bundle) :
                new ObjectParameter("Bundle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Measure_SubDetails_Result>("Sp_Measure_SubDetails", reportIDParameter, practiceLocationParameter, bundleParameter);
        }
    
        public virtual ObjectResult<SpGetDashBoard_Report_Result> SpGetDashBoard_Report(Nullable<int> reportID, string bundle, string bundleType)
        {
            var reportIDParameter = reportID.HasValue ?
                new ObjectParameter("ReportID", reportID) :
                new ObjectParameter("ReportID", typeof(int));
    
            var bundleParameter = bundle != null ?
                new ObjectParameter("Bundle", bundle) :
                new ObjectParameter("Bundle", typeof(string));
    
            var bundleTypeParameter = bundleType != null ?
                new ObjectParameter("BundleType", bundleType) :
                new ObjectParameter("BundleType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpGetDashBoard_Report_Result>("SpGetDashBoard_Report", reportIDParameter, bundleParameter, bundleTypeParameter);
        }
    
        public virtual ObjectResult<SpGetOverallReports_ByRanUserID_Result> SpGetOverallReports_ByRanUserID(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpGetOverallReports_ByRanUserID_Result>("SpGetOverallReports_ByRanUserID", userIDParameter);
        }
    }
}