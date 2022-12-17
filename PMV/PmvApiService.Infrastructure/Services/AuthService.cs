using System.Security.Cryptography;
using System.Text;
using PMV.PmvApiService.Application.Interfaces.Authentications;
using PMV.PmvApiService.Application.DTO.Login;
using PMV.PMVApiService.SupportContext.DTO;
using PMV.PMVApiService.SupportContext.Query;

namespace PMV.PmvApiService.Infrastructure.Services
{

    /**
    Provide Authentication Service that encapsulate all the Authentication Logic
    
    */
    public class AuthService : IAuthService
    {
        private readonly UserAuthCommand _userAuthCommand;


        public AuthService(UserAuthCommand userAuthCommand)
        {
            _userAuthCommand = userAuthCommand;

        }

        public async Task<bool> Login(AuthRequest request)
        {
            _userAuthCommand.EmployeeCode = request.EmployeeCode;
            AuthResult? result = await _userAuthCommand.ExecuteAsync();
            if (result == null)
                return false;
            string enc = EncodePassword(request.Password);
            if (enc != result.EmpPasswd) {
                return false;
            }


            return true;
        }

        public string EncodePassword(string originalPassword)
        {
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            encodedBytes = md5.ComputeHash(originalBytes);
            
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < encodedBytes.Length; i++)  
            {  
                //change it into 2 hexadecimal digits  
                //for each byte  
                builder.Append(encodedBytes[i].ToString("x2"));  
            }  

            //Convert encoded bytes back to a ‘readable’ string
            return builder.ToString();
        }


    }
}