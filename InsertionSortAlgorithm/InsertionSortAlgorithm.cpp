#include <iostream>
using namespace std;

void InsertionSort(int* arr, int size) {
	for (int i = 1; i < size; i++) {
		int temp = arr[i];
		int indexOfSortedArray = i - 1;
		
		while (indexOfSortedArray >= 0 && temp < arr[indexOfSortedArray]) {
			arr[indexOfSortedArray + 1] = arr[indexOfSortedArray];
			indexOfSortedArray--;
		}
		arr[indexOfSortedArray + 1] = temp;
	}
}


int main() {
	int Array[] = {4, 1, 5, 6, 2, 7, 9};
	int size = sizeof(Array) / sizeof(Array[0]);
	
	
	// Print the Unsorted List
	for (int i = 0; i < size; i++)
		cout << Array[i] << " ";

	InsertionSort(Array, size);
	cout << endl;
	// Print the Sorted List
	for (int i = 0; i < size; i++)
		cout << Array[i] << " ";

	return 0;
}