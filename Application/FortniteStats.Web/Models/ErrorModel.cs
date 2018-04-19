using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FortniteStats.Web.Models
{
    public class ErrorModel
    {
        public ErrorModel()
        {
            this.Errors = new List<string>();
        }

        public List<string> Errors { get; set; }

        public static ErrorModel Factory(ModelStateDictionary modelState)
        {
            var model = new ErrorModel();

            foreach (var value in modelState.Values)
            {
                model.Errors.AddRange(value.Errors.Select(x => x.ErrorMessage));
            }

            return model;
        }
    }
}