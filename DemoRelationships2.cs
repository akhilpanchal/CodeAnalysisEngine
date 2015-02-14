
namespace TypeRelationships
{
    struct ComposedType  // structs are value types
    {
        public void say()
        {
            Console.Write("\n  hello - my type is ComposedType");
            Console.Write("\n  my string is \"{0}\"", s);
            Console.Write("\n  my double is {0}", d);
            Console.Write("\n  my int is    {0}", i);
        }
        public string s;
        public double d;
        public int i;
    }
    class DemoRelationships
    {
        ComposedType ct;  // note: no new statement
        AggregatedType at = new AggregatedType();
        DerivedType dt = new DerivedType();

//        ----< constructor initializes composed data >------------------

        public DemoRelationships()
        {
            ct.s = "a string";
            ct.d = 3.1415927;
            ct.i = -3;
        }
        /*----< this function is here because static Main >------------
          ----< can't directly access nonstatic data ct   >------------*/

        public void say(UsedType ut)
        {
            ct.say();
            ut.say();
        }
 //       ----< entry point >--------------------------------------------



        static void Main(string[] args)
        {
            Console.Write("\n  Demonstrating Type Relationships");
            Console.Write("\n ==================================\n");

            DemoRelationships p = new DemoRelationships();
            p.at.say();
            p.dt.say();

            ComposedType ct = new ComposedType();
            ct.d = 1;

            UsedType ut = new UsedType("holding this string");
            p.say(ut);
            Console.Write("\n\n");
        }
    }
    public interface A : C
    {

    }
}
