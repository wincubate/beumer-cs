using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Wincubate.Module03.Classes;

namespace Wincubate.Module03.Slide42
{
   class Program
   {
      static void Main( string[] args )
      {
         #region Compiling

         //Expression<Func<int, int, int>> addition = ( x, y ) => x + y;
         //Func<int, int, int> add = addition.Compile();
         //Console.WriteLine( add( 5, 7 ) );

         #endregion

         #region Dynamic LINQ Queries

         ////Console.WriteLine( "Input threshold: ");
         ////int t = int.Parse( Console.ReadLine() );

         //List<Obj> data = new List<Obj>
         //{
         //   new Obj { x = 3, y = 3 },
         //   new Obj { x = 2, y = 4 },
         //   new Obj { x = 6, y = 5 },
         //   new Obj { x = 7, y = 8 },
         //   new Obj { x = 9, y = 7 },
         //   new Obj { x = 4, y = 4 },
         //   new Obj { x = 4, y = 2 },
         //   new Obj { x = 8, y = 7 }
         //};

         //// obj => ...
         //ParameterExpression parameter = Expression.Parameter( typeof( Obj ), "obj" );

         //// obj.x -6
         //MemberExpression expressionX = Expression.Field(
         //   parameter,
         //   "x" );
         //ConstantExpression expression6 = Expression.Constant( 6 );
         //BinaryExpression expressionXminus6 = Expression.MakeBinary(
         //   ExpressionType.Subtract,
         //   expressionX,
         //   expression6
         //);

         //// (obj.x - 6 ) * y
         //MemberExpression expressionY = Expression.Field(
         //   parameter,
         //   "y" );
         //BinaryExpression expressionXminus6timesY = Expression.MakeBinary(
         //   ExpressionType.Multiply,
         //   expressionXminus6,
         //   expressionY
         //);

         //// 9 < (obj.x - 6 ) * y
         //ConstantExpression expression9 = Expression.Constant( 9 );
         //BinaryExpression expression = Expression.MakeBinary(
         //   ExpressionType.LessThan,
         //   expression9,
         //   expressionXminus6timesY
         //);

         //// obj => 9 < (obj.x - 6 ) * y
         //Expression<Func<Obj, bool>> lambda = Expression.Lambda<Func<Obj, bool>>(
         //   expression,
         //   parameter
         //);

         //// Dynamic LINQ query and evaluation
         //var query = data.Where( lambda.Compile() );
         //foreach ( var o in query )
         //{
         //   Console.WriteLine( o );
         //}

         #endregion
      }
   }
}
