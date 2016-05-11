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
                return 0;
            }
            else
            {
                int height = 0;
                int[] children = new int[this.parents.Length];
                

                for(int i=0; i<this.parents.Length;i++)
                {
                    children[i] = 0; //Init the array

                    for(int j=i; j<this.parents.Length;j++)
                    {
                        //if()
                    }
                }

                return height;
            }
        }

        // leave is every node that doesn't has any child
        private int CalculateLeaves ()
        {
            if(this.parents==null||this.parents.Length==0)
            {
                return 0;
            }
            else if(this.parents.Length==1)
            {
                return 1;
            }
            else
            {
                int leaves = 0;
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
                return leaves;
            }
        }

        static void Main(string[] args)
        {
            Tree tree = new Tree(new int[] { -1, 0, 0, 1, 1, 2, 2, 3});
            Console.WriteLine(tree.CalculateHeight());
            Console.WriteLine(tree.CalculateLeaves());
            Console.ReadKey();
        }
    }
}
