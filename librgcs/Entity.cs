﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        private int owner_id;
        private bool flag_foreign;
        private bool flag_visbility_owner_enabled;
        private bool IsTracked;
        enum Visibility
        {
            VISIBILITY_DEFAULT,
            VISIBILITY_NEVER,
            VISIBILITY_ALWAYS
        }
        int Track(World world, Int64 entity_id)
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
        int Untrack(World world, Int64 entity_id)
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
            }
            if (entity.flag_visbility_owner_enabled)
            {
                entity.flag_visbility_owner_enabled = false;
            }
            return 0x255;
        }
        bool Tracked(World world, Int64 entity_id)
        {
            return false;
        }
        int Foreign(World world, Int64 entity_id)
        {
            return 0x00;
        }
        int Owned(World world, Int64 entity_id) {
            return 0x00;
        }
        Int32 Count(World world)
        {
            return 0x00;
        }
        int SetUserdata(World world, Int64 entity_id, object data)
        {
            return 0x00;
        }
        object GetUserdata(World world, Int64 entity_id)
        {
            return null;
        }
        int SetChunk(World world, Int64 entity_id, Chunk chunk)
        {
            return 0x00;
        }
        Chunk GetChunk(World world)
        {
            return null;
        }
        int SetChunkArray(World world, Int64 entity_id, Chunk[] chunks, UInt32 chunk_amount) {
            return 0xff;
        }
        int GetChunkArray(World world, Int64 entity, Chunk[] chunks, UInt32 chunk_amount)
        {
            return 0x00;
        }
        int SetDimension(World world, Int64 entity_id, Int32 dimension)
        {
            return 0x00;
        }
        int SetOwner(World world, Int64 entity_id, Int64 owner_id) {
            return 0x00;
        }
        int GetOwner(World world, Int64 entity_id)
        {
            return 0x00;
        }
        int GetRadius(World world, Int64 entity_id, int observed_chunk_radius)
        {
            return 0x00;
        }
        int SetRadius(World world, Int64 entity_id) {
            return 0x00;
        }
        int SetGlobalVisibility(World world,Int64 entity_id,Visibility value)
        {
            return 0x00;
        }
        int GetGlobalVisibility(World world,Int64 entity_id)
        {
            return 0x00;
        }
        int SetOwnerVisibility(World world,Int64 entity_id,Int64 owner_id, Visibility value)
        {
            return 0x00;
        }
        int GetOwnerVisibility(World world,Int64 entity_id,Int64 owner_id)
        {
            return 0x00;
        }


    }
}
