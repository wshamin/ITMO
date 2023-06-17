#include <iostream>
using namespace std;

int* max_vect(int n, int a[], int b[]) {
    int* max_values = new int[n];
    for(int i = 0; i < n; i++) {
        max_values[i] = (a[i] > b[i]) ? a[i] : b[i];
    }
    return max_values;
}


int main() {
    int a[] = {1, 2, 3, 4, 5, 6, 7, 2};
    int b[] = {7, 6, 5, 4, 3, 2, 1, 3};
    int kc = sizeof(a) / sizeof(a[0]);  // Количество элементов массива

    int* c;
    c = max_vect(kc, a, b);  // вызов функции для создания массива

    for(int i = 0; i < kc; i++) 
        cout << c[i] << " ";
    cout << endl;

    delete []c;  // Возврат памяти.
    return 0;
}

