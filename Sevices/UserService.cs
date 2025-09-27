using AutoMapper;
using Travel_Service.Helper;
using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;
using Travel_Service.Repository.IRepository;
using Travel_Service.Sevices.IServices;

namespace Travel_Service.Sevices;

public class UserService: IUserService
{
    private readonly IUserRepository _user;
    private readonly IMapper _mapper;
    //private readonly IValidator<RegisterUserRequestDto> _validator;

    public UserService(IUserRepository user, IMapper mapper)
    {
        _user = user;
        _mapper = mapper;
    }
    
    public RegisterUserResponseDetails RegisterUser(RegisterUserRequestDto dataU)
    {
        throw new NotImplementedException();
    }

    public LoginResponseDetails Login(LoginRequestDto data, JwtTokenGenerator tokenGenerator)
    {
        throw new NotImplementedException();
    }
}