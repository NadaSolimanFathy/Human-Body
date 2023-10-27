using Human_Body.Model;

namespace Human_Body.Interfaces
{
    public interface IHumanBodyRepository
    {

        public  HumanBody GetTheOrganInfo(string name);

    }
}
