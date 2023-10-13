using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosArvore.Trees {
    internal class BinaryTreeNode {

        public string val;
        public string left;
        public string right;

        public BinaryTreeNode(string val) {
            this.val = val;
            this.left = null;
            this.right = null;
        }

    }
}
