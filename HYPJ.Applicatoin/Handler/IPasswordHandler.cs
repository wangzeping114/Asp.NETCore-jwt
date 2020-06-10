namespace HYPJ.Applicatoin.Handler
{
    public interface IPasswordHandler
    {
        string GenerateAppUserPwdHash(string salt, string pwd);

        (string salt, string pwdhash) GenerateEncryptPassword(string pwd);

        bool VerifyHashedPassword(string hashedPassword, string providedSalt,
            string providedPassword);
    }
}
