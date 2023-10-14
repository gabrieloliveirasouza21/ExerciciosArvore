using ExerciciosArvore.Trees;

internal class Program {
    private static void Main(string[] args) {
        //BinaryTreeNode btna = new BinaryTreeNode("a");
        //BinaryTreeNode btnb = new BinaryTreeNode("b");
        //BinaryTreeNode btnc = new BinaryTreeNode("c");
        //BinaryTreeNode btnd = new BinaryTreeNode("d");

        //btna.left = btnb.ToString();
        //btna.right = btnc.ToString();
        //btnb.left = btnd.ToString();
        //btnb.right = btna.ToString();

        //    a
        //   / \
        //  b   c
        // / \   \
        //d   e   f


        BinaryTreeNode a = new BinaryTreeNode("a");
        BinaryTreeNode b = new BinaryTreeNode("b");
        BinaryTreeNode c = new BinaryTreeNode("c");
        BinaryTreeNode d = new BinaryTreeNode("d");
        BinaryTreeNode e = new BinaryTreeNode("e");
        BinaryTreeNode f = new BinaryTreeNode("f");

        a.left = b.ToString();
        a.right = c.ToString();
        b.left = d.ToString();
        b.right = e.ToString();
        c.right = f.ToString();



        


    }
}