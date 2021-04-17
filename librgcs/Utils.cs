using rgcs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    class Utils
    {
        private List<Entity> Entities = new List<Entity>();
        private Player player = new Player();
        private DummyEntity dummy = new DummyEntity();
        public void RegisterEntities()
        {
            Entities.Add(player);
            Entities.Add(dummy);
           
        }
        public void RegisterCustomEntities(Entity[] entities)
        {
            for (int i = 0; i < entities.Length - 1; i++)
            {
                Entities.Add(entities[i]);
            }
        }
        
    }
}
