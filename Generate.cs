using System;

public class Generation
{
	public Generation()
	{
	}

    void gener(){
	int[] m1=new int[3];
    int[] m2=new int[3];
    int[] m3=new int[3];
    int[] m4=new int[9];
    int j=0,l=0,k=0,f=0,r=0,a;
	srand((unsigned) time(NULL));
	for(int i=0;i<3;i++)
		m1[k++]=i+1;
	for(int i=3;i<6;i++)
		m2[j++]=i+1;
	for(int i=6;i<9;i++)
		m3[l++]=i+1;
	k=0;l=0;j=0;
	while (r<9)
	{a=(rand()%2)+1;
	if ((a==1)&&(k<3)) m4[r++]=m1[k++];
	else if ((a==2)&&(j<3)) m4[r++]=m2[j++];
	else if (l<3)
		m4[r++]=m3[l++];
	};
	k=0;l=0;j=0;
	for(int i=0;i<3;i++)
	{m1[k++]=m4[i];
	mas[f++]=m4[i];};
	for(int i=3;i<6;i++)
	{m2[j++]=m4[i];
	mas[f++]=m4[i];};
	for(int i=6;i<9;i++)
	{m3[l++]=m4[i];
	mas[f++]=m4[i];};
	for(int i=0;i<3;i++)
		mas[f++]=m2[i];
	for(int i=0;i<3;i++)
		mas[f++]=m3[i];
	for(int i=0;i<3;i++)
		mas[f++]=m1[i];
	for(int i=0;i<3;i++)
		mas[f++]=m3[i];
	for(int i=0;i<3;i++)
		mas[f++]=m1[i];
	for(int i=0;i<3;i++)
		mas[f++]=m2[i];
	m1[0]=m4[8];
	r=0;
	for(int i=1;i<3;i++)
		m1[i]=m4[r++];
	for(int i=0;i<3;i++)
		m2[i]=m4[r++];
	for(int i=0;i<3;i++)
		m3[i]=m4[r++];
	for(int i=0;i<3;i++)
		mas[f++]=m1[i];
	for(int i=0;i<3;i++)
		mas[f++]=m2[i];
	for(int i=0;i<3;i++)
		mas[f++]=m3[i];

	for(int i=0;i<3;i++)
		mas[f++]=m2[i];
	for(int i=0;i<3;i++)
		mas[f++]=m3[i];
	for(int i=0;i<3;i++)
		mas[f++]=m1[i];

	for(int i=0;i<3;i++)
		mas[f++]=m3[i];
	for(int i=0;i<3;i++)
		mas[f++]=m1[i];
	for(int i=0;i<3;i++)
		mas[f++]=m2[i];
	r=0;
	m1[0]=m4[7];
	m1[1]=m4[8];
	for(int i=2;i<3;i++)
		m1[i]=m4[r++];
	for(int i=0;i<3;i++)
		m2[i]=m4[r++];
	for(int i=0;i<3;i++)
		m3[i]=m4[r++];

	for(int i=0;i<3;i++)
		mas[f++]=m1[i];
	for(int i=0;i<3;i++)
		mas[f++]=m2[i];
	for(int i=0;i<3;i++)
		mas[f++]=m3[i];

	for(int i=0;i<3;i++)
		mas[f++]=m2[i];
	for(int i=0;i<3;i++)
		mas[f++]=m3[i];
	for(int i=0;i<3;i++)
		mas[f++]=m1[i];

	for(int i=0;i<3;i++)
		mas[f++]=m3[i];
	for(int i=0;i<3;i++)
		mas[f++]=m1[i];
	for(int i=0;i<3;i++)
		mas[f++]=m2[i];
};
}
