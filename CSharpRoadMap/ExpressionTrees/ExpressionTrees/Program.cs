using System;
using System.Linq.Expressions;

namespace ExpressionTrees
{
    //Expression tree as name suggests is nothing but expressions arranged in a tree-like data structure. Each node in an expression tree is an expression. For example, an expression tree can be used to represent mathematical formula x < y where x, < and y will be represented as an expression and arranged in the tree like structure.

    // Expression tree is an in-memory representation of a lambda expression.It holds the actual elements of the query, not the result of the query.


   // The expression tree makes the structure of the lambda expression transparent and explicit. You can interact with the data in the expression tree just as you can with any other data structure.
    class Program
    {
        static void Main(string[] args)
        {
            // To create the expression tree, first of all, create a parameter expression where Student is the type of the parameter and 's' is the name of the parameter as below:
            ParameterExpression pe = Expression.Parameter(typeof(Student), "s");

            // Now, use Expression.Property() to create s.Age expression where s is the parameter and Age is the property name of Student. (Expression is an abstract class that contains static helper methods to create the Expression tree manually.)
            MemberExpression me = Expression.Property(pe, "Age");

            //Now, create a constant expression for 18:
            ConstantExpression constant = Expression.Constant(18, typeof(int));
            //Till now, we have built expression trees for s.Age (member expression) and 18 (constant expression). We now need to check whether a member expression is greater than a constant expression or not. For that, use the Expression.GreaterThanOrEqual() method and pass the member expression and constant expression as parameters:
            BinaryExpression body = Expression.GreaterThanOrEqual(me, constant);

            // Thus, we have built an expression tree for a lambda expression body s.Age >= 18.We now need to join the parameter and body expressions.Use Expression.Lambda(body, parameters array) to join the body and parameter part of the lambda expression s => s.age >= 18:
            var ExpressionTree = Expression.Lambda<Func<Student, bool>>(body, new[] { pe });

            //This way you can build an expression tree for simple Func delegates with a lambda expression.

            Console.WriteLine("Expression Tree: {0}", ExpressionTree);

            Console.WriteLine("Expression Tree Body: {0}", ExpressionTree.Body);

            Console.WriteLine("Number of Parameters in Expression Tree: {0}",
                ExpressionTree.Parameters.Count);

            Console.WriteLine("Parameters in Expression Tree: {0}", ExpressionTree.Parameters[0]);
        }

        //Executable code excutes in the same application domain to process over in-memory collection. Enumerable static classes contain extension methods for in-memory collections that implements IEnumerable<T> interface e.g. List<T>, Dictionary<T>, etc. The Extension methods in an Enumerable class accept a predicate parameter of Func type delegate. For example, the Where extension method accepts Func<TSource, bool> predicate. It then compiles it into IL (Intermediate Language) to process over in-memory collections that are in the same AppDomain.

        //Func delegate is a raw executable code, so if you debug the code, you will find that the Func delegate will be represented as opaque code. You cannot see its parameters, return type and body:
        //Func delegate is for in-memory collections because it will be processed in the same AppDomain, but what about remote LINQ query providers like LINQ-to-SQL, EntityFramework or other third party products that provides LINQ capabilities? How would they parse lambda expression that has been compiled into raw executable code to know about the parameters, return type of lambda expression and build runtime query to process further? The answer is Expression tree.

        // Expression<TDelegate> is compiled into a data structure called an expression tree.

        //Expression trees were created for the task of converting code such as a query expression into a string that can be passed to some other process and executed there.

        // Queryable static class includes extension methods that accept a predicate parameter of Expression type.This predicate expression will be converted into an Expression Tree and then will be passed to the remote LINQ provider as a data structure so that the provider can build an appropriate query from the expression tree and execute the query.

        /* Source: https://www.tutorialsteacher.com/linq/expression-tree   */
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
