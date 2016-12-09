using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace syscleaner
{
    public class Customer
    {
        public ArrayList CustomerOrders;
        public string CustomerName;
        public Customer(string myName)
        {
            CustomerName = myName;
            CustomerOrders = new ArrayList();
        }
    }
    public class Order
    {
        public string OrderID;
        public Order(string myOrderID)
        {
            this.OrderID = myOrderID;
        }
    }
    public partial class TreeViews : Form
    {
        public TreeViews()
        {
            InitializeComponent();
            BindImageList();
        }

        void BindImageList()
        {
            ImageList myImageList = new ImageList();
           
            myImageList.Images.Add(Image.FromFile(@"F:\syscleaner\syscleaner\Image\03.jpg"));
            
            treeView1.ImageList = myImageList;


            // Set the TreeView control's default image and selected image indexes.
            //treeView1.ImageIndex = 0;
            var temp = treeView1.Parent;
            foreach (TreeView item in temp.Controls)
            {

                foreach (TreeNode item1 in item.Nodes)
                {
                    item1.ImageIndex = 1;
                    
                }


            }
            //treeView1.SelectedImageIndex = 1;

            /* Set the index of image from the 
            ImageList for selected and unselected tree nodes.*/
            //treeView1 = 2;
            //treeView1.selectedCustomerImageIndex = 3;
            //treeView1.unselectedCustomerImageIndex = 4;
            //treeView1.selectedOrderImageIndex = 5;
            //treeView1.unselectedOrderImageIndex = 6;

            // Create the root tree node.
            
            // Add a root tree node for each Customer object in the ArrayList.
            //foreach (Customer myCustomer in customerArray)
            //{
            //    // Add a child tree node for each Order object.
            //    int countIndex = 0;
            //    TreeNode[] myTreeNodeArray = new TreeNode[myCustomer.CustomerOrders.Count];
            //    foreach (Order myOrder in myCustomer.CustomerOrders)
            //    {
            //        // Add the Order tree node to the array.
            //        myTreeNodeArray[countIndex] = new TreeNode(myOrder.OrderID,
            //          unselectedOrderImageIndex, selectedOrderImageIndex);
            //        countIndex++;
            //    }
            //    // Add the Customer tree node.
            //    TreeNode customerNode = new TreeNode(myCustomer.CustomerName,
            //        unselectedCustomerImageIndex, selectedCustomerImageIndex, myTreeNodeArray);
            //    myTreeView.Nodes[0].Nodes.Add(customerNode);
            //}
        }
    }
}
