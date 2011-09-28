using System;
using System.Linq;
using SlashRoll.DataModel;
using SlashRoll.Services.Contracts;
using SlashRoll.Services.HelperObjects;

namespace SlashRoll.Services.Implementations
{
    public class Roll : IRoll
    {

        public int SlashRoll(string username)
        {
            SteelFlowEntities steelFlowContext = new SteelFlowEntities();
            SlashRollContext slashRollContext = new SlashRollContext();

            Die die = new Die(100);

            int result = die.roll();
            User currentUser = (from u in slashRollContext.Users
                         where u.UserName == username
                         select u).SingleOrDefault();

            if (currentUser != null)
            {
                AddRollToUser(currentUser, result, slashRollContext);
            }
            else
            {
                aspnet_Users webUser = (from u in steelFlowContext.aspnet_Users
                             where u.UserName == username
                             select u).SingleOrDefault();

                if (webUser != null)
                {
                    currentUser = slashRollContext.Users.Add(new User
                                            {
                                                UserId = webUser.UserId,
                                                UserName = webUser.UserName
                                            });

                    slashRollContext.SaveChanges();

                    AddRollToUser(currentUser,result,slashRollContext);
                }
                else
                {
                    throw new NullReferenceException("Some database error stuff happend... Could not find you desired user.");
                }
            }

            return result;
        }

        private static void AddRollToUser(User currentUser, int result, SlashRollContext slashRollContext)
        {
            slashRollContext.Rolls.Add(new DataModel.Roll
                                            {
                                                Id = Guid.NewGuid(),
                                                Result = result,
                                                User = currentUser
                                            });
            slashRollContext.SaveChanges();
        }
    }
}