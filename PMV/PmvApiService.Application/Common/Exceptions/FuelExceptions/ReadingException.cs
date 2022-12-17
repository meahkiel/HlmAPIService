using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmvApiService.Application.Common.Exceptions.FuelExceptions
{
    public class ReadingException : Exception
    {
        public ReadingException() 
        {

        }

        public override string Message => "Current reading must always ahead from the previous reading";
    }
}