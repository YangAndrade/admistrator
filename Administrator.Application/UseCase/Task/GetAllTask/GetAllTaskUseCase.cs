using Admistrator.Communication.Responses;

namespace Administrator.Application.UseCase.Task.GetAllTaskById
{
    public class GetAllTaskUseCase
    {
        public ResponseAllTaskJson Execute()
        {
            return new ResponseAllTaskJson
            {
                Tasks = new List<ResponseResumeTaskJson>
                {
                    new ResponseResumeTaskJson
                    {
                        Id = 1,
                        Name = "Ajudar o chefe",
                        Description = "Tem que ajudar o chefe!"
                    }
                }
            };
        }
    }
}
