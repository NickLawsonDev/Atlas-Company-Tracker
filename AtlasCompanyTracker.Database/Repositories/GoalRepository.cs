using AtlasCompanyTracker.Database.Contexts;
using AtlasCompanyTracker.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasCompanyTracker.Database.Repositories
{
    public class GoalRepository
    {
        public static GoalModel GetGoal(int id)
        {
            using (var db = new GoalContext())
            {
                return db.Goals.Where(x => x.ID == id).FirstOrDefault();
            }
        }

        public static IEnumerable<GoalModel> GetGoals()
        {
            using (var db = new GoalContext())
            {
                return db.Goals.ToList();
            }
        }

        public static bool CreateNewGoal(GoalModel Goal)
        {
            if (Goal == null) return false;

            using (var db = new GoalContext())
            {
                db.Goals.Add(Goal);
                db.SaveChanges();
                return true;
            }
        }

        public static bool DeleteGoal(int id)
        {
            if (id <= 0) return false;

            using (var db = new GoalContext())
            {
                var goal = db.Goals.Where(x => x.ID == id).FirstOrDefault();
                db.Goals.Remove(goal);
                db.SaveChanges();
                return true;
            }
        }

        public static bool UpdateGoal(int id)
        {
            if (id <= 0) return false;

            using (var db = new GoalContext())
            {
                var goal = db.Goals.Where(x => x.ID == id).FirstOrDefault();
                var oldGoal = db.Goals.Where(x => x.ID == goal.ID).FirstOrDefault();
                if (oldGoal == null) return false;

                oldGoal = goal;
                db.Goals.Update(oldGoal);
                db.SaveChanges();
                return true;
            }
        }
    }
}
