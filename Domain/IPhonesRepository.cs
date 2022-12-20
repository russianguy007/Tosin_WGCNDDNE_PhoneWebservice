namespace Tosin_WGCNDDNE_WebServices.Domain
{
    public interface IPhonesRepository
    {
        Phone[] GetAll();
        Phone GetById(int id);
        void Delete(int id);
        void Update(Phone phone);
        int insert(Phone phone);
    }
}
