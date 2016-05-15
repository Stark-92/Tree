using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Tree
    {
        private int[] parents;

        public Tree(int [] parents)
        {

            this.parents = parents;
        }

        private int CalculateHeight ()
        {
            if(this.parents==null|| this.parents.Length==0 || this.parents.Length == 1)
            {
                //Height =0
                return 0;
            }
            else
            {
                //Start from last child backward to its parents
                int height = 0;
                int i = this.parents.Length-1;

                while(parents[i]>=0)
                {
                    height++;
                    i = parents[i];
                }

                return height;
            }
        }

        // leaf is every node that doesn't has any child
        private int CalculateLeaves ()
        {
            if (this.parents == null || this.parents.Length == 0)
            {
                return 0;
            }
            else if (this.parents.Length == 1)
            {
                return 1;
            }
            else
            {
                //Count leaves from root to last node
                /* int leaves = 0;
                 bool isparent = false;
                 for(int i=0; i<this.parents.Length;i++)
                 {
                     for (int j=i;j<this.parents.Length;j++)
                     {
                         if(i==this.parents[j])
                         {
                             isparent = true;
                         }
                     }

                     if(!isparent)
                     {
                         leaves += 1;                       
                     }
                     isparent = false;
                 }
                 return leaves;*/

                //leaves= all nodes - parents
                int leaves = this.parents.Length;

                for (int i = 1; i < this.parents.Length; i++)
                {
                    if (this.parents[i - 1] != this.parents[i])
                    {
                        leaves--;
                    }
                }

                return leaves;
            }
        }

        static void Main(string[] args)
        {
            //Tree tree = new Tree(new int[] { -1, 0, 0, 1, 1, 2, 2, 3});
            Tree tree = new Tree(new int[] { -1, 0, 0, 1, 2, 3, 4, 6});
            Console.WriteLine("Tree height = "+tree.CalculateHeight());
            Console.WriteLine("Tree leaves = " + tree.CalculateLeaves());
            Console.ReadKey();
        }
    }
}
