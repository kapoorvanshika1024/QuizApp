using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quiz.Controllers
{
    internal class SignInDBController
    {
        
        public static User getUser(string username, string password)
        {
            User user = null;
            using (QuizDBEntitie context = new QuizDBEntitie())
            {
               
                if (long.TryParse(username, out _))
                    user = context.Users.FirstOrDefault(u => u.Phone == username);
                else
                    user = context.Users.FirstOrDefault(u => u.Email == username);

               
                string result = checkUser(user, password);
                if (result != "")
                {   
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    user = null;
                }
                return user;
            }
        }

        private static string checkUser(User user, string password)
        {
            if (user == null)
                return "No User Found";

            if (!checkPassword(user, password))
                return "Invalid Password!";

            return "";
        }

        
        private static bool checkPassword(User user, string password)
        {
            return user.Password == password;
        }

        
        public static void setUser(User user)
        {
            using (var context = new QuizDBEntitie())
            {
                try
                {
                    context.Users.Add(user);
                    int effectedRows = context.SaveChanges();
                    if (effectedRows > 0)
                        MessageBox.Show("Signup Successful!", "Succssed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Signup Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"{ex.Message}\nSomething Wrong!", "Signup Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}