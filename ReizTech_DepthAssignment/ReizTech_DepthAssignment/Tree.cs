using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_DepthAssignment
{
    class Tree
    {
        private readonly int _val;
        public int Value { get { return _val; } }
        public List<Tree> nodes = new List<Tree>();
        public int depth { get { return Depth(this); }}
        public int _depth;
        public Tree(int value)
        {
            _val = value;
        }
        public void AddChild(int x)
        {
            var foo = new Tree(x);
            nodes.Add(foo);
        }
        private int Depth(Tree tree)
        {
            if (tree == null) { return 0; }

            _depth = 0;
            foreach(Tree node in tree.nodes)
            {
                _depth = Math.Max(_depth, Depth(node));
            }
            return _depth + 1;
        }
    }
}
    