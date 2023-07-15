using Api.DTO;

namespace Api
{
    public class SaveUserCommand
    {
        public UserDto UserDto { get; set; }

        public SaveUserCommand(UserDto userDto)
        {
            UserDto = userDto;
        }
    }
}
