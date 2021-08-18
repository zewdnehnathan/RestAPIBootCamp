using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIBootCamp.Dtos
{

    //Data Transfer Object
    //Can Add Other Fields here as well
    //we Also use middleware for handling messages, we dontuse default try catch 

    public class ResponseDto<T>
    {

        public List<T> Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public ResponseDto(List<T> data,string message,bool isSuccess) 
        {
            Data = data;
            message = Message;
            IsSuccess = isSuccess;
        }
        public ResponseDto(List<T> data, bool isSuccess)
        {
            Data = data;
            Message = "Success";
            IsSuccess = true;
        }
       

    }
}
