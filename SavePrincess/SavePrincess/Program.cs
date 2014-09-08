using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SavePrincess
{
    class Solution
    {
        static void displayPathtoPrincess(int n, String[] grid){
    
        int x1=0,x2=0,y1=0,y2=0;
    
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j]=='m')
                {
                    x1=i;
                    y1=j;
                }
            
                if(grid[i][j]=='p')
                {
                    x2=i;
                    y2=j;
                }
            }
        }

        while (x2 > x1)
        {
            Console.WriteLine("DOWN");
            x1++;
        } 
        
        while (x2 < x1)
        {
            Console.WriteLine("UP");
            x1--;
        } 
        
        while (y2 < y1)
        {
            Console.WriteLine("LEFT");
            y1--;
        }
        
        while (y2 > y1)
        {
            Console.WriteLine("RIGHT");
            y1++;
        }
      }
        /* Tail starts here */

        static void Main(String[] args)
        {
            int m;

            m = int.Parse(Console.ReadLine());

            String[] grid = new String[m];
            for (int i = 0; i < m; i++)
            {
                grid[i] = Console.ReadLine();
            }

            displayPathtoPrincess(m, grid);
        }
    }
}