using rgcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    class Utils
    {
        private List<Entity> Entities;
        void RegisterEntities()
        {
          
        }
        void RegisterCustomEntities(Entity[] entities)
        {
            for (int i = 0; i < entities.Length - 1; i++)
            {
                Entities.Add(entities[i]);
            }
        }
       
    }
}
