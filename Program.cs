//using File_Scoped_Types;

//var scopedClass = new ScopedClass2();
//var result = scopedClass.Render();
//Console.WriteLine(result);

using File_Scoped_Types;

enum CommandType
{
    MoveRight,
    MoveDown,
    MoveLeft,
    MoveUp
}
//file class ScopedClass2
//{
//    public string Render()
//    {
//        return "ScopedClass.Render()";
//    }
//}
namespace File_Scoped_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = new Command();
            var result = command.MoveCommand(1, 1, CommandType.MoveRight);
            Console.WriteLine(result);

            var command2 = new Command2();
            var result2 = command2.MoveCommand(result.x, result.y, CommandType.MoveDown);
            Console.WriteLine(result2);
        }
    }
}