using Newtonsoft.Json;

namespace Eshop.Application.Exceptions
{
    public class ExceptionModel
    {
      
        public Eshop.Application.Bases.ResponseDto<ExceptionModel> Response { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
