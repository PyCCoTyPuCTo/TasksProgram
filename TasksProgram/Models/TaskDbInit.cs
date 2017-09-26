using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TasksProgram.Models
{
    public class TaskDbInit : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed(TaskContext db)
        {
            db.Tasks.Add(new Task { ID = 1, Title = "ddddd", Record = "dddd" });
            db.Tasks.Add(new Task { ID = 2, Title = "ddddds", Record = "dddd1" });
            db.Tasks.Add(new Task { ID = 3, Title = "ddddds", Record = "dddd22" });
        }
    }
}