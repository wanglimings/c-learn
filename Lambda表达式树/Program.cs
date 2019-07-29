using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lambda表达式树
{
    class Program
    {
        static void Main(string[] args)
        {
            //表达式的参数
            ParameterExpression a = Expression.Parameter(typeof(int), "a");
            ParameterExpression b = Expression.Parameter(typeof(int), "b");
            //表达式的主体部分
            BinaryExpression be = Expression.Add(a, b);
            //构造表达式树
            Expression<Func<int, int, int>> expressionTree = Expression.Lambda<Func<int, int, int>>(be, a, b);
            //分析树结构，获取表达式树的主题部分
            BinaryExpression body = (BinaryExpression) expressionTree.Body;
            //左节点，每个节点本身就是一个表达式对象
            ParameterExpression left = (ParameterExpression) body.Left;
            //右节点
            ParameterExpression right = (ParameterExpression) body.Right;
            //输出表达式树结构
            Console.WriteLine("表达式树结构为："+expressionTree);
            //输出
            Console.WriteLine("表达式主体为：");
            Console.WriteLine(expressionTree.Body);
            Console.WriteLine("表达式树左节点为：{0}{4} 节点类型为：{1}{4}{4}  表达式树右节点为：{2}{4}" +
                              "节点类型为：{3}{4}",left.Name,left.Type,right.Name,right.Type,Environment.NewLine);
            //将Lambda表达式构造成表达式树
            Expression<Func<int, int, int>> expressionTree1 = (c, d) => c + d;
            //获得表达式树参数
            Console.WriteLine("参数1：{0}，参数2,：{1}",expressionTree1.Parameters[0],expressionTree1.Parameters[1]);
            //获取表达式树的主体部分
            BinaryExpression body1 = (BinaryExpression) expressionTree1.Body;
            //左节点
            ParameterExpression left1 = (ParameterExpression) body.Left;
            //右节点
            ParameterExpression right1 = (ParameterExpression) body.Right;
            Console.WriteLine("表达式树的主体为：");
            Console.WriteLine(expressionTree1.Body);
            Console.WriteLine("表达式树左节点为：{0}{4} 节点类型为：{1}{4}{4}  表达式树右节点为：{2}{4}" +
                              "节点类型为：{3}{4}", left1.Name, left1.Type, right1.Name, right1.Type, Environment.NewLine);


            Console.Read();


        }
    }
}
