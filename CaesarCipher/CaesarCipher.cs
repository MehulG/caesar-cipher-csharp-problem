using System;
using System.Linq;
using System.Collections.Generic;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            char[] charArr = text.ToCharArray();
            List<int> intList = new List<int>();
            
            string str = "";

            foreach(char x in charArr){
                intList.Add(Convert.ToInt32(x));
            }
            foreach(int p in intList){
                int q = p;
                if(q>=65 && q <= 90){
                 q = (q + shiftKey - 65) % 26;
                    q+=65;
                }
                if(q>= 97 && q<= 122){
                 q = (q + shiftKey - 97) % 26;
                    q+= 97;
                 }

                str += ((char)(q)).ToString();
            }
            return str;
        }
        public static void Main(string[] args){
            
        }
    }
}
