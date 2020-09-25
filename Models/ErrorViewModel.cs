using System;

namespace Prueba_TPersonas.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public int ID { get; set; }
    }
}
