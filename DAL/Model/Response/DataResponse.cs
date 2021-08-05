using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.Response
{
    public class DataResponse
    {
        public bool IsSuccess { get; set; }
        public int AffectedRecords { get; set; }
        public string EndUserMessage { get; set; }
        // public List<ValidationItem> ValidationErrors { get; set; }
        public Exception Exception { get; set; }

        public DataResponse()
        {
            IsSuccess = false;
            AffectedRecords = 0;
            // ValidationErrors = new List<ValidationItem>();
        }
    }
    public class ListDataResponse<T> : DataResponse
    {
        public IEnumerable<T> ListResult { get; set; }

    }
    public class ValueDataResponse<T> : DataResponse
    {
        public T Result { get; set; }
    }

}
