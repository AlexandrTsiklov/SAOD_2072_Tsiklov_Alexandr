using System.Collections.Generic;


namespace KILL_Tree {
     class TreePrototype {

        private int count;
        private TreeNode root;
        private TreeNode last;

        public void insert(int value) {
            if(root == null) {
                root = new TreeNode(value, null);
                count++;
                return;
            } 
            // Always refresh before using
            last = root;
            findNode(value);
            addNode(value);
        }

        private void findNode(int value) {
            if(last.value == value) return;

            if(value < last.value) {
                if(last.left == null) return;
                else last = last.left;
            } else {
                if(last.right == null) return;
                else last = last.right;
            }
            findNode(value);
        }

        private void addNode(int value) {
            if(value < last.value) {
                last.left = new TreeNode(value, last);
                count++;
            } else if(value > last.value) {
                last.right = new TreeNode(value, last);
                count++;
            }
        }

        public bool contains(int value) {
            if(count == 0) return false;
            // Always refresh before using
            last = root;
            findNode(value);
            return last.value == value;
        }

        public bool remove(int value) {
            if(!contains(value)) return false;
            removeNode();
            count--;
            return true;
        }

        private void removeNode() {
            if(last.left == null && last.right == null) removeNodeIfNoChildren();
            else if(last.left == null ^ last.right == null) removeNodeIfOneChild();
            else removeNodeIfTwoChildren();
        }

        public void removeNodeIfNoChildren() {
            if(last.parent == null) root = null;
            else if(last.value < last.parent.value) last.parent.left = null;
            else last.parent.right = null;
        }

        public void removeNodeIfOneChild() {
            if(last.left == null) {
                if(last.parent == null) {
                    root = last.right;
                    root.parent = null;
                } else {
                    last.parent.right = last.right;
                    last.right.parent = last.parent;
                }
            } else {
                if(last.parent == null) {
                    root = last.left;
                    root.parent = null;
                } else {
                    last.parent.left = last.left;
                    last.left.parent = last.parent;
                }
            }  
        }

        public void removeNodeIfTwoChildren() {
            TreeNode old = last;
            last = last.left;

            while(last.right != null) {
                last = last.right;
            }
            old.value = last.value;

            if(last.left == null) {
                if(old == last.parent) last.parent.left = null;
                else last.parent.right = null;
            } else {
                last.left.parent = last.parent;
                if(last.parent.left == last) last.parent.left = last.left;
                else last.parent.right = last.left;
            }
        }

        public List<int> LNR() {
            List<int> output = new List<int>();
            runAroundTree(output, root);
            return output;
        }

        private void runAroundTree(List<int> output, TreeNode node) {
            if(node == null) return;
            runAroundTree(output, node.left);
            output.Add(node.value);
            runAroundTree(output, node.right);
        }

        public int getCount() {
            return count;
        }

        private class TreeNode {
            public int value;
            public TreeNode left;
            public TreeNode right;
            public TreeNode parent;

            public TreeNode(int value, TreeNode parent) {
                this.value = value;
                this.parent = parent;
            }
        }
    }
}