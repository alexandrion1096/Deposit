#include "mainwindow.h"
#include "ui_mainwindow.h"
#include<QDebug>
#include<string.h>
#include<QMessageBox>
#include<cmath>
MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ui->pushButton_17->setVisible(false);
    ui->textEdit->setVisible(false);
    ui->textEdit->setVisible(false);
    ui->label->setVisible(false);
    ui->label_2->setVisible(false);
    ui->label_3->setVisible(false);
    ui->label_4->setVisible(false);
    ui->label_5->setVisible(false);
    ui->label_6->setVisible(false);
    ui->label_7->setVisible(false);
    ui->label_8->setVisible(false);
    ui->pushButton->setVisible(false);
    ui->pushButton_2->setVisible(false);
    ui->pushButton_3->setVisible(false);
    ui->pushButton_4->setVisible(false);
    ui->pushButton_5->setVisible(false);
    ui->pushButton_6->setVisible(false);
    ui->pushButton_7->setVisible(false);
    ui->pushButton_8->setVisible(false);
    ui->pushButton_9->setVisible(false);
    ui->pushButton_10->setVisible(false);
    ui->pushButton_11->setVisible(false);
    ui->pushButton_12->setVisible(false);
    ui->pushButton_13->setVisible(false);
    ui->pushButton_14->setVisible(false);
    ui->pushButton_15->setVisible(false);
    ui->pushButton_16->setVisible(false);
    ui->label_14->setVisible(false);
     ui->label_13->setVisible(false);
    ui->Label_9->setVisible(false);
    ui->Label_10->setVisible(false);
    ui->Label_11->setVisible(false);
    ui->Label_12->setVisible(false);


}

MainWindow::~MainWindow()
{
    delete ui;

}

MainWindow::completeaza_diagrama()
{
    if(a[1][1]>1)
    ui->pushButton->setText("X");
    else
        ui->pushButton->setText(QVariant(a[1][1]).toString());
    if(a[1][2]>1)
        ui->pushButton_2->setText("X");
        else
    ui->pushButton_2->setText(QVariant(a[1][2]).toString());
    if(a[1][3]>1)
        ui->pushButton_3->setText("X");
        else
    ui->pushButton_3->setText(QVariant(a[1][3]).toString());
     if(a[1][4]>1)
         ui->pushButton_4->setText("X");
         else
    ui->pushButton_4->setText(QVariant(a[1][4]).toString());
     if(a[2][1]>1)
         ui->pushButton_5->setText("X");
         else
    ui->pushButton_5->setText(QVariant(a[2][1]).toString());
     if(a[2][2]>1)
         ui->pushButton_6->setText("X");
         else
    ui->pushButton_6->setText(QVariant(a[2][2]).toString());
     if(a[2][3]>1)
         ui->pushButton_7->setText("X");
         else
    ui->pushButton_7->setText(QVariant(a[2][3]).toString());
     if(a[2][4]>1)
         ui->pushButton_8->setText("X");
         else
    ui->pushButton_8->setText(QVariant(a[2][4]).toString());
     if(a[3][1]>1)
         ui->pushButton_9->setText("X");
         else
    ui->pushButton_9->setText(QVariant(a[3][1]).toString());
     if(a[3][2]>1)
         ui->pushButton_10->setText("X");
         else
    ui->pushButton_10->setText(QVariant(a[3][2]).toString());
     if(a[3][3]>1)
         ui->pushButton_11->setText("X");
         else
    ui->pushButton_11->setText(QVariant(a[3][3]).toString());
     if(a[3][4]>1)
         ui->pushButton_12->setText("X");
         else
    ui->pushButton_12->setText(QVariant(a[3][4]).toString());
     if(a[4][1]>1)
         ui->pushButton_13->setText("X");
         else
    ui->pushButton_13->setText(QVariant(a[4][1]).toString());
     if(a[4][2]>1)
         ui->pushButton_14->setText("X");
         else
    ui->pushButton_14->setText(QVariant(a[4][2]).toString());
     if(a[4][3]>1)
         ui->pushButton_15->setText("X");
         else
    ui->pushButton_15->setText(QVariant(a[4][3]).toString());
     if(a[4][4]>1)
         ui->pushButton_16->setText("X");
         else
    ui->pushButton_16->setText(QVariant(a[4][4]).toString());

}
MainWindow:: verifica_matrice(int n,int m)
{
    int i,j,c=0;
    for(i=1;i<=n;i++)
        for(j=1;j<=m;j++)
            if(a[i][j])
                c++;
    if(c==n*m)
    {
        for(i=1;i<=n;i++)
            for(j=1;j<=m;j++)
                a[i][j]=2;
    ss="1";

    }
}
static int coloana(int a[][5],int j)
{
    for(int i=1;i<=4;i++)
        if(a[i][j]==1)
            return 0;
    return 1;
}
static int linie(int a[][5],int i)
{
    for(int j=1;j<=4;j++)
        if(a[i][j]==1)
            return 0;
    return 1;
}
MainWindow:: verifica_linie_pereche(int n,int m,int i)
{
    int k,c=0,c1=0,c2=0;
    if(linie(a,i)==0)//daca nu e 2 toata linia atunci verific perechea
    {
    if(i+1<=n)
       {
        for(k=1;k<=m;k++)
            if(a[i][k] && a[i+1][k])
                c++;
        }
    else
    {

        for(k=1;k<=m;k++)
            if(a[i][k] && a[1][k])
                c1++;
        for(k=1;k<=m;k++)
            if(a[i][k] && a[i-1][k])
            c2++;
    }

    if(c==m)
    {   for(k=1;k<=m;k++)
            a[i][k]= a[i+1][k]=2;
       if(i==1)
           ss+="+(not)a";
       else
           if(i==2)
               ss+="+b";
       else
          ss+="+a";
     }
    else
    {
         if(c1==m)
         {
             for(k=1;k<=m;k++)
             a[i][k]=a[1][k]=2;
          ss+="+(not)b";
         }
             if(c2==m)
         {
                 for(k=1;k<=m;k++)
                     a[i][k]= a[i-1][k]=2;
                 ss+="+a";
         }
    }
    }
}

