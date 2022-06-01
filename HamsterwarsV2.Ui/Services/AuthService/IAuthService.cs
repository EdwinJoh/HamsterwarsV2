using SharedHelpers;
using SharedHelpers.DataTransferObjects;

namespace HamsterwarsV2.Ui.Services.AuthService;
/// <summary>
/// Interface for our authentication for the client side
/// </summary>
public interface IAuthService
{
    Task<ServiceResponse<int>> Register(UserRegister request);
    Task<ServiceResponse<string>> Login(UserLogin request);
}
