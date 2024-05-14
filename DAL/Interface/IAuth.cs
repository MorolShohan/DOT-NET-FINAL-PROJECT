namespace DAL.Interface
{
    public interface IAuth<Ret>
    {
        Ret Authenticate(string email, string password);
        Ret Authenticate(string email);
        Ret updatepass(string email, string password);
    }
}
