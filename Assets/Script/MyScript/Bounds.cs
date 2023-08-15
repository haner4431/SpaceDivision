using System;
using UnityEngine;


namespace SpaceDivision
{
    public interface IBounds<T> where T : IBounds<T>
    {
        /// <summary>
        /// 包围盒是否相交
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Intersect(T o);

        /// <summary>
        /// 包围盒是否完全包含
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Contains(T o);

    }

    public class AABB3D : IBounds<AABB3D>
    {
        private Vector3 mCenter;
        public Vector3 Center
        {
            get
            {
                return mCenter;
            }
            set
            {
                mCenter = value;
            }
        }

        private Vector3 mSize;
        public Vector3 Size
        {
            get
            {
                return mSize;
            }
            set
            {
                mSize = value;
                mExtents = Size *0.5f;
            }
        }    
        private Vector3 mExtents;
        public Vector3 Extents
        {
            get
            {
                return mExtents;
            }
            set
            {
                mExtents = value; 
            }
        }
        public Vector3 Max
        {
            get
            {
                return Center + mExtents;
            }
            set
            {
                SetMinMax(value, Max);
            }

        }
        public Vector3 Min
        {
            get
            {
                return Center - mExtents;
            }
            set
            {
                SetMinMax(Min,value);
            }
     
        }

        private void SetMinMax(Vector3 min, Vector3 max)
        {
            Extents = (max - min) * 0.5f;
            Center = min + Extents;
        }


        public bool Intersect(AABB3D o)
        {
            return Min.x <= o.Max.x && Max.x >= o.Min.x && Min.y <= o.Max.y && Max.y >= o.Min.y && Min.z <= o.Max.z && Max.z >= o.Min.z; 
        }

        public bool Contains(AABB3D o)
        {
            throw new NotImplementedException();
        }
    }

   
}
