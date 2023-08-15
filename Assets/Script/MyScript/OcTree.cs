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
        /// ��Ӷ���
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        public void AddObject(T o);

        /// <summary>
        /// ɾ������
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
        /// �ֻ��ӽڵ�
        /// </summary>
        public List<T> GenChildren();

        /// <summary>
        /// ���ռ��Ƿ�����ռ����
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool ContainsObject(T o);

        /// <summary>
        /// ���ռ��Ƿ�Ϳռ�����ཻ
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