MainWindow:: verifica_coloana_pereche(int n,int m,int j)
{
    int k,c=0,c1=0,c2=0;
    if(coloana(a,j)==0)//daca nu e 2 toata coloana atunci verific perechea
    {
    if(j+1<=m)
    {

        for(k=1;k<=n;k++)
            if(a[k][j] && a[k][j+1])
                c++;

        }
    else
    {

        for(k=1;k<=n;k++)
            if(a[k][j] && a[k][1])
                c1++;
        for(k=1;k<=n;k++)
            if(a[k][j] && a[k][j-1])
                c2++;
    }
    if(c==n)
    { for(k=1;k<=n;k++)
            a[k][j]= a[k][j+1]=2;
        if(j==1)
            ss+="+(not)c";
        else
            if(j==2)
                ss+="+d";
            else
                ss+="+c";
    }
    else
    {   if(c1==n)
        {
            for(k=1;k<=n;k++)
                a[k][j]=a[k][1]=2;
            ss+="+(not)d";
        }
        if(c2==n)
        {
            for(k=1;k<=n;k++)
                a[k][j]=a[k][j-1]=2;
            ss+="+c";
        }
    }

}
}

MainWindow:: verifica_linie(int n,int m,int i)
{
    int c=0,k;
    if(linie(a,i)==0)
    {for(k=1;k<=m;k++)
            if(a[i][k])
                c++;
        if(c==m)
        {
            for(k=1;k<=m;k++)
                a[i][k]=2;
            if(i==1)
               ss+="+(not)a*(not)b";
            else
                if(i==2)
                    ss+="+(not)a*b";
                else
                    if(i==3)
                        ss+="+a*b";
                    else
                        ss+="+a*(not)b";

        }
    }
}
MainWindow:: verifica_coloana(int n,int m,int j)
{
    int k,c=0;
    if(coloana(a,j)==0)
    {for(k=1;k<=n;k++)
            if(a[k][j])
                c++;
        if(c==n)
        { for(k=1;k<=n;k++)
                a[k][j]=2;
            if(j==1)
                ss+="+(not)c*(not)d";
            else
                if(j==2)
                   ss+="+(not)c*d";
                else
                    if(j==3)
                        ss+="+c*d";
                    else
                       ss+="+c*(not)d";

        }
    }
}
MainWindow:: calculeaza_4(int i,int j)
{
    if(i==1 && j==1)
         ss+="+(not)a*(not)c";
       else
        if(i==1 && j==2)
             ss+="+(not)a*d";
        else
            if(i==1 && j==3)
                 ss+="+(not)a*c";
        else
            if(i==2 && j==1)
                  ss+="+b*(not)c";
        else
            if(i==2 && j==2)
                  ss+="+b*d";
        else
            if(i==2 && j==3)
                 ss+="+b*c";
        else
            if(i==3 && j==1)
                 ss+="+a*(not)c";
        else
            if(i==3 && j==2)
                 ss+="+a*d";
        else
            if(i==3 && j==3)
                ss+="+a*c";

}
MainWindow:: verifica_grupare_4(int n,int m,int i,int j)
{
    if(a[i][j+1] && a[i+1][j] && a[i+1][j+1] && i+1<=n && j+1<=m && (a[i][j]!=2 || a[i][j+1]!=2 ||  a[i+1][j]!=2 || a[i+1][j+1]!=2))
    {
       a[i][j]= a[i][j+1]= a[i+1][j]= a[i+1][j+1]=2;
       calculeaza_4(i,j);
    }
}
static int transforma(int n)
{
    switch(n)
    {
    case 1:return 0;
    case 2:return 1;
    case 3:return 11;
    case 4:return 10;
    }

}
MainWindow::afiseaza(int a,int b,int c,int d)
{

        a=transforma(a);
        b=transforma(b);
        c=transforma(c);
        d=transforma(d);

        if(a%10==b%10 && a%10==0)
            ss+="+(not)b";
        else
            if(a%10==b%10 && a%10==1)
            ss+="+b";
        else
        if(a/10==b/10 && a==0)
            ss+="+(not)a";
        else
            if(a/10==b/10 && a==1)
                ss+="+a";
           ss+="*";
        if(c%10==d%10 && c%10==0)
            ss+="(not)d";
        else
            if(c%10==d%10 && c%10==1)
            ss+="d";
        else
            if(c/10==d/10 && c==0)
            ss+="(not)c";
        else
            if(c/10==d/10 && c==1)
                ss+="c";


}
MainWindow:: verifica_grupare_4_pe_margini(int n,int m)
{
   for(int i=1;i<4;i++)
       if(a[1][i] && a[n][i] && a[1][i+1] && a[n][i+1] && (a[1][i]!=2 || a[n][i]!=2 || a[1][i+1]!=2 || a[n][i+1]!=2))   
       {
           a[1][i]=a[n][i]=a[1][i+1]=a[n][i+1]=2;
           afiseaza(1,n,i,i+1);
       }
   for(int i=1;i<4;i++)
       if(a[i][1] && a[i][n] && a[i+1][1] && a[i+1][n] && (a[i][1]!=2 || a[i][n]!=2 || a[i+1][1]!=2 || a[i+1][n]!=2))
        {
           a[i][1]=a[i][n]=a[i+1][1]=a[i+1][n]=2;
           afiseaza(i,i+1,1,n);
        }
   if(a[1][1] && a[1][n] && a[n][1] && a[n][n] &&(a[1][1]!=2 || a[1][n]!=2 || a[n][1]!=2 || a[n][n]!=2))
   {

       a[1][1]=a[1][n]=a[n][1]=a[n][n]=2;
       ss+="+(not)b*(not)d";

   }
}
MainWindow:: afiseaza_2(int a,int b,int c,int d)
{

    a=transforma(a);
    b=transforma(b);
    c=transforma(c);
    d=transforma(d);
    if(a==b)
    {
       if(a==0)
           ss+="+(not)a*(not)b";
       else
           if(a==1)
               ss+="+(not)a*b";
       else
               if(a==11)
                   ss+="+a*b";
       else
                   if(a==10)
                       ss+="+a*(not)b";
       ss+="*";
       if(c==0 && d==1)
           ss+="(not)c";
       else
           if(c==1 && d==11)
               ss+="d";
       else
               if(c==11 && d==10)
                   ss+="c";
    }
    else
        if(c==d)
        {
            if(c==0)
                ss+="+(not)c*(not)d";
            else
                if(c==1)
                    ss+="+(not)c*d";
                else
                    if(c==11)
                        ss+="+c*d";
                    else
                        if(c==10)
                            ss+="+c*(not)d";
            ss+="*";
            if(a==0 && b==1)
                ss+="(not)a";
            else
                if(a==1 && b==11)
                    ss+="b";
            else
                    if(a==11 && b==10)
                        ss+="a";
        }



}
MainWindow:: verifica_grupare_2_I(int n ,int m)
{
    int i,j;
    for(i=1;i<=n;i++)
        for(j=1;j<=m;j++)
            if(a[i][j]==1)
            {if( a[i][j+1]==1 && a[i][j+2]==1 && a[i+1][j]==1 && i+1<=n && j+2<=m)
            {
                a[i][j]=a[i+1][j]=2;
                afiseaza_2(i,i+1,j,j);
            }
           else
                if( a[i+1][j]==1 && a[i+2][j]==1 && a[i][j+1]==1 && i+2<=n && j+1<=m)
                {
                    a[i][j]=a[i][j+1]=2;
                    afiseaza_2(i,i,j,j+1);
                }
            else
             if( a[i][j+1]==1 && j+1<=m)
             {
                 a[i][j]=a[i][j+1]=2;
                 afiseaza_2(i,i,j,j+1);
             }
             else
                 if( a[i+1][j]==1 && i+1<=n )
                 {
                     a[i][j]=a[i+1][j]=2;
                     afiseaza_2(i,i+1,j,j);
                 }

}
}
MainWindow:: verifica_grupare_2_II(int n ,int m)
{
    int i,j;
    for(i=1;i<=n;i++)
        for(j=1;j<=m;j++)
           { if(((a[i][j]==1 && a[i][j+1]) || (a[i][j] && a[i][j+1]==1)) && j+1<=m)
               {a[i][j]=a[i][j+1]=2;
                afiseaza_2(i,i,j,j+1);
               }

             if(((a[i][j]==1 && a[i+1][j]) || (a[i][j] && a[i+1][j]==1)) && i+1<=n)
                {   a[i][j]=a[i+1][j]=2;
                    afiseaza_2(i,i+1,j,j);
                }
            }
    //Verific colturile
    if((a[1][1]==1 && a[1][n]) || (a[1][1] && a[1][n]==1))
    {a[1][1]=a[1][n]=2;
        ss+="+(not)a*(not)b*(not)d";
    }
    if((a[1][1]==1 && a[n][1]) ||(a[1][1] && a[n][1]==1))
    {
     a[1][1]=a[n][1]=2;
     ss+="+(not)b*(not)c*(not)d";
    }
    if((a[n][1]==1 && a[n][n]) || (a[n][1] && a[n][n]==1))
    {   a[n][1]=a[n][n]=2;
        ss+="+a*(not)b*(not)d";
    }
    if((a[n][n]==1 && a[1][n]) || (a[n][n] && a[1][n]==1))
    {
        a[n][n]=a[1][n]=2;
        ss+="+(not)b*c*(not)d";
    }
//verific lateralele
if((a[1][2] && a[n][2]==1) || (a[1][2]==1 && a[n][2]) )
{
    a[1][2]=a[n][2]=2;
    ss+="+(not)b*(not)c*d";
}
if((a[1][3]==1 && a[n][3]) || (a[1][3] && a[n][3]==1))
{
   a[1][3]=a[n][3]=2;
  ss+="+(not)b*c*d";
}
if((a[2][1]==1 && a[2][n]) || (a[2][1] && a[2][n]==1))
{
    a[2][1]=a[2][n]=2;
    ss+="+(not)a*b*(not)d";
}
if((a[3][1]==1 && a[3][n]) || (a[3][1] && a[3][n]==1) )
{
    a[3][1]=a[3][n]=2;
    ss+="+a*b*(not)d";
}
}
MainWindow:: afiseaza_1(int a,int b,int c,int d)
{

    a=transforma(a)/10;
    b=transforma(b)%10;
    c=transforma(c)/10;
    d=transforma(d)%10;
    if(a)
        ss+="+a";
    else
        ss+="+(not)a";
    if(b)
        ss+="*b";
    else
        ss+="*(not)b";
    if(c)
        ss+="*c";
    else
        ss+="*(not)c";
    if(d)
        ss+="*d";
    else
        ss+="*(not)d";

}
MainWindow:: verifica_reziduri( int n,int m)
{
    int i,j;
    for(i=1;i<=n;i++)
        for(j=1;j<=m;j++)
            if(a[i][j]==1)
             afiseaza_1(i,i,j,j);
}
MainWindow:: verifica_linie_mod2(int n,int m)
{
    int i,c=0;
    if(linie(a,1)==0)
    {
        for(i=1;i<=m;i++)
        if(a[1][i])
            c++;
    if(c==m)
       {
        for(i=1;i<=m;i++)
            a[1][i]=2;
          ss+="+(not)a";
        }
    }
    if(linie(a,2)==0)
    {c=0;
    for(i=1;i<=m;i++)
        if(a[2][i])
            c++;
    if(c==m)
       {
        for(i=1;i<=m;i++)
            a[2][i]=2;
        ss+="+a";
     }
    }
}
MainWindow::afisare_mod_2(int b)
{

    b=transforma(b);
    if(b==0)
        ss+="+(not)b";
    else
        if(b==1)
            ss+="+c";
    else
            if(b==11)
            ss+="+b";


}
MainWindow::verifica_grupare_4_mod2(int n,int m,int i,int j)
{
    if(a[i][j+1] && a[i+1][j] && a[i+1][j+1] && i+1<=n && j+1<=m && (a[i][j]!=2 || a[i][j+1]!=2 ||  a[i+1][j]!=2 || a[i+1][j+1]!=2))
    {
       a[i][j]= a[i][j+1]= a[i+1][j]= a[i+1][j+1]=2;
       afisare_mod_2(j);
    }
  if(a[1][1] && a[n][1] && a[1][m] && a[n][m] && (a[1][1]!=2 || a[1][m]!=2 || a[n][1]!=2 || a[n][m]!=2))
  {
      a[1][1]=a[n][1]=a[1][m]=a[n][m]=2;
     ss+="+(not)c";
  }
}
MainWindow::afisare_grupare_2_mod2(int a,int b,int c,int l)
{
    a=transforma(a);
    b=transforma(b);
    c=transforma(c);

    if(l)
    {
        if(b==0 && a==0)
            ss+="+(not)a*(not)b";
        else
            if(b==0 && a)
                ss+="+a*(not)b";
            else
                if(b==1 && a==0)
                    ss+="+(not)a*c";
                else
                    if(b==1 && a)
                       ss+="+a*c";
                    else
                        if(b==11 && a==0)
                            ss+="+(not)a*c";
                        else
                            if(b==1 && a)
                                ss+="+a*c";
    }
    else
    {
        if(c==0)
            ss+="+(not)b*(not)c";
        else
            if(c==1)
                 ss+="+(not)b*c";
        else
                if(c==11)
                     ss+="+b*c";
        else
                    if(c==10)
                         ss+="+b*(not)c";
    }


}
MainWindow:: verifica_grupare_2_mod2_I(int n,int m)
{
    int i,j;
    for(i=1;i<=n;i++)
        for(j=1;j<=m;j++)
            if(a[i][j]==1)
            {if( a[i][j+1]==1 && a[i][j+2]==1 && a[i+1][j]==1 && i+1<=n && j+2<=m)
            {
                a[i][j]=a[i+1][j]=2;
                afisare_grupare_2_mod2(i,i+1,j,0);
            }
            else
             if( a[i][j+1]==1 && j+1<=m)
             {
                 a[i][j]=a[i][j+1]=2;
                 afisare_grupare_2_mod2(i,j,j+1,1);
             }
             else
                 if( a[i+1][j]==1 && i+1<=n )
                 {
                     a[i][j]=a[i+1][j]=2;
                     afisare_grupare_2_mod2(i,i+1,j,0);
                 }

}
}

