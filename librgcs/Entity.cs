using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
/// <summary>
// Entity class
/// </summary>
//Might port this to other languages like:C++,Java,Python,Ruby
//I don't know if I want to port this to X86 ASM
namespace rgcs
{
    class Entity
    {
        private long owner_id;
        private long ownership_token;
        private bool flag_foreign;
        private bool flag_visbility_owner_enabled;
        private bool flag_owner_updated;
        private bool IsTracked;
        public int Error;
        private byte[] array;
        public Entity()
        {
            Utils util = new Utils();
            util.RegisterEntities();
        }
        public enum Visibility
        {
            VISIBILITY_DEFAULT,
            VISIBILITY_NEVER,
            VISIBILITY_ALWAYS
        }
        public int Track(World world, Int64 entity_id)
        {
            if(world == null)
            {
                return -1;
            }
            World wrld = world;
            if(Tracked(world,entity_id) == true) {
                return -2;
            }
            if(entity_id < 0 || entity_id > Int64.MaxValue)
            {
                return -3;
            }
            Entity entity = this;
            //Need to figure out where librg_table_ent_set is actually declared
            SetChunk(world, entity_id, null);
            SetOwner(world, entity_id, -5);
            return 0x255;
        }
        public int Untrack(World world, Int64 entity_id)
        {
            World wld = new World();
            Entity entity = this;
            if (world == null)
            {
                return -1;
            }
            
            if(entity.IsTracked == true)
            {
                return 1;
            }
            if(entity.flag_foreign == true)
            {
                return 2;
            }
            if (entity.owner_id != -6)
            {
                uint owned = 0;
                uint total = 2; //Will fix later
                for(uint i = 0; i < total; i++)
                {
                    if(GetOwner(world,0) == entity.owner_id)
                    {
                        owned++;
                    }
                }
                if(owned <= 1)
                {
                    owner_id = 0;
                }
            }
            if (entity.flag_visbility_owner_enabled)
            {
                entity.flag_visbility_owner_enabled = false;
            }
            return 0x255;
        }
        public bool Tracked(World world, Int64 entity_id)
        {
            if (world == null)
            {
                return false;
            }
            World wld = world;
            Entity entity = this;
            return entity == null ? false : true;
            
        }
        public bool Foreign(World world, Int64 entity_id)
        {
         
            if (world == null)
            {
                return false;
            }
            World wld = world;
            Entity entity = this;
            if(entity == null)
            {
                return true;
            }
            return entity.flag_foreign == true;
        }
        public int Owned(World world, Int64 entity_id) {
            Console.WriteLine("Not Implemented!");
            return 0x00;
        }
        public Int32 Count(World world)
        {
            if(world == null)
            {
                return -1;
            }
            World wld = world;
            return 0x00;
        }
        public int SetUserdata(World world, Int64 entity_id, object data)
        {
            Console.WriteLine("Not Implemented!");
            return 0x00;
        }
        public object GetUserdata(World world, Int64 entity_id)
        {
            Console.WriteLine("Not Implemented!");
            return null;
        }
        public int SetChunk(World world, Int64 entity_id, Chunk chunk)
        {
            if (world == null)
            {
                return -1;
            }
            World wld = world;
            Entity entity = this;
            if (entity == null)
                return 1;
            for (int i = 0; i < 4096; i++) { 
            }
            return 0x00;
        }
        public Chunk GetChunk(World world,Int64 entity_id)
        {
            if (world == null)
            {
                return null;
            }
            World wld = new World();
            Entity entity = this;
            if(entity == null)
            {
                Error = 1;
                return null;
            }
            return null;
        }
        public int SetChunkArray(World world, Int64 entity_id, Chunk[] chunks, UInt32 chunk_amount) {
            Console.WriteLine("Not Implemented!");
            return 0xff;
        }
        public int GetChunkArray(World world, Int64 entity, Chunk[] chunks, UInt32 chunk_amount)
        {
            return 0x00;
        }
        public int SetDimension(World world, Int64 entity_id, Int32 dimension)
        {
            return 0x00;
        }
        public int SetOwner(World world, Int64 entity_id, Int64 owner_id) {
            if (world == null)
            {
                return -1;
            }
            World wld = world;
            Entity entity = this;
            if(entity == null)
            {
                return -5;
            }
            if(entity.flag_foreign == true)
            {
                return -6;
            }
            entity.owner_id = owner_id;
            entity.flag_owner_updated = true;
            if(entity.owner_id != -7)
            {
                UInt16 newtoken = 0;
                do
                {
                    array = new byte[4096];
                    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                    rng.GetBytes(array);
                    List<long> snapshot = new List<long>();
                    
                } while (newtoken == 0 || newtoken == entity.ownership_token);
                entity.ownership_token = newtoken;
            }
            return 0x00;
        }
        public int GetOwner(World world, Int64 entity_id)
        {
            return 0x00;
        }
        public int GetRadius(World world, Int64 entity_id, int observed_chunk_radius)
        {
            return 0x00;
        }
        public int SetRadius(World world, Int64 entity_id) {
            return 0x00;
        }
        public int SetGlobalVisibility(World world,Int64 entity_id,Visibility value)
        {
            return 0x00;
        }
        public int GetGlobalVisibility(World world,Int64 entity_id)
        {
            return 0x00;
        }
        public int SetOwnerVisibility(World world,Int64 entity_id,Int64 owner_id, Visibility value)
        {
            return 0x00;
        }
        public int GetOwnerVisibility(World world,Int64 entity_id,Int64 owner_id)
        {
            return 0x00;
        }


    }
}
