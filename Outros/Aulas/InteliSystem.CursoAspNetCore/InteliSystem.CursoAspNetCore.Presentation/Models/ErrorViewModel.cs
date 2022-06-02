using System;

namespace InteliSystem.CursoAspNetCore.Presentation.Models
{
    public class ErrorViewModel
    {
        public string RequestId
        {
            get; set;
        }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
