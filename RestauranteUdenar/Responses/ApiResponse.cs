using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Responses
{
    public class ApiResponse<T>
    {
        public bool success { get; set; }
        public string message { get; set; }
        public T data { get; set; }
        public string error { get; set; }
    }
}
