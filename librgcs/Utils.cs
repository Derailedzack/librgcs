using rgcs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Utils
    {
        private List<Entity> Entities;
        private Player player;
        private DummyEntity dummy;
        public void RegisterEntities()
        {
            player = new Player();
            dummy = new DummyEntity();
            Entities = new List<Entity>();
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
        public Entity GetEntityAt(int entity_id)
        {
            return Entities.ElementAt(entity_id);
        }
        public int GetNumOfEntitiesInList()
        {
            return Entities.Count;
        }
    }
}
