using System;

namespace rgcs
{
    public class World
    {
        private bool vaild;
        private Vector3<UInt32> worldsize;
        private Vector3<UInt32> chunksize;
        private Vector3<Int32> chunkoffset;
        private Action<World, Event> event_handler_func;
        private object userdata;
        public World()
        {
            vaild = true;
            worldsize = new Vector3<UInt32>(16, 16, 16);
            chunksize = new Vector3<UInt32>(256, 256, 256);
            chunkoffset = new Vector3<Int32>(32768, 0, 32767);
        }
        public void Destroy()
        {
            worldsize = null;
            chunksize = null;
            chunkoffset = null;
            vaild = false;
        }
        public bool Vaild()
        {
            return true;
        }
        public void SetUserdata(object data)
        {
            userdata = data;
        }
        public object GetUserdata()
        {
            return userdata;
        }
        public void SetChuckAmount(UInt32 x, UInt32 y, UInt32 z){
            worldsize.SetX(x == 0 ? 1 : x);
            worldsize.SetY(y == 0 ? 1 : y);
            worldsize.SetZ(z == 0 ? 1 : z);
        }
        public void SetChuckAmount(Vector3<UInt32> vector) {
            worldsize = vector;
        }
        public Vector3<UInt32> GetChuckAmount()
        {
            return worldsize;
        }
        public void SetChunkSize(UInt32 x, UInt32 y, UInt32 z)
        {
            chunksize.SetX(x);
            chunksize.SetY(y);
            chunksize.SetZ(z);
        }
        public Vector3<UInt32> GetChunkSize()
        {
            return chunksize;
        }
        public void SetChunkOffset(Int32 x,Int32 y,Int32 z)
        {
            chunkoffset.SetX(x);
            chunkoffset.SetY(y);
            chunkoffset.SetZ(z);
        }
        public Vector3<Int32> GetChunkOffset()
        {
            return chunkoffset;
        }
    }
}