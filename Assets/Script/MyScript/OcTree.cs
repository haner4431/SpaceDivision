using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

namespace SpaceDivision
{

    public interface IOcTree<T> where T : IOcTreeObject
    {

        /// <summary>
        /// 添加对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        public void AddObject(T o);

        /// <summary>
        /// 删除对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        public void RemoveObject(T o);

    }

    public class OcTree<T> : IOcTree<T> where T : IOcTreeObject
    {
        public static OcTree<T> CreateTree(Vector3 center, Vector3 size)
        {
            throw new System.NotImplementedException();
        }

        public void AddObject(T o)
        {
            throw new NotImplementedException();
        }


        public void RemoveObject(T o)
        {
            throw new NotImplementedException();
        }
    }


    public interface IOcTreeNode<T> where T : IOcTreeObject
    {
        /// <summary>
        /// 分化子节点
        /// </summary>
        public List<T> GenChildren();

        /// <summary>
        /// 结点空间是否包含空间对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool ContainsObject(T o);

        /// <summary>
        /// 结点空间是否和空间对象相交
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool IntersetObject(T o);

        public Bounds GetBounds();
    }

    public class OcTreeNode<T> : IOcTreeNode<T> where T : IOcTreeObject
    {
        List<T> children;
        Bounds bounds;
        public bool ContainsObject(T o)
        {
            throw new NotImplementedException();
        }

        public List<T> GenChildren()
        {
            throw new NotImplementedException();
        }

        public Bounds GetBounds()
        {
            return bounds;
        }

        public bool IntersetObject(T o)
        {
            throw new NotImplementedException();
        }
    }


    public interface IOcTreeObject
    {
        public Bounds GetBounds();
    }

    public class OcTreeObject : IOcTreeObject
    {
        private Bounds bounds;
        public Bounds GetBounds()
        {
            return bounds;
        }
    }
}

