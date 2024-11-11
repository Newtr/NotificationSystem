namespace NotificationSystem.Entities
{
    public class User
    {
        public string User_Name {get; set;}
        public string User_Surname {get; set;}

        public string User_Email {get; set;}

        public string User_Phone {get; set;}
        public string User_Password {get; private set;}

        public Role User_Role {get; private set;}

        public User(string _user_name, string _user_surname, string _user_email, string _user_phone, string _password, string _user_role)
        {
            User_Name = _user_name;
            User_Surname = _user_surname;
            User_Email = _user_email;
            User_Phone = _user_phone;
            User_Password = _password;
            User_Role.Role_Name = _user_role;
        }

        public void Update_Password(string _new_password)
        {
            User_Password = _new_password;
        }
    }
}