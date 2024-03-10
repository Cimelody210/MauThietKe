using System;
using System.IO;
using System.Text;
namespace local_funtion
{
    internal class local_funtion
    {
        public bool CheckTriangle(float a, float b, float c)
        {
            bool CheckSize(float main, float other1, float other2)
            {
                return other1+other2>main;
            }
            bool CheckRightTriangle(float hypothesis, float adjacent1, float adjacent2)
            {
                return  hypothesis*hypothesis== adjacent1*adjacent1+adjacent2*adjacent2;
            }
            bool isTriangle = CheckSize(a,b,c) && CheckSize(b,c,a)&&CheckSize(a,c,b);
            if isTriangle
            {
                bool isRightTriangle = CheckRightTriangle(a,b,c)&&CheckRightTriangle(b,c,a) || CheckRightTriangle(c,a,b);
                return isRightTriangle;
            }
            return false;
        }

    }
}