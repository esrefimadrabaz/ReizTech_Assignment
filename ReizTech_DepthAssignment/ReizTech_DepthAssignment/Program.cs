using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_DepthAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree one = new Tree(0);
            one.AddChild(1);
            one.AddChild(1);
            Tree first_child = one.nodes[0];
            Tree second_child = one.nodes[1];
            first_child.AddChild(2);
            second_child.AddChild(2);
            second_child.AddChild(2);
            second_child.AddChild(2);

            Tree second_child_first = second_child.nodes[0];
            Tree second_child_second = second_child.nodes[1];
            second_child_first.AddChild(3);
            second_child_second.AddChild(3);
            second_child_second.AddChild(3);
            second_child_second.AddChild(3);

            Tree second_child_second_first = second_child_second.nodes[0];
            second_child_second_first.AddChild(4);
            second_child_second_first.AddChild(4);
            second_child_second_first.AddChild(4);

            //Testing further
            second_child_second_first.nodes[2].AddChild(5);
            second_child_second_first.nodes[2].nodes[0].AddChild(6);
            
            Console.WriteLine(one.depth.ToString());
            Console.ReadLine();
        }
    }
}
