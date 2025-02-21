using Admistrator.Communication.Requests;
using Admistrator.Communication.Responses;

namespace Administrator.Application.UseCase.Task.Create
{
    public class CreateUseCase
    {
        public ResponseCreateJson Execute(RequestTaskJson request)
        {
            return new ResponseCreateJson
            {
                Id = 1,
                Name = request.Name,
                Description = request.Description,
                Status = Admistrator.Communication.Enums.Status.aguardando
            };
        }
    }
}