MainWindow:: verifica_grupare_2_mod2_II(int n,int m)
{
    int i,j;
    for(i=1;i<=n;i++)
        for(j=1;j<=m;j++)
        {if(a[i][j] && a[i][j+1] && (a[i][j]!=2 || a[i][j+1]!=2) && j+1<=m)
            {
                a[i][j]=a[i][j+1]=2;
                afisare_grupare_2_mod2(i,j,j+1,1);
            }
            if(a[i][j] && a[i+1][j] && (a[i][j]!=2 || a[i+1][j]!=2) && i+1<=m)
                        {
                            a[i][j]=a[i+1][j]=2;
                            afisare_grupare_2_mod2(i,i+1,j,0);
                        }
        }
}
MainWindow::afiseaza_reziduri_mod2(int i,int j)
{

    int a,b,c;
    a=transforma(i);
    b=transforma(j)/10;
    c=transforma(j)%10;
    if(a)
        ss+="+a";
    else
        ss+="+(not)a";
    if(b)
        ss+="*b";
    else
        ss+="*(not)b";
    if(c)
        ss+="*c";
    else
        ss+="*(not)c";
}
MainWindow:: verifica__reziduri_mod2(int n,int m)
{
    int i,j;
    for(i=1;i<=n;i++)
        for(j=1;j<=m;j++)
            if(a[i][j]==1)
            {
                a[i][j]=2;
                afiseaza_reziduri_mod2(i,j);
            }
}

