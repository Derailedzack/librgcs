using rgcs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ClassLibrary1
{
    public class Utils
    {
        private List<Entity> Entities;
        private Player player;
        private DummyEntity dummy;
        private String Versioninfo = "0.0.0-DEV";
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
        String GetrgcsVersion()
        {
            return Versioninfo;
        }
        public void CheckForUpdate()
        {
            WebClient client = new WebClient();
            client.BaseAddress = "https://raw.githubusercontent.com/Derailedzack/librgcs/master/";
            client.OpenRead("Version.txt");
        }
    }
}
