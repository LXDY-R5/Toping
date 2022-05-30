using System;
using System.IO;

namespace Toping
{
    class Program
    {
        static void Main(string[] args)
        {
            string ArgList = ""; //预配置命令行参数
            string RetText = ""; //预配置参数
            for(int z = 0; z < args.Length; z++)
            {
                ArgList = ArgList + args[z] + " ";
            }
            string Code = ArgList;
            string[] CodeSplit = Code.Split(" ");
            if (CodeSplit.Length > 1) //当数组长度大于一时，进行参数的获取
            {
                for (int i = 1; i < CodeSplit.Length; i++)
                {
                    RetText = RetText + CodeSplit[i] + " "; //获取参数
                }
            }
            RetText+="\b"; //删除末尾字符
            if (CodeSplit[0] == "output") //开始检测
            {
                Console.WriteLine(RetText);
            }
            else if (CodeSplit[0] == "print")
            {
                Console.Write(RetText);
            }
            else if (CodeSplit[0] == "comput-add")
            {
                Console.Write(int.Parse(CodeSplit[1]) + int.Parse(CodeSplit[2]));
            }
            else if (CodeSplit[0] == "NewLine")
            {
                Console.Write("\n");
            }
        }
    }
}
