//using System;
//using UnityEngine;

//public class OBB2D : MonoBehaviour
//{
//    /// <summary>
//    ///  X �᷽������
//    /// </summary>
//    public Vector2 _axisX
//    {
//        get
//        {
//            return transform.right;
//        }
//    }

//    /// <summary>
//    /// Y �᷽������
//    /// </summary>
//    public Vector2 _axisY
//    {
//        get
//        {
//            return transform.up;
//        }
//    }

//    /// <summary>
//    /// ���ĵ�����
//    /// </summary>
//    public Vector2 _center;

//    /// <summary>
//    /// �߳���
//    /// </summary>
//    public Vector2 _size;

//    private Vector2 P1
//    {
//        get
//        {
//            return default(Vector2);
//        }
//    }
//        private Vector2 P2
//    {
//        get
//        {
//            return default(Vector2);
//        }
//    }
//        private Vector2 P3
//    {
//        get
//        {
//            return default(Vector2);
//        }
//    }
//        private Vector2 P4
//    {
//        get
//        {
//            return default(Vector2);
//        }
//    }

    

//    public bool IsIntersect2D(OBB2D a, OBB2D b)
//    {
//        // �����һ���������ϲ��ཻ����OBB1 �� OBB2 ���ཻ
//        return !(IsNotIntersectInAxis(a._vertexs, b._vertexs, a._axisX)
//            || IsNotIntersectInAxis(a._vertexs, b._vertexs, a._axisY)
//            || IsNotIntersectInAxis(a._vertexs, b._vertexs, b._axisX)
//            || IsNotIntersectInAxis(a._vertexs, b._vertexs, b._axisY));
//    }

//    /// <summary>
//    /// OBB �� axis ����û���ཻ
//    /// </summary>
//    /// <param name="vertexs1">OBB1 �����ж���</param>
//    /// <param name="vertexs2">OBB2 �����ж���</param>
//    /// <param name="axis">������</param>
//    /// <returns></returns>
//    private bool IsNotIntersectInAxis(Vector2[] vertexs1, Vector2[] vertexs2, Vector2 axis)
//    {
//        float[] range1 = VertexProject(vertexs1, axis);
//        float[] range2 = VertexProject(vertexs2, axis);
//        return range1[0] > range2[1] || range2[0] > range1[1];
//    }

//    /// <summary>
//    /// ���������ϵ�ͶӰ����Сֵ�����ֵ
//    /// </summary>
//    /// <param name="vertexs">����</param>
//    /// <param name="axis">������</param>
//    /// <returns></returns>
//    private float[] VertexProject(Vector2[] vertexs, Vector2 axis)
//    {
//        float[] range = new float[] { float.MaxValue, float.MinValue };
//        for (int i = 0; i < vertexs.Length; ++i)
//        {
//            Vector2 vertex = vertexs[i];
//            float dot = Vector2.Dot(vertex, axis);
//            range[0] = Math.Min(range[0], dot);
//            range[1] = Math.Max(range[1], dot);
//        }
//        return range;
//    }
//}
