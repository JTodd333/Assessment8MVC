using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;


namespace Assessment8.Models
{
    public class DAL
    {
        public static MySqlConnection DB = new MySqlConnection("Server=127.0.0.1;Database=potluck;Uid=root;Pwd=abc123;");

        //
        //TEAM MEMBER FUNCTIONS
        //

        // Get All and Get One TM for RSVP
        public static List<TeamMember> GetAllTMs()
        {
            return DB.GetAll<TeamMember>().ToList();
        }
        public static TeamMember GetOneTM(int Id)
        {
            return DB.Get<TeamMember>(Id);
        }

        // Add TM/RSVP
        public static TeamMember AddTM(TeamMember tm)
        {
            DB.Insert(tm);
            return (tm);
        }

        // Update TM/RSVP Info
        public static void UpdateTM(TeamMember tm)
        {
            DB.Update(tm);
        }

        // Delete a TM/RSVP
        public static void DeleteTM(int Id)
        {
            TeamMember tm = new TeamMember();
            tm.Id = Id;
            DB.Delete<TeamMember>(tm);
        }


        //
        // DISH DB FUNCTIONS
        //

        // Get All and One Dish
        public static List<Dish> GetAllDishes()
        {
            return DB.GetAll<Dish>().ToList();
        }
        public static Dish GetOneDish(int Id)
        {
            return DB.Get<Dish>(Id);
        }

        // Add Dish
        public static Dish AddDish(Dish dish)
        {
            DB.Insert(dish);
            return dish;
        }

        // Update Dish Info
        public static void UpdateDish(Dish dish)
        {
            DB.Update(dish);
        }

        // Delete Dish
        public static void DeleteDish(int Id)
        {
            Dish dish = new Dish();
            dish.Id = Id;
            DB.Delete(dish);
        }


    }
}
