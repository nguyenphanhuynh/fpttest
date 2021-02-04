using System;
using System.Collections.Generic;
using System.Text;

namespace NPH.Services.Interface
{
    public interface IWeatherStack
    {
        public void Execute(string serviceUrl, int zipCode);
    }
}
