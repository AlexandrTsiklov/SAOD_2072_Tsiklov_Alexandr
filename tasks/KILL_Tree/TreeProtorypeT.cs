using System;
using System.Collections;
using System.Collections.Generic;


namespace KILL_Tree {
    class TreePrototypeT<T> {

        private int count;
		public int Count { get { return count; } }
		private TreeNode<T> root;
        private TreeNode<T> last;

        public void insert(T value) {
            if(root == null) {
                root = new TreeNode<T>(value, null);
                count++;
                return;
            }
            // Always refresh before using
            last = root;
            findNode(value);
            addNode(value);
        }

        private void findNode(T value) {
            if(last.value.Equals(value))
                return;

            if(isLower(value, last.value)) {
                if(last.left == null) return;
                else last = last.left;
            } else {
                if(last.right == null) return;
                else last = last.right;
            }
            findNode(value);
        }

        private void addNode(T value) {
            if(isLower(value, last.value)) {
                last.left = new TreeNode<T>(value, last);
                count++;
            } else if(isGrater(value, last.value)) {
                last.right = new TreeNode<T>(value, last);
                count++;
            }
        }

        public bool contains(T value) {
            if(count == 0)  
                return false;

            // Always refresh before using
            last = root;
            findNode(value);
            return last.value.Equals(value);
        }

        public bool remove(T value) {
            if(!contains(value)) 
                return false;

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
            else if(isLower(last.value, last.parent.value)) last.parent.left = null;
            else last.parent.right = null;
        }

        public void removeNodeIfOneChild() {
            if(last.parent == null) {
                if(last.left == null) root = last.right;
                else root = last.left;
                root.parent = null;
            } else {
                if(last.parent.left == last) {
                    if(last.left == null) last.parent.left = last.right;
                    else last.parent.left = last.left;
                } else {
                    if(last.left == null) last.parent.right = last.right;
                    else last.parent.right = last.left;
                }
            }
        }

        public void removeNodeIfTwoChildren() {
            TreeNode<T> old = last;
            last = last.left;

            while(last.right != null) {
                last = last.right;
            }
            old.value = last.value;

            if(last.left == null) {
                if(old == last.parent) last.parent.left = null;
                else last.parent.right = null;
               // removeNodeIfNoChildren();
            } else {
                removeNodeIfOneChild();
            }
        }

        // !!!!!!!!!!!!! NO IDEA HOW SHOULD IT BE REALIZED !!!!!!!!!!!!!!

        public List<T> LNR() {
            List<T> lnrOutput = new List<T>();
            runAround(root, lnrOutput, method.LNR);
            return lnrOutput;
        }
        public List<T> NRL() {
            List<T> lnrOutput = new List<T>();
            runAround(root, lnrOutput, method.NRL);
            return lnrOutput;
        }
        public List<T> RNL() {
            List<T> lnrOutput = new List<T>();
            runAround(root, lnrOutput, method.RNL);
            return lnrOutput;
        }

         private void runAround(TreeNode<T> node, List<T> lnrOutput, method mtd) {
            if(node == null) return;

            if(mtd == method.RNL) lnrOutput.Add(node.value);
            runAround(node.left, lnrOutput, mtd);
            if(mtd == method.LNR) lnrOutput.Add(node.value);
            runAround(node.right, lnrOutput, mtd);
            if(mtd == method.NRL) lnrOutput.Add(node.value);
        }

        public Dictionary<int, List<T>> WIDE() {
            var levels = new Dictionary<int, List<T>>() {};
            destroyTree(root, levels, 0);
            return levels;
        }

        private void destroyTree(TreeNode<T> node, Dictionary<int, List<T>> levels, int depth){
            if(node == null) return;
            if(node == root) depth = 0;

            if(!levels.ContainsKey(depth))
                levels[depth] = new List<T>();
            levels[depth].Add(node.value);

            destroyTree(node.left, levels, depth + 1);
            destroyTree(node.right, levels, depth + 1);
        }

        private enum method { LNR, NRL, RNL }

        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        private bool isGrater(T a, T b) { return Convert.ToDouble(a) - Convert.ToDouble(b) > 0; }

        private bool isLower(T a, T b) { return Convert.ToDouble(b) - Convert.ToDouble(a) > 0; }


        private class TreeNode<T> {
            public T value;
            public TreeNode<T> left;
            public TreeNode<T> right;
            public TreeNode<T> parent;

            public TreeNode(T value, TreeNode<T> parent) {
                this.value = value;
                this.parent = parent;
            }
        }

        private class ListPrototypeEnumerator : IEnumerator {

            public List<T>lnrOutput;
            int capacity;
            int index;
            public T value;


            public ListPrototypeEnumerator(List<T> lnrOutput) {
                this.lnrOutput = lnrOutput;
                this.capacity = lnrOutput.Count;
            }

            public object Current { get { return value; }}

            public bool MoveNext() {
                if(index == capacity) 
                    return false;

                value = lnrOutput[index];
                index++;
                return true;
            }
            public void Reset() { index = 0; }
        }
        public IEnumerator GetEnumerator() { return new ListPrototypeEnumerator(LNR()); }
    }
}