MainWindow::verifica_grupare_2_mod1(int n,int m)
{
    if(a[1][1] && a[1][2] &&(a[1][1]!=2 || a[1][2]!=2))
    {
        a[1][1]=a[1][2]=2;
        ss+="+(not)a";
    }
    if(a[1][1] && a[2][1] &&(a[1][1]!=2 || a[2][1]!=2))
    {
        a[1][1]=a[2][1]=2;
        ss+="+(not)b";
    }
    if(a[2][2] && a[2][1] && (a[2][1]!=2 || a[2][2]!=2 ))
    {
        a[2][2]=a[2][1]=2;
        ss+="+a";
    }
    if(a[2][2] && a[1][2] && (a[2][2]!=2 || a[1][2]!=2))
    {
        a[2][2]=a[1][2]=2;
        ss+="+b";
    }
}
MainWindow::verifica_reziduri_mod1(int n,int m)
{
    if(a[1][1]==1)
    {
        a[1][1]=2;
        ss+="+(not)a*(not)b";
    }
    if(a[1][2]==1)
    {
        a[1][2]=2;
       ss+="+(not)a*b";
    }
    if(a[2][1]==1)
    {
        a[2][1]=2;
        ss+="+a*(not)b";
    }
    if(a[2][2]==1)
    {
        a[2][2]=2;
        ss+="+a*b";
    }
}
MainWindow:: minimizeaza(int n,int m,int mod)
{
        int i,j;
     if(mod==3)
      {
        ///Verific toata matricea
        verifica_matrice( n,m);

        for(i=1;i<=n;i++)
                if(a[i][1])
                verifica_linie_pereche(n,m,i);

        for(j=1;j<=m;j++)
            if(a[1][j])
            verifica_coloana_pereche(n,m,j);

        for(i=1;i<=n;i++)
                if(a[i][1])
                verifica_linie(n,m,i);

        for(j=1;j<=m;j++)
            if(a[1][j])
            verifica_coloana(n,m,j);

        for(i=1;i<=n;i++)
            for(j=1;j<=m;j++)
                if(a[i][j])
                verifica_grupare_4(n,m,i,j);

        verifica_grupare_4_pe_margini(n,m);
        verifica_grupare_2_I(n,m);
        verifica_grupare_2_II(n,m);
        verifica_reziduri(n,m);
      }
     else
         if(mod==2)
         {
             verifica_matrice(n,m);
             verifica_linie_mod2(n,m);
             for(i=1;i<=n;i++)
                 for(j=1;j<=m;j++)
                     if(a[i][j])
                         verifica_grupare_4_mod2(n,m,i,j);
             verifica_grupare_2_mod2_I(n,m);
             verifica_grupare_2_mod2_II(n,m);
             verifica__reziduri_mod2(n,m);
         }
     else
         {
             verifica_matrice(n,m);
             verifica_grupare_2_mod1(n,m);
             verifica_reziduri_mod1(n,m);
         }
}
static int binar(int n)
{
    int x=0,p=1;
    while(n)
    {
        x=(n%2)*p+x;
        p*=10;
        n/=2;
    }
    return x;
}
static int matrice(int n)
{
    switch(n)
    {
    case 0:return 1;
    case 1:return 2;
    case 11:return 3;
    case 10:return 4;
    default:exit(1);
    }
}
static void incarca_matrice(int a[][5],int n,int mod,int care)
{
    int b,l,c;
    b=binar(n);
    if(mod==1)
    {
        l=matrice(b/10);
        c=matrice(b%10);
    }
    else
    {
    l=matrice(b/100);
    c=matrice(b%100);
    }
    if(!care)
    a[l][c]=1;
    else
        a[l][c]=2;

}

