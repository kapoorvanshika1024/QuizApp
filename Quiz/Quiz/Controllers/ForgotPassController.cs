using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Handles forgotten password functionality
namespace Quiz.Controllers
{
    internal class ForgotPassController
    {
        // Retrieves user based on email and phone
        public static User getUser(string email, string phone)
        {
            User user = null;
            using (QuizDBEntitie context = new QuizDBEntitie())
            {
                // Find user by email
                user = context.Users.FirstOrDefault(u => u.Email == email);
                // If user not found or phone doesn't match, set user to null
                if (user == null || user.Phone != phone)
                    user = null;
                return user;
            }
        }

        // Updates user password in the database
        public static void updatePassword(User user,string newPass)
        {
            using (QuizDBEntitie context = new QuizDBEntitie())
            {
                // Find user in the database
                var us = context.Users.FirstOrDefault(u => u.ID == user.ID);

                // Update the password
                us.Password = newPass;
                context.SaveChanges();
            }
        }
    }
}
