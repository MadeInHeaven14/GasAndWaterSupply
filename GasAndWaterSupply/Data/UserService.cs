using MongoDB.Driver;

namespace GasAndWaterSupply.Data
{
    public class UserService
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("UsersDB");
        static IMongoCollection<User> collection = database.GetCollection<User>("Users");
        public string Login = string.Empty;
        public string FullName = string.Empty;
        public string Role = string.Empty;
        public string Department = string.Empty;
        public string Email = string.Empty;
        public string Phone = string.Empty;
        public string Password = string.Empty;
        public string Developer = string.Empty;
        public string OGRN = string.Empty;
        public string INN = string.Empty;
        public string KPP = string.Empty;
        public string Address = string.Empty;
        public string Supervisor = string.Empty;
        public string Organization = string.Empty;
        public string Director = string.Empty;
        public string ChiefEngineer = string.Empty;

        public void Save(User NewUser)
        {
            var MyUser = collection.Find(x => x._id == NewUser._id).FirstOrDefault();
            if (MyUser == null)
            {
                collection.InsertOne(NewUser);
            }
        }

        public void SignIn(string login)
        {
            var MyUser = collection.Find(x => x.Login == login).FirstOrDefault();
            Login = MyUser.Login;
            FullName = MyUser.FullName;
            Role = MyUser.Role;
            Department = MyUser.Department;
            Email = MyUser.Email;
            Phone = MyUser.Phone;
            Password = MyUser.Password;
            if (Role == "Застройщик")
            {
                Developer = MyUser.Developer;
                OGRN = MyUser.OGRN;
                INN = MyUser.INN;
                KPP = MyUser.KPP;
                Address = MyUser.Address;
                Supervisor = MyUser.Supervisor;
            }
            if (Role == "Проектировщик")
            {
                Organization = MyUser.Organization;
                OGRN = MyUser.OGRN;
                INN = MyUser.INN;
                KPP = MyUser.KPP;
                Address = MyUser.Address;
                Director = MyUser.Director;
                ChiefEngineer = MyUser.ChiefEngineer;
            }
            return;
        }

        public bool Find(string Login, string Password, bool isExist)
        {
            var MyUser = collection.Find(x => x.Login == Login).FirstOrDefault();
            if (MyUser != null)
            {
                isExist = true;
            }
            else
            {
                isExist = false;
            }
            return isExist;
        }

        public bool FindPassword(string Login, string Password, bool isCorrectPassword)
        {
            var MyUser = collection.Find(x => x.Login == Login).FirstOrDefault();
            if (MyUser != null)
            {
                if (MyUser.Password == Password)
                {
                    isCorrectPassword = true;
                }
                else
                {
                    isCorrectPassword = false;
                }
            }
            return isCorrectPassword;
        }
    }
}