MainWindow::mod3()
{

    ui->label->setText("00");
    ui->label_2->setText("01");
    ui->label_3->setText("11");
    ui->label_4->setText("10");
    ui->label_5->setText("00");
    ui->label_6->setText("01");
    ui->label_7->setText("11");
    ui->label_8->setText("10");
    ui->Label_9->setText("ab");
    ui->Label_10->setText("cd");
    ui->Label_9->setVisible(true);
    ui->Label_10->setVisible(true);
    ui->Label_11->setVisible(true);
    ui->Label_12->setVisible(true);
    ui->label->setVisible(true);
    ui->label_2->setVisible(true);
    ui->label_3->setVisible(true);
    ui->label_4->setVisible(true);
    ui->label_5->setVisible(true);
    ui->label_6->setVisible(true);
    ui->label_7->setVisible(true);
    ui->label_8->setVisible(true);
    ui->pushButton->setVisible(true);
    ui->pushButton_2->setVisible(true);
    ui->pushButton_3->setVisible(true);
    ui->pushButton_4->setVisible(true);
    ui->pushButton_5->setVisible(true);
    ui->pushButton_6->setVisible(true);
    ui->pushButton_7->setVisible(true);
    ui->pushButton_8->setVisible(true);
    ui->pushButton_9->setVisible(true);
    ui->pushButton_10->setVisible(true);
    ui->pushButton_11->setVisible(true);
    ui->pushButton_12->setVisible(true);
    ui->pushButton_13->setVisible(true);
    ui->pushButton_14->setVisible(true);
    ui->pushButton_15->setVisible(true);
    ui->pushButton_16->setVisible(true);


}
MainWindow::mod1()
{
    ui->label->setText("0");
    ui->label_2->setText("1");
    ui->label_5->setText("0");
    ui->label_6->setText("1");
    ui->Label_9->setText("a");
    ui->Label_10->setText("b");
    ui->label->setVisible(true);
    ui->label_2->setVisible(true);
    ui->label_5->setVisible(true);
    ui->label_6->setVisible(true);
    ui->label_3->setVisible(false);
    ui->label_4->setVisible(false);
    ui->label_7->setVisible(false);
    ui->label_8->setVisible(false);
    ui->pushButton->setVisible(true);
    ui->pushButton_2->setVisible(true);
    ui->pushButton_5->setVisible(true);
    ui->pushButton_6->setVisible(true);

    ui->pushButton_3->setVisible(false);
    ui->pushButton_4->setVisible(false);
    ui->pushButton_7->setVisible(false);
    ui->pushButton_8->setVisible(false);
    ui->pushButton_9->setVisible(false);
    ui->pushButton_10->setVisible(false);
    ui->pushButton_11->setVisible(false);
    ui->pushButton_12->setVisible(false);
    ui->pushButton_13->setVisible(false);
    ui->pushButton_14->setVisible(false);
    ui->pushButton_15->setVisible(false);
    ui->pushButton_16->setVisible(false);
}

