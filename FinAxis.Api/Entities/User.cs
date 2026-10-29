using FinAxis.Api.Dtos;

namespace FinAxis.Api.Entities
{
    public class User
    {
        public int ID { get; set; }
        public UserSignUpDTO Data { get; set; } = new UserSignUpDTO();


    }
}
