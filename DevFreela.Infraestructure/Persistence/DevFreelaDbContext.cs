using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infraestructure.Persistence
{
    public class DevFreelaDbContext
    {

        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu Projeco ASPNET Core 1","Descricao 1",1,1,10000),
                new Project("Meu Projeco ASPNET Core 2","Descricao 2",1,1,20000),
                new Project("Meu Projeco ASPNET Core 2","Descricao 3",1,1,30000)
            };

            Users = new List<User>
            {
                new User("Guilherme Bastos", "gui@gmail.com", new DateTime(2002,1,1)),
                new User("Jacqueline Bastos", "jac@gmail.com", new DateTime(1996,1,1)),
                new User("Manoela Santos", "gui@gmail.com", new DateTime(2002,1,1))
            };
            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }
        public List<Project> Projects { get; set; }

        public List<User> Users { get; set; }

        public List<Skill> Skills { get; set; }

        public List<ProjectComment> ProjectComments { get; set; }
    }
}
