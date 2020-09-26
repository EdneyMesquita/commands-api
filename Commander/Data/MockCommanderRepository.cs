using System;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 1, HowTo = "Boild an egg", Line = "Boil Water", Platform = "Kettle & Pan" },
                new Command { Id = 2, HowTo = "Cut bread", Line = "Get a knife", Platform = "Knife & chopping board" },
                new Command { Id = 3, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettle & Cut" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 1, HowTo = "Boild an egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }
    }
}
