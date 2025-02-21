using Admistrator.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator.Application.UseCase.Task.GetTaskById
{
    public class GetTaskByIdUseCase
    {
        public ResponseTaskJson Execute(int Id)
        {
            return new ResponseTaskJson
            {
                Id = 1,
                Name = "Avaliação",
                Description = "Avaliar Itens",
                Limit = new DateTime(year: 2025, month: 10, day: 5),
                Priority = Admistrator.Communication.Enums.Priority.alta,
                Status = Admistrator.Communication.Enums.Status.andamento
            };
        }
    }
}
