using System;

namespace ConsoleApp {

    // https://stackoverflow.com/questions/19168572/what-event-to-capture-when-a-treevew-node-is-checked-unchecked
    // https://stackoverflow.com/questions/26542568/get-list-of-all-checked-nodes-and-its-subnodes-in-treeview/26542677#26542677
    public static class Traverse {
        public void ddd () {
            var selectedNodes = myTreeView.Nodes.Descendants ()
                .Where (n => n.Checked)
                .Select (n => n.Text)
                .ToList ();

        }

        internal static IEnumerable<TreeNode> Descendants (this TreeNodeCollection c) {
            foreach (var node in c.OfType<TreeNode> ()) {
                yield return node;

                foreach (var child in node.Nodes.Descendants ()) {
                    yield return child;
                }
            }
        }

        public void GetCheckedNodes (TreeNodeCollection nodes) {
            foreach (System.Windows.Forms.TreeNode aNode in nodes) {
                //edit
                if (aNode.Checked)
                    Console.WriteLine (aNode.Text);

                if (aNode.Nodes.Count != 0)
                    GetCheckedNodes (aNode.Nodes);
            }
        }

        void LookupChecks (TreeNodeCollection nodes, List<TreeNode> list) {
            foreach (TreeNode node in nodes) {
                if (node.Checked)
                    list.Add (node);

                LookupChecks (node.Nodes, list);
            }
        }

        public void sdea () {
            var list = new List<TreeNode> ();
            LookupChecks (TreeView.Nodes, list);
        }

        protected void Button1_Click (object sender, EventArgs e) {
            TreeNodeCollection nodes = this.tv1.Nodes;
            foreach (TreeNode n in nodes) {
                GetNodeRecursive (n);

            }
        }
        private void GetNodeRecursive (TreeNode treeNode) {
            if (treeNode.Checked == true) {
                Response.Write ("<br/>" + treeNode.Text + "<br/>");
                //Your Code Goes Here to perform any action on checked node
            }
            foreach (TreeNode tn in treeNode.ChildNodes) {
                GetNodeRecursive (tn);
            }

        }

        private void tvSteps_AfterCheck (object sender, TreeViewEventArgs e) {
            if (e.Node.Name == "cbNode5") {
                foreach (TreeNode tn in e.Node.Nodes) {
                    tn.Checked = e.Node.Checked;
                }
            }
        }

        // https://stackoverflow.com/questions/2141072/treeview-control-checkboxes-and-clicking
        // Not considered here :
        // what to about which node is selected when checking, when a child node selection forces a parent node to be selected (because all other child nodes are selected).
        // could be other cases related to selection not considered here.
        // Assumptions :
        // you are in a TreeView with a single-node selection mode
        // only two levels of depth, as in OP's sample ("heavy duty" recursion not required)
        // everything done with the mouse only : extra actions like keyboard keypress not required.
        // if all child nodes are checked, parent node is auto-checked
        // unchecking any child node will uncheck a checked parent node
        // checking or unchecking the parent node will set all child nodes to the same check-state

        // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.treeview.aftercheck?redirectedfrom=MSDN&view=netframework-4.8

        // Updates all child tree nodes recursively.
        private void CheckAllChildNodes (TreeNode treeNode, bool nodeChecked) {
            foreach (TreeNode node in treeNode.Nodes) {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0) {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes (node, nodeChecked);
                }
            }
        }

        // NOTE   This code can be added to the BeforeCheck event handler instead of the AfterCheck event.
        // After a tree node's Checked property is changed, all its child nodes are updated to the same value.
        private void node_AfterCheck (object sender, TreeViewEventArgs e) {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown) {
                if (e.Node.Nodes.Count > 0) {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes (e.Node, e.Node.Checked);
                }
            }
        }

        //Github and details
        // https://github.com/r-aghaei/TreeViewCheckUnCheckHierarchyExample/tree/master/src/TreeViewCheckUnCheckHierarchyExample
        // https://stackoverflow.com/questions/50494226/winforms-treeview-checking-unchecking-hierarchy

    }
}