using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rgcs
{
    public class Vector3<T>
    {
      
        T X;
        T Y;
        T Z;

        public Vector3(T x, T y, T z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public T GetX()
        {
            return X;
        }
        public T GetY()
        {
            return Y;
        }
        public T GetZ()
        {
            return Z;
        }
        public void SetX(T NewX)
        {
            X = NewX;
        }
        public void SetY(T NewY)
        {
            Y = NewY;
        }
        public void SetZ(T NewZ) {
            Z = NewZ;
        }

        ~Vector3()
        {
           
        }
    }
}
