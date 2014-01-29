using System;

public class Verification
{
	public Verification()
	{
	} 

    int check(int a,int b){
         int[,] m2= new int[9,9]; int r=0;
         for(int i=0;i<9;i++)
          for(int j=0;j<9;j++)
           m2[i][j]=mas[r++];
         for (int i=0;i<3;i++)
          for (int j=0;j<3;j++)
          {if ((3*(a/3)+i==a)&&(3*(b/3)+j==b)) continue;
         if (m2[3*(a/3)+i][3*(b/3)+j]==0) continue;
         if (m2[3*(a/3)+i][3*(b/3)+j]==m2[a][b]) return 1;
    };
    }
	
	int check_lines(int a,int b){
	int[,] m2= new int[9,9]; int r=0;
	 for(int i=0;i<9;i++)
	  for(int j=0;j<9;j++)
	   m2[i][j]=mas[r++];
	 for(int i=0;i<9;i++)
	 {if (i==b) continue;
	 if (m2[a][i]==0) continue;
	 if (m2[a][i]==m2[a][b]) return 1;};
	 for(int i=0;i<9;i++)
	 {if (i==a) continue;
	 if (m2[i][b]==0) continue;
	 if (m2[i][b]==m2[a][b]) return 2;};
	}

}