MainWindow::mod2()
{
    ui->label->setText("00");
    ui->label_2->setText("01");
    ui->label_3->setText("11");
    ui->label_4->setText("10");
    ui->label_5->setText("0");
    ui->label_6->setText("1");
    ui->Label_9->setText("a");
    ui->Label_10->setText("bc");
    ui->label->setVisible(true);
    ui->label_2->setVisible(true);
    ui->label_3->setVisible(true);
    ui->label_4->setVisible(true);
    ui->label_5->setVisible(true);
    ui->label_6->setVisible(true);
    ui->pushButton->setVisible(true);
    ui->pushButton_2->setVisible(true);
    ui->pushButton_3->setVisible(true);
    ui->pushButton_4->setVisible(true);
    ui->pushButton_5->setVisible(true);
    ui->pushButton_6->setVisible(true);
    ui->pushButton_7->setVisible(true);
    ui->pushButton_8->setVisible(true);

    ui->pushButton_9->setVisible(false);
    ui->pushButton_10->setVisible(false);
    ui->pushButton_11->setVisible(false);
    ui->pushButton_12->setVisible(false);
    ui->pushButton_13->setVisible(false);
    ui->pushButton_14->setVisible(false);
    ui->pushButton_15->setVisible(false);
    ui->pushButton_16->setVisible(false);
    ui->label_7->setVisible(false);
    ui->label_8->setVisible(false);

}    
void MainWindow::on_pushButton_17_pressed()
{
    int i,nr,mod,n,m,max=-1;
    for(int i=1;i<=4;i++)
        for(int j=1;j<=4;j++)
            a[i][j]=0;
    ss="f=";
    QString s=ui->textEdit->toPlainText();
    for(int i=6;i<s.size();i++)
    if(strchr("0123456789",this->ui->textEdit->toPlainText().toStdString().c_str()[i]))
        { if(strchr("0123456789",this->ui->textEdit->toPlainText().toStdString().c_str()[i+1]))
            {
                nr=this->ui->textEdit->toPlainText().toStdString().c_str()[i]-'0';
                nr*=10;
                nr+=this->ui->textEdit->toPlainText().toStdString().c_str()[i+1]-'0';
                i++;
            }
            else
                nr=this->ui->textEdit->toPlainText().toStdString().c_str()[i]-'0';
        if(max<nr)
            max=nr;
        }
    if(max>=8 && max <=15)
    {mod=3;
     n=m=4;
     mod3();
    }
    else
        if(max>=4 && max <=7)
          {  mod=2;
             n=2;
             m=4;
             mod2();
          }
    else
        {
            mod=1;
            n=m=2;
            mod1();
        }

    for(i=6;i<s.size() && this->ui->textEdit->toPlainText().toStdString().c_str()[i]!=')' ;i++)
    if(strchr("0123456789",this->ui->textEdit->toPlainText().toStdString().c_str()[i]))
        { if(strchr("0123456789",this->ui->textEdit->toPlainText().toStdString().c_str()[i+1]))
            {
                nr=this->ui->textEdit->toPlainText().toStdString().c_str()[i]-'0';
                nr*=10;
                nr+=this->ui->textEdit->toPlainText().toStdString().c_str()[i+1]-'0';
                i++;
            }
            else
                nr=this->ui->textEdit->toPlainText().toStdString().c_str()[i]-'0';

                incarca_matrice(a,nr,mod,0);

        }
    for(i=i;i<s.size();i++)
    if(strchr("0123456789",this->ui->textEdit->toPlainText().toStdString().c_str()[i]))
        { if(strchr("0123456789",this->ui->textEdit->toPlainText().toStdString().c_str()[i+1]))
            {
                nr=this->ui->textEdit->toPlainText().toStdString().c_str()[i]-'0';
                nr*=10;
                nr+=this->ui->textEdit->toPlainText().toStdString().c_str()[i+1]-'0';
                i++;
            }
            else
                nr=this->ui->textEdit->toPlainText().toStdString().c_str()[i]-'0';

                incarca_matrice(a,nr,mod,1);

        }
  completeaza_diagrama();
  minimizeaza(n,m,mod);
    ui->label_14->setVisible(true);
    if(ss.at(2)=='+')
      {
       QString aux;
      aux=ss.mid(3);
      ss="f=";
       ss+=aux;
      }

    ui->label_14->setText(ss);
    ui->label_14->adjustSize();
    ui->label_13->setVisible(true);
}
void MainWindow::on_pushButton_18_pressed()
{
   ui->pushButton_18->setVisible(false);
   ui->pushButton_17->setVisible(true);
   ui->textEdit->setVisible(true);
   ui->label->setVisible(true);
   ui->label_2->setVisible(true);
   ui->label_3->setVisible(true);
   ui->label_4->setVisible(true);
   ui->label_5->setVisible(true);
   ui->label_6->setVisible(true);
   ui->label_7->setVisible(true);
   ui->label_8->setVisible(true);
   ui->pushButton->setVisible(true);
   ui->pushButton_2->setVisible(true);
   ui->pushButton_3->setVisible(true);
   ui->pushButton_4->setVisible(true);
   ui->pushButton_5->setVisible(true);
   ui->pushButton_6->setVisible(true);
   ui->pushButton_7->setVisible(true);
   ui->pushButton_8->setVisible(true);
   ui->pushButton_9->setVisible(true);
   ui->pushButton_10->setVisible(true);
   ui->pushButton_11->setVisible(true);
   ui->pushButton_12->setVisible(true);
   ui->pushButton_13->setVisible(true);
   ui->pushButton_14->setVisible(true);
   ui->pushButton_15->setVisible(true);
   ui->pushButton_16->setVisible(true);
   ui->Label_9->setVisible(true);
   ui->Label_10->setVisible(true);
   ui->Label_11->setVisible(true);
   ui->Label_12->setVisible(true);
}


