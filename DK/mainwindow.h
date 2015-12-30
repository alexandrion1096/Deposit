#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT
public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();
    completeaza_diagrama();
    minimizeaza(int n,int m,int mod);
    verifica_matrice(int n,int m);
    verifica_linie_pereche(int n,int m,int i);
    verifica_coloana_pereche(int n,int m,int j);
    verifica_linie(int n,int m,int i);
    verifica_coloana(int n,int m,int j);
    verifica_grupare_4(int n,int m,int i,int j);
    verifica_grupare_4_pe_margini(int n,int m);
    afiseaza(int a,int b,int c,int d);
    calculeaza_4(int i,int j);
    afiseaza_2(int a,int b,int c,int d);
    verifica_grupare_2_I(int n ,int m);
    verifica_grupare_2_II(int n ,int m);
    afiseaza_1(int a,int b,int c,int d);
    verifica_reziduri( int n,int m);
    verifica_linie_mod2(int n,int m);
    afisare_mod_2(int c);
    verifica_grupare_4_mod2(int n,int m,int i,int j);
    afisare_grupare_2_mod2(int a,int b,int c,int l);
    verifica_grupare_2_mod2_I(int n,int m);
    verifica_grupare_2_mod2_II(int n,int m);
    verifica__reziduri_mod2(int n,int m);
    afiseaza_reziduri_mod2(int i,int j);
    verifica_grupare_2_mod1(int n,int m);
    verifica_reziduri_mod1(int n,int m);
    mod3();
    mod2();
    mod1();
    QString ss;
    int a[5][5];
private slots:
    void on_pushButton_17_pressed();

    void on_pushButton_18_pressed();

private:
    Ui::MainWindow *ui;
};

#endif // MAINWINDOW_H
