using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET.Request;
using Alexa.NET.RequestType;
using Alexa.NET.Response;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AlexaSkillProject
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        /// 
        private static HttpClient _httpClient;
        public const string INVOCATION_NAME = "Country Info";

        public Function()
        {
            _httpClient = new HttpClient();
        }
       
        public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            SkillResponse response = new SkillResponse();
            response.Response = new ResponseBody();

            //return input?.ToUpper();
        }
    }
}